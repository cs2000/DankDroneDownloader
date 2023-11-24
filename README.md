# DankDroneDownloader
Giving DJI (and now, others!) the D ;)

There are many tools in the drone community which allow you to flash firmware, however DJI, much like Apple, would rather you didnt do this and they remove older firmware to more tightly control what versions their users are running. This isnt something that sits comfortably with me, you should be allowed to choose what firmware runs on your own devices and as such, i present you with DankDroneDownloader, or DDD for short. DDD archives both old and new firmware & with compaible 3rd party flashing software, will allow you to flash this firmware to your drone, camera, remote control or other device.

DDD is quite simply a custom written firmware download tool for popular DJI devices and Autel Drones. Not a windows user? Not a problem! DDD is also available in your (Chrome, Firefox or Edge) web browser over at https://www.dankdronedownloader.com . Of course we reccomend using the windows applicaion for the best features, but the choice is yours.

Having connection issues? **always** check https://dddstatus.com first!

DDD is Currently Supplying Files For:<br>
**DJI**
**Aircraft:** AGRAS MG-1A, AGRAS MG-1P RTK, AGRAS MG-1S, AGRAS T10, AGRAS T20, AGRAS T25, AGRAS T30, AGRAS T50, FPV Racer, Inspire 1, Inspire 1 Pro, Inspire 2, Inspire 3, Matrice 200, Matrice 300, Matrice 350 RTK, Matrice 600, Matrice 600 Pro, Mavic Air, Mavic Air 2, Mavic Air 2s, Mavic Mini, Mini 2, Mini 3, Mini SE, Mini 2 SE, Mini 3 Pro, Mavic Pro 1 - Incl Platinum and Alpine, Mavic Pro 2 - Incl Zoom, Mavic Pro 2 Enterprise, Mavic Pro 2 Enterprise Dual, Mavic Pro 2 RTK, Mavic Pro 3, Mavic 3 Classic, Mavic Pro 3 Enterprise, Mavic Pro 3 Thermal, Mavic Pro 3 Multispectral, Phantom 3 - 4K, Phantom 3 - Advanced, Phantom 3 - Professional, Phantom 3 - Standard, Phantom 4 - Advanced, Phantom 4 - Multispectral, Phantom 4 - Professional, Phantom 4 - Professional 2.0, Phantom 4 - Standard, Phantom 4 RTK, Phantom 4 RTK - China Only Version, Spark<br>
**Goggles:** FPV Racer (& DIY FPV Mode), FPV System, Racing Edition, Standard <br>
**Other:** AGRAS T40/T20 Generator and Charger, A3 Flight Controller, AG600 Gimball, Crystalsky 5.50 Inch, Crystalsky 7.85 Inch, D-RTK GNSS, DJI RC Plus, DJI RC Pro, DJI RC Pro Enterprise, FPV System - Air Unit, FPV System - Air Unit Lite, N3 Flight Controller, Ocusync Air System, Robomaster S1, Robomaster EP, Smart Controller, DJI Battery Station, DJI Dock, DJI Transmission, DJI RS3 Gimball, Skyport V2<br>
**Cameras** Action 2, Osmo Action, Osmo Incl Pro Raw and Standard, Osmo Pocket, Osmo Pocket 2, Osmo Pocket 3, Ronin 4D, Ronin 4D High-Bright Monitor, Ronin 4D Video Transmitter, Hasselblad X1D II 50C, Osmo Action 3, Osmo Action 4, Zenmuse DJI P1, Zenmuse DJI L1, Zenmuse L2, Zenmuse H20, Zenmuse H20N<br>
**Unknown:** AG408, A603, RC010, RC011, RCP501, TA101, WM222<br>


**Autel**
**Aircraft:** Evo, Evo II<br>


**Release Notes**

Version 3.0 <br>
Build 8707.29423<br>
SHA256 FBA9A6836F03BFF04A5A37BAD9097F7A27A2E044E4EEE9E0FABB7E284ED0C2E1<br>
<i>
- Small backend bug fixes and tweaks.

NOTE: I am aware some people are getting the error message "401 unauthorised" when trying to load previous versions of the app. Whilst this version doesnt aim to fix this, it adds some debugging information to DDD's logs so i can hopefully identify why this is happening. Often, rebooting or whitelisting DDD from your AV/Firewall apps will resolve this, but for the small subset of people where this doesnt, hopefully this version will give me some info as to whats going on.

As of this version, only V3.0 Build 8666.1215 and up will be allowed to connect to the server to enable me to cleanup code and resources used by older app versions.
</i>


Version 3.0 <br>
Build 8666.1215<br>
SHA256 D3845B0DEA2296880443FFF425701603E66857506E19B03C261B59899DC53EBB<br>
<i>
- Further reductions in the EXE size to 16.4MB by moving updater to server and further removing redundant code and components.
- Minor tweaks in various areas of app.
</i>


Version 3.0 <br>
Build 8661.40529<br>
SHA256 6C9EA34F0F59941114E1C97E7ACDFCF8EA406C55D08FB3B5292180910419D02B<br>
<i>
- Massively reduced EXE size (80Mb to 20MB) by pre-packing some of the components inside the EXE.
- Code cleanup to remove as much unecessary old code, assets etc as possible.
</i>


Version 3.0 <br>
Build 8659.134<br>
SHA256 9AFECDFF4922E0E955D0E00731744F18B91FCF588CFC89FEA8EDD59841C77736<br>
<i>
- DDD has finally launched with its brand new API backend! This enabled easier expansion, faster app performance and greater security & stability.
- A limited, but nice selection of themes are now available from the themes button, including a new dark theme!
- Search for your desired firmware with new search button on top toolbar.
- Paid firmware now shows cost in the table of firmware's available so you know the cost before download.
- Download speed and remaining time estimate shown in progress bar.
- If you buy a firmware with DDD Credits, you can now re-download this firmware as many times as needed within a (currently set to) 12 hr period. This is designed for people with weak internet connections where downloads may fail or if you accidentally delete the file.
- MANY bugfixes, refactoring and optimisations performed
</i>


**Donations**<br>
DDD welcomes donations. The servers dont cost a huge ammount to keep online, but do of course have a cost. There's also my time in sourcing and adding new firmware and of course app updates, web system updates and keeping track of new models. I do it for the lulz, but if you wanted to donate some cash for my time or server costs, this is of course much appreciated & your name will be shown in the app and on the website. Thank you very much for donating if you choose to do so! :)

PayPal Donation URL: https://www.paypal.com/donate/?cmd=_s-xclick&hosted_button_id=KRR8TN42WWL88

**Security**<br>
I have been informed that some AV apps occasionally flag DDD as malware of various forms. This is caused by the way that some components of the EXE are packed to reduce filesize of the app itself

These are of course false positives. Rest assured nothing nefarious is going on! I will try to remember (i am human) to update the link below with results for the current app version.

https://www.virustotal.com/gui/file-analysis/Y2M4N2VlODFlYmNmNjJkNDJmNzg3MmUxNzY4NDFiNGI6MTY5OTAyODk5Ng==


---

App has been tested to run on Windows 10 1607 upwards. You must be running Dot Net Framework 7.0 or higher however. If you are missing this, the app will tell you and offer to download it for you from Microsoft.


Come join our community!
https://dji-rev.com

-cs2000