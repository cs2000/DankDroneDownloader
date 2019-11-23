# DankDroneDownloader
Giving DJI the D ;)

A Custom Firmware Download Tool for DJI Drones Written in C#

Currently Supplying Files For:<br>
**Aircraft:** Agras MG-1S, Agras MG-1P, Inspire 1, Inspire 1 Pro, Inspire 2, Matrice 100, Matrice 600, Matrice 600 Pro, Mavic Pro (Incl Platinum & Alpine), Mavic Air, Mavic Pro 2, Phantom 3 Standard, Phantom 3 Professional, Phantom 3 Advanced, Phantom 3 4K, Phantom 4 Standard, Phantom 4 Professional, Phantom 4 Advanced, Phantom 4 2.0, Phantom 4 RTK, Phantom RTK (China Version), Spark, Mavic Mini<br>
**Remote Control:** Inspire 1, Mavic Pro, Mavic Air, Mavic Pro 2, Phantom 3 Advanced, Spark, FPV System<br>
**Goggles:** DJI (Standard), DJI (Racing) DJI (FPV System)<br>
**Other:** Ocusync Air System, A3 Flight Controller, DJI-RTK Ground Station, N3 Flight Controller, CrystalSky 5.5 & 7.8 Inch, Osmo (Pro, Raw, Standard & Pocket), FPV System Air Unit<br>

<br>

**Release Notes**<br>
Version 2.0 <br>
Build 7266.24220 <br>
SHA256 0b3b82550b869582e826f83b38eaa74ca5a1046248e77e0f6affd8eab0ad9a34<br>
Yes, its here, a major overhaul to DDD has just been released complete with a whole host of changes!<br>
This is a significant and very important update, please accept it wqhen prompted. The old versions of DDD (anything below 2.0) will cease to function as of 30th of November 2019 due to the backend improvements made for DDD 2.0<br>
<i>
- Tne entire of the app has been reqritten from the ground up using modern libraries to improbe basically everything, but keep the app you know and love.
- Familier, but new GUI design. The same filters are available, however we have a small splash of colour.
- If you exit the app, it will remember which category you had selected before and take you straight back to it.
- MUCH faster app opening, this is down from 20-30 seconds to less then 5 now!
- The app now uses multiple backend databases to ensure firmware info is always consistant and accurite.
- Propper automatic failover now added. All firmware and database info is held on multiple server enabling auto failover if a server, or a file goes offline on one host.
- New accounements page from within the app. Check here regularys as brief release notes and service announcements will be posted here.
</i>

Version 1.5 <br>
Build 7221.31372 <br>
<i>
- Added in some code in the back-end to make available for use a secondary firmware server. This is for redundancy.
- Fixed a security issue, both client and server side, which allowed undesirable files to be provided through the Firmware Upload utility and possible privilidge escalation on the server.
</i>

Version 1.5 <br>
Build 7116.21904 <br>
SHA256 7de8dd1f650238375c2edc9299c1c13efac937a3cae46cf2ce6e92da396ec971 <br>
<i>
- Add a new line just below the firmware list window which shows the SHA256 hash of the firmware file, this can then be verified after your download is complete to ensure the file is legitimate and a valid package.
- Small GUI bug fixes, missed the drone icon on some of the window elements, text alignment tweaks.
</i>

Version 1.5 <br>
Build 6945.21923 <br>
<i>
- Total rewrite of the firmware upload mechanism. Uploader is built into the app now rather than relying on a nasty PHP embedded page. Multiple firmware uploads are now supported aswell as marking partial/failed uploads.
</i>

Version 1.5 <br>
Build 6808.28756 <br>
<i>
- Added firmware uploader so you can submit missing firmware files for addition to DDD.<br>
<b>- I have to be able to figure out what drones your uploaded files are for!!! If you want them added, make sure you call them something sensible so i can identify and validate them before i add them to the DDD listings.</b><br>
- Added link to DUMLDore by Jezzab.
</i>

Version 1.5 <br>
Build 6659.39278 <br>
<i>
- Fixed a couple more GUI bugs (resizing of window elements was possible).<br>
- If you donate to DDD, you now get credits from within the app, check the "Donate" button to see it working.<br>
- Re-coded the scroller's within the app to take data from a server rather than being "baked in".
</i>

Version 1.5 <br>
Build 6650.20845 <br>
<i>
- Fixed GUI bug introduced with previous version.
</i>

Version 1.5 <br>
Build 6649.35372 <br>
<i>
- Fixed GUI bug introduced with previous version.
</i>

Version 1.5 <br>
Build 6648.40824 <br>
<i>
- Altered some small elements of the GUI, added Paypal donate buttons, scene greetings and a license.<br>
- Small bug fixes.
</i>

Version 1.0 <br>
Build 6560.41728 <br>
<i>
- Added link to DUMLdore by Jezzab. The people "in the know" knew this app already. But if you're new to the scene, it allows Windows users to flash the FW files they download with DankDroneDownloader. Just seemed a good idea to link mine and Jezzab's work in this way.
</i>

Version 1.0 <br>
Build 6556.25899 <br>
<i>
- Added auto update feature. This was done to preserve the app if the host deletes the BIN files. App will prompt if there is an update.
</i>

Version 1.0 <br>
<i>
- Initial Release
</i>

<br>

**Security**<br>
I have been informed that some AV apps very occasionally trigger when DDD is ran. This is most likely due to the way it downloads the files, the files are not downloaded to disk in the standard way until the "Save As" dialogue comes up, this could be seen by some AV algorithms as being a download that the user didn’t initiate.

Rest assured nothing nefarious is going on!

https://www.virustotal.com/gui/file/7de8dd1f650238375c2edc9299c1c13efac937a3cae46cf2ce6e92da396ec971/detection


---

Source code has been removed to protect the app and the source files for firmware.

App should run on any windows machine from 7 upwards. You must be running Dot Net 4.5 however.

These files are stored on an FTP server however the files themselves are community sourced and are untouched/unmolested.

Come join us!
https://join.slack.com/t/dji-rev/shared_invite/enQtMjk5OTEyMzcyMjI3LTdlZjY4NzQ5M2M2NmE5ZWM4OTgyNThmZDVmZjdjODE4ODYyNmYwZjYxMDcyYzcxNmZlYzI5ZjI2ZGQ2NGY1ZTc

-cs2000

---

### #DeejayeyeHackingClub information repos aka "The OG's" (Original Gangsters)

http://dji.retroroms.info/ - "Wiki"

https://github.com/fvantienen/dji_rev - This repository contains tools for reverse engineering DJI product firmware images.

https://github.com/Bin4ry/deejayeye-modder - APK "tweaks" for settings & "mods" for additional / altered functionality

https://github.com/hdnes/pyduml - Assistant-less firmware pushes and DUMLHacks referred to as DUMBHerring when used with "fireworks.tar" from RedHerring. DJI silently changes Assistant? great... we will just stop using it.

https://github.com/MAVProxyUser/P0VsRedHerring - RedHerring, aka "July 4th Independence Day exploit", "FTPD directory transversal 0day", etc. (Requires Assistant). We all needed a public root exploit... why not burn some 0day?

https://github.com/MAVProxyUser/DUMLrub - Ruby port of PyDUML, and firmware cherry picking tool. Allows rolling of custom firmware images.

https://github.com/jezzab/DUMLdore - Even windows users need some love, so DUMLDore was created to help archive, and flash dji_system.bin files on windows platforms.

https://github.com/MAVProxyUser/DJI_ftpd_aes_unscramble - DJI has modified the GPL Busybox ftpd on Mavic, Spark, & Inspire 2 to include AES scrambling of downloaded files... this tool will reverse the scrambling

https://github.com/darksimpson/jdjitools - Java DJI Tools, a collection of various tools/snippets tied in one CLI shell-like application

https://github.com/cs2000/DankDroneDownloader - Windows based firmware download utility for all recent DJI products. Allows you to get firmware files to use with other apps such as DUMLdore, PyDuml, DUMLrub etc
