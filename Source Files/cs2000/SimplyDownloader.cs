using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace cs2000
{
	public class SimplyDownloader: IDisposable
	{
		private string _downloadedURL = "";
		private string _tempFileName = "";
		private WebClient _client;

		/// <summary>
		/// Default constructor
		/// </summary>
		public SimplyDownloader()
		{
			_client = new WebClient();
			_client.DownloadProgressChanged += Client_DownloadProgressChanged;
			_client.DownloadFileCompleted += Client_DownloadFileCompleted;
		}

		/// <summary>
		/// Check current downloader is busy
		/// </summary>
		public bool IsBusy
		{
			get { return _client.IsBusy; }
		}

		/// <summary>
		/// Return temporary file name used for download
		/// </summary>
		public string GetDownloadedFileName
		{
			get { return _tempFileName; }
		}

		/// <summary>
		/// Return downloaded URL
		/// </summary>
		public string DownloadedURL
		{
			get { return _downloadedURL; }
		}
		/// <summary>
		/// Fire when download complete
		/// </summary>
		public event EventHandler<AsyncCompletedEventArgs> OnDownloadComplete;

		/// <summary>
		/// Fire when progress changed
		/// </summary>
		public event EventHandler<DownloadProgressChangedEventArgs> OnReportProgress;

		/// <summary>
		/// Download file
		/// </summary>
		/// <param name="url">URL for download</param>
		public async void DownloadFile(string url)
		{
			_downloadedURL = url;
			_tempFileName = Path.GetTempFileName();
			try
			{
				await _client.DownloadFileTaskAsync(url, _tempFileName);
			}
			catch
			{
				//Do nothing on this case
			}
		}

		/// <summary>
		/// Stop pending download
		/// </summary>
		public void StopDownload()
		{
			if (_client.IsBusy) { _client.CancelAsync(); }
		}

		/// <summary>
		/// Client disposed
		/// </summary>
		public void Dispose()
		{
			if (_client.IsBusy)
			{
				_client.CancelAsync();
			}
			_client.Dispose();
		}

		/// <summary>
		/// Translate event to high level
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			OnDownloadComplete?.Invoke(this, e);
		}

		/// <summary>
		/// Translate event to high level
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			OnReportProgress?.Invoke(this, e);
		}


	}
}
