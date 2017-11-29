using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace cs2000
{
	/// <summary>
	/// Firmware type
	/// </summary>
	public enum FirmwareType
	{
		Unknown,
		AC,
		RC
	}

	/// <summary>
	/// Single firmware object
	/// </summary>
	public class SingleFirmware
	{
		//Model of drone
		public string Model;
		//Type of firmware
		public FirmwareType Type;
		//Firmware version
		public string Version;
		//Link to firmware binary
		public string Binary;
		//Link to release notes
		public string ReleaseNotes;
		//Release notes content
		public string NotesContent;
		//Size of firmware file
		public string Size;

		/// <summary>
		/// Default constructor
		/// </summary>
		public SingleFirmware()
		{
			Model = "";
			Type = FirmwareType.Unknown;
			Version = "";
			Binary = "";
			ReleaseNotes = "";
			NotesContent = "";
			Size = "";
		}
	}

	/// <summary>
	/// Data storage for all models and firmwares
	/// </summary>
	public class DataStorage
	{
		//Root URL
		private string _rootURL = "http://dji.polybotes.feralhosting.com/DJI-Firmware/BIN/";
		/// <summary>
		/// List of models
		/// </summary>
		public List<SingleFirmware> Firmwares;
		/// <summary>
		/// Fire when new model start download
		/// </summary>
		public event EventHandler<string> OnNewModelDownloading;

		/// <summary>
		/// Default constructor
		/// </summary>
		public DataStorage()
		{
			Firmwares = new List<SingleFirmware>();
		}

		/// <summary>
		/// Update models from site
		/// </summary>
		public async Task Update()
		{
			Firmwares = new List<SingleFirmware>();
			//Download initial data
			string rootData = "";
			List<string> rootLinks = new List<string>();
			using (WebClient client = new WebClient())
			{
				rootData = await client.DownloadStringTaskAsync(_rootURL);
				//Collect all top level links
				Regex rootRegexObj = new Regex(@"<tr><td valign=""top""><img src=""/icons/folder\.gif"" alt=""\[DIR\]""></td><td><a href=""(?<link>.+?)"">(?<name>.+?)</a>", RegexOptions.Singleline);
				MatchCollection matchCollection = rootRegexObj.Matches(rootData);
				foreach (Match match in matchCollection)
				{
					string url = _rootURL + match.Groups["link"].Value;
					string modelName = match.Groups["name"].Value.Trim(new char[] { '/' });
					OnNewModelDownloading?.Invoke(this, modelName);
					Firmwares.AddRange(await GetAllLinks(url, modelName, FirmwareType.AC));
				}
			}
		}

		/// <summary>
		/// Get all links from page
		/// </summary>
		/// <param name="url">URL for get links</param>
		/// <param name="model">Model name</param>
		/// <param name="type">Firmware type</param>
		/// <returns>List of firmwares</returns>
		private async Task<List<SingleFirmware>> GetAllLinks(string url, string model, FirmwareType type)
		{
			List<SingleFirmware> retval = new List<SingleFirmware>();
			using (WebClient client = new WebClient())
			{
				string modelData = await client.DownloadStringTaskAsync(url);
				//Get all links from page
				Regex allLinksRegex = new Regex(@"<tr><td.+?href=\""(?<link>.+?).+?</td></tr>", RegexOptions.Singleline);
				MatchCollection matchCollection = allLinksRegex.Matches(modelData);
				bool rcFound = false;
				foreach(Match match in matchCollection)
				{
					Match currentLineMatch = Regex.Match(match.Value, @"<tr><td.+?href=\""(?<link>.+?)"".+align=""right"">(?<size>.+?)<", RegexOptions.Singleline);
					string link = currentLineMatch.Groups["link"].Value;
					string size = currentLineMatch.Groups["size"].Value;
					if (link == "RC/")
					{
						//RC folder found. Download it later
						rcFound = true;
						continue;
					}
					if (!(link.EndsWith(".bin") || link.EndsWith(".txt") || link.EndsWith(".tar")))
					{
						continue;
					}
					//Add data
					string version = Regex.Match(link, "V(?<version>.+?)_", RegexOptions.Singleline).Groups["version"].Value;
					SingleFirmware singleFirmware = new SingleFirmware
					{
						Model = model,
						Type = type,
						Version = version
					};
					//Process binary item
					if (link.EndsWith(".bin") || link.EndsWith(".tar"))
					{
						//Get existing item if any
						int previousIndex = retval.FindIndex(item => item.Model == singleFirmware.Model && item.Version == singleFirmware.Version && item.Type == singleFirmware.Type);
						singleFirmware.Binary = url + link;
						singleFirmware.Size = size;
						if (previousIndex == -1)
						{
							//If no previous item exist - add
							retval.Add(singleFirmware);
						}
						else
						{
							//If previous item exist - modify
							retval[previousIndex].Binary = singleFirmware.Binary;
							retval[previousIndex].Size = size;
						}
					}
					//Process note item
					if (link.EndsWith(".txt"))
					{
						//Get existing item if any
						int previousIndex = retval.FindIndex(item => item.Model == singleFirmware.Model && item.Version == singleFirmware.Version && item.Type == singleFirmware.Type);
						singleFirmware.ReleaseNotes = url + link;
						using (WebClient notesClient = new WebClient())
						{
							string notesText = await notesClient.DownloadStringTaskAsync(singleFirmware.ReleaseNotes);
							notesText = notesText.Replace("\n", "\r\n");
							singleFirmware.NotesContent = notesText;
							if (previousIndex == -1)
							{
								//If no previous item exist - add
								retval.Add(singleFirmware);
							}
							else
							{
								//If previous item exist - modify
								retval[previousIndex].ReleaseNotes = singleFirmware.ReleaseNotes;
								retval[previousIndex].NotesContent = singleFirmware.NotesContent;
							}
						}
					}
				}
				//If RC directory found - process RC with Firmware type = RC
				if (rcFound)
				{
					retval.AddRange(await GetAllLinks(url + "RC/", model, FirmwareType.RC));
				}
			}
			return retval;
		}
	}
}
