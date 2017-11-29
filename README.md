# DankDroneDownloader
Giving DJI the D ;)

A Custom Firmware Download Tool for DJI Drones Written in C#

Currently Supplying Files For:<br>
**Aircraft:** P4, P4P, P4A, Mavic, Spark, I2<br>
**Remote Control:** Mavic, Spark<br>
**Goggles:** DJI<br>

---

If you're after DJI Drone or Goggle firmware, this is the app, just grab the EXE. If you wana to dig around a little more, feel free to take a peek at my sources if your intrested.

Source code:
https://www.github.com/cs2000/DankDroneDownloader-src

App should run on any windows machine from 7 upwards. You must be running Dot Net 4.5 however.

These files are stored on an FTP server however the files themselves are community sourced and are untouched/unmoleseted.

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
