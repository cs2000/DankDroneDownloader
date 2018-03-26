# DankDroneDownloader
Giving DJI the D ;)

A Custom Firmware Download Tool for DJI Drones Written in C#

Currently Supplying Files For:<br>
**Aircraft:** Phantom 4 Standard, Phantom 4 Professional, Phantom 4 Advanced, Mavic Pro (Incl Platinum & Alpine), Mavic Air, Spark, Inspire 1, Inspire 2, Agras MG-1S. Matrice 100, Matrice 600, Matrice 600 Pro<br>
**Remote Control:** Mavic, Spark<br>
**Goggles:** DJI (Standard), DJI (Racing)<br>
**Other:** Ocusync Air System, A3 Flight Controller, D-RTK Ground Station, N3 Flight Controller<br>

**Release Notes**<br>
Version 1.5 <br>
Build 6659.39278 <br>
Fixed a couple more GUI bugs (resizing of window elements was possible
If you donate to DDD, you now get credits from within the app, check the "Donate" button to see it working
Re-coded the scroller's within the app to take data from a server rather than being "baked in"

Version 1.5 <br>
Build 6650.20845 <br>
Fixed GUI bug introduced with previous version.

Version 1.5 <br>
Build 6649.35372 <br>
Fixed GUI bug introduced with previous version.

Version 1.5 <br>
Build 6648.40824 <br>
Altered some small elements of the GUI, added Paypal donate buttons, scene greetings and a license. Small bug fixes.

Version 1.0 <br>
Build 6560.41728 <br>
Added link to DUMLdore by Jezzab. The people "in the know" knew this app already. But if you're new to the scene, it allows Windows users to flash the FW files they download with DankDroneDownloader. Just seemed a good idea to link mine and Jezzab's work in this way.

Version 1.0 <br>
Build 6556.25899 <br>
Added auto update feature. This was done to preserve the app if the host deletes the BIN files. App will prompt if there is an update.

Version 1.0 <br>
Initial Release


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

https://github.com/MAVProxyUser/dji_system.bin - Current Archive of dji_system.bin files that compose firmware updates referenced by MD5 sum. These can be used to upgrade and downgrade, and root your I2, P4, Mavic, Spark, Goggles, and Mavic RC to your hearts content. (Use with pyduml or DUMLDore)

https://github.com/MAVProxyUser/firm_cache - Extracted contents of dji_system.bin, in the future will be used to mix and match pieces of firmware for custom upgrade files. This repo was previously private... it is now open.

https://github.com/MAVProxyUser/DUMLrub - Ruby port of PyDUML, and firmware cherry picking tool. Allows rolling of custom firmware images.

https://github.com/jezzab/DUMLdore - Even windows users need some love, so DUMLDore was created to help archive, and flash dji_system.bin files on windows platforms.

https://github.com/MAVProxyUser/DJI_ftpd_aes_unscramble - DJI has modified the GPL Busybox ftpd on Mavic, Spark, & Inspire 2 to include AES scrambling of downloaded files... this tool will reverse the scrambling

https://github.com/darksimpson/jdjitools - Java DJI Tools, a collection of various tools/snippets tied in one CLI shell-like application

https://github.com/cs2000/DankDroneDownloader - Windows based firmware download utility for all recent DJI products. Allows you to get firmware files to use with other apps such as DUMLdore, PyDuml, DUMLrub etc
