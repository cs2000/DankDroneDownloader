# DankDroneDownloader
Giving DJI (and now, others!) the D ;)

A custom written firmware download tool for popular drones. Also now available in your (Chrome, Firefox or Edge) web browser over at http://dankdronedownloader.com/DDD2/app for non windows based users!

Currently Supplying Files For:<br>
**DJI**
**Aircraft:** AGRAS MG-1P, AGRAS MG-1S, AGRAS T30, Inspire 1, Inspire 1 Pro, Inspire 2, Matrice 100, Matrice 200, Matrice 200 V2, Matrice 300, Matrice 600, Matrice 600 Pro, Mavic Air, Mavic Air 2, Mavic Air 2s, Mavic Mini, Mavic Mini 2, Mavic Pro 1 - Incl Platinum and Alpine, Mavic Pro 2 - Enterprise, Mavic Pro 2 - Enterprise Dual, Mavic Pro 2 - Enterprise RTK, Mavic Pro 2 - Incl Zoom, Phantom 3 4K, Phantom 3 Advanced, Phantom 3 Professional, Phantom 3 Standard, Phantom 4 Advanced, Phantom 4 Pro 2.0, Phantom 4 Professional, Phantom 4 RTK, Phantom 4 RTK - China Only Version, Phantom 4 Standard, Spark<br>
**Remote Control:** Crystalsky 5.50 Inch, Crystalsky 7.85 Inch, Smart Controller<br>
**Goggles:** Racing Edition, Standard, FPV System<br>
**Other:** A3 Flight Controller, D-RTK GNSS, Ocusync Air System, FPV System - Air Unit, N3 Flight Controller, Osmo - Incl Pro Raw and Standard, Osmo Action, Osmo Pocket<br>
**Unknown:** WM222, A406, AG410, A411, A500<br>


**Autel**
**Aircraft:** Evo, Evo II<br>

<br>

**Release Notes**<br>
Version 2.4 <br>
Build 7888.31293<br>
SHA256 69A98268E413D1F2B593006947A011E716AA2F5554C1C7A63F9D31B08EA1322D<br>
<i>
- Minor bug fixes.
</i>

Version 2.0 <br>
Build 7638.2078<br>
SHA256 7750B892DE997233CA7CCB273A2B4D972C9744F15C71CA431EC7EDB3A20642B6<br>
<i>
- Due to the recent addition of Autel firmware, the app now has a 'Brand' filter where you can pre-filter results for DJI or Autel. Any future brands DDD supports can now be easily added!
- Issue #18 recently reported by ddzobov has now been fixed. The app was crashing when large firmwares (such as SmartController) were downloaded. A new file handling method has been written for these larger files.
</i>

Version 2.0 <br>
Build 7882.12112<br>
SHA256 7C6B1FFF2F123A3C08A253E7E8773B4F1733BFE0CA84278C1C1C19B7FACB2F1B<br>
<i>
- Added the DJI Anti Rollback version number below the SHA256 hash of the firmware so you can easily see if downgrading will be blocked for your desired firmware. THis will be coming to the web version soon.
- Re-addition of the Drone-Hacks lock to the top bar of the app. Go visit these guys for your drone hacking needs!
</i>

Version 2.0 <br>
Build 7636.41342<br>
SHA256 1E98577A021A94910E676E170626407E16AA3117C30643B7805DADB8933E6BED<br>
<i>
- Update of the Copyright date, seems i slipped behind with this!
- Re-addition of the Drone-Hacks lock to the top bar of the app. Go visit these guys for your drone hacking needs!
</i>

Version 2.0 <br>
Build 7574.18095<br>
SHA256 5ff5f86cc7dc1b40de9ba9b45cb574a3ff88ed9aa8b08c7b88eaabf02b7934cd<br>
<i>
- For the very first time, DDD will now archive firmware for other brands of drones. This release includes support for the popular Autel series of drones with the Evo and the Evo 2. Further support for new manufacturers can now be added without new app updates and will be done as and when there is a demand or need for them. So far, Autel dont seem to apply as many of the same restrictions to their owners, but i want the hacking community to begin work on unlocking the few resttictions they do have (altitude and Chinese NFZ's) along with anything else we can unlock in terms of more performance, lets see!
- Bug Fixes.
- In future updates, there will be a "Brand" filter at the top of the app to select between DJI and Autel.
</i>

Version 2.0 <br>
Build 7471.25679 <br>
SHA256 ca116576322e592da2240ac60a1e6ecb839157a8a4bc916c64f2ff9ae76c360c<br>
<i>
- Simple bug fix. Forgot to compile all required image assets causing a few GUI issues.
</i>

Version 2.0 <br>
Build 7460.19289 <br>
SHA256 f6ec20dd1d87483467eff546d774eec67c6d5da2e4289a54c36c5469cf4a7f66<br>
Once again, i am aware of the app not functioning inside of China or anywhere else protected by the "Great Fireall". Please dont raise GitHub Issue's about this as they will just be closed. I have no desire to add extra servers and a ton of additional code to the app just to bypass the censorship from a dictatorship government.<br>
<i>
- Changes to the GUI so that the old 'AC' and 'RC' labels have now been replaced with 'Aircraft' and 'Remote' respectively, this is to make things clearer for new users.
- DUMLDore link on the top toolbar replaced with Drone-Hacks, the new way to flash your firmware and further hack your drone. DUMLDore only supported older drones (sadly), so time to update the link.
</i>

Version 2.0 <br>
Build 7430.26169 <br>
SHA256 980386950c6135381eeefc31e4adc5b6974cebf644750e8a9185ed4e976b52e4<br>
Nothing major in this release. Just some minor bug fixes implimented to ensure app stability.<br>
I am aware of the app not functioning inside of China or anywhere else protected by the "Great Fireall". There is little i can do about this right now.<br>

Version 2.0 <br>
Build 7266.24220 <br>
SHA256 0b3b82550b869582e826f83b38eaa74ca5a1046248e77e0f6affd8eab0ad9a34<br>
Yes, its here, a major overhaul to DDD has just been released complete with a whole host of changes!<br>
This is a significant and very important update, please accept it when prompted. The old versions of DDD (anything below 2.0) will cease to function as of 30th of November 2019 due to the backend improvements made for DDD 2.0<br>
<i>
- The entire of the app has been rewritten from the ground up using modern libraries to improve basically everything, but keep the app you know and love.
- Familier, but new GUI design. The same filters are available, however we have a small splash of colour.
- If you exit the app, it will remember which category you had selected before and take you straight back to it.
- MUCH faster app opening, this is down from 20-30 seconds to less then 5 now!
- The app now uses multiple backend databases to ensure firmware info is always consistant and accurite.
- Propper automatic failover now added. All firmware and database info is held on multiple server enabling auto failover if a server, or a file goes offline on one host.
- New accounements page from within the app. Check this regulary as brief release notes and service announcements will be posted here.
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
- Re-Added link to DUMLDore by Jezzab.
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

App should run on any windows machine from 7 upwards. You must be running Dot Net Framework 4.5 however.

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
