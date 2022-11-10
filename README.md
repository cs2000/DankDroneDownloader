# DankDroneDownloader
Giving DJI (and now, others!) the D ;)

There are many tools in the drone community which allow you to flash firmware, however DJI, much like Apple, would rather you didnt do this and they remove older firmware to more tightly control what versions their users are running. This isnt something that sits comfortably with me, you should be allowed to choose what firmware runs on your own devices and as such, i present you with DankDroneDownloader, or DDD for short. DDD archives both old and new firmware for many popular DJI products & with (compaible 3rd party flashing software), will allow you to flash this firmware to your drone, camera, remote control or other random DJI device.

DDD is quite simply a custom written firmware download tool for popular DJI devices and Autel Drones. Not a windows user? Not a problem! DDD is also available in your (Chrome, Firefox or Edge) web browser over at http://dankdronedownloader.com/DDD2/app. Of course we reccomend using the windows applicaion for the best features, but the choice is yours.

DDD is Currently Supplying Files For:<br>
**DJI**
**Aircraft:** AGRAS MG-1A, AGRAS MG-1P RTK, AGRAS MG-1S, AGRAS T10, AGRAS T20, AGRAS T30, FPV Racer, Inspire 1, Inspire 1 Pro, Inspire 2, Matrice 100, Matrice 200, Matrice 300, Matrice 600, Matrice 600 Pro, Mavic Air, Mavic Air 2, Mavic Air 2s, Mavic Mini, Mavic Mini 2, Mavic Mini 3, Mavic Mini SE, Mavic Pro 1 - Incl Platinum and Alpine, Mavic Pro 2 - Incl Zoom, Mavic Pro 2 Enterprise, Mavic Pro 2 Enterprise Dual, Mavic Pro 2 RTK, Mavic Pro 3, Mavic Pro 3 Enterprise, Mavic Pro 3 Thermal, Phantom 3 - 4K, Phantom 3 - Advanced, Phantom 3 - Professional, Phantom 3 - Standard, Phantom 4 - Advanced, Phantom 4 - Multispectral, Phantom 4 - Professional, Phantom 4 - Professional 2.0, Phantom 4 - Standard, Phantom 4 RTK, Phantom 4 RTK - China Only Version, Spark<br>
**Goggles:** FPV Racer (& DIY FPV Mode), FPV System, Racing Edition, Standard <br>
**Other:** A3 Flight Controller, AG600 Gimball, Crystalsky 5.50 Inch, Crystalsky 7.85 Inch, D-RTK GNSS, DJI RC Plus, DJI RC Pro, FPV System - Air Unit, FPV System - Air Unit Lite, N3 Flight Controller, Ocusync Air System, Robomaster S1, Robomaster EP, Smart Controller, DJI Battery Station<br>
**Cameras** Action 2, Osmo Action, Osmo Incl Pro Raw and Standard, Osmo Pocket, Osmo Pocket 2, Ronin 4D, Hasselblad X1D II 50C<br>
**Unknown:** AG411, AG601, WM222, AC202, ASVL01, RCP501, WM1615<br>


**Autel**
**Aircraft:** Evo, Evo II<br>

<br>

**Release Notes**<br>
Version 2.7 <br>
Build 8101.3038<br>
SHA256 A6D9B0BC16BFCC21AE2156CF2600359FBCC189FC1F00F072005A3EE527A20331<br>
<i>
- Quick little update, The update prompt window will now auto-resize to fit the update release notes automatically!
</i>

Version 2.7 <br>
Build 8100.36723<br>
SHA256 4EF2523AF5082526AADE91B3BDC2A3A7E14B4AB0FD652F4B466A53F30DEB0486<br>
**Special Note** - From this version onwards, support for **ALL** older versions of DDD has had to be removed. This was of course a difficult decision as i know i will lose some users, but was done to better support the app moving forwards. I have tried my very best to support the all updates, right back to November 2019's Version 2.0 build 7266.24220 whilst at the same time making database and app changes to add new features, but it has gotten to an almost un-managable state and as such i had to assess the app and remove all legacy functions from the database. From here onwards, the app will check in with the server each time its opened to see if its version is still supported. When/if future large scale changes have to be made, the app will tell you your version is out-of-date and that it must be updated, if you refuse the update, the app will quit. Whilst i dont anticipate doing this on a regular basis, even i dont like to be forced to update apps, there comes a time that to continue to improve, i have to cut the old versions lose.<br>
However, we have an issue with the old versions out there, these dont have any idea about the server side changes and when i make the database swap they would simply die with a cryptic error message, this isnt good! My only way forward to force an update for these users is to purge the older database's content, but leave enough of the core structure out there so they can still connect. When these older versions are opened, the users will see a single firmware record telling people to update their app version. Im really sorry for having to force an update in this way, but in order to maintain the speed and reliability of the app, i had no other choice. You have my word this will be the only time i do it in this fashion as i understand the 'personal choice' around when you should have to update, but the changes im making, as always, are for the better and for you guys.<br>
The older database framework will stay up until around the end of June 2022, by then, im sure everyone who uses DDD would have opened it at least once and updated if they still wish to use the platform.
**TL:DR** Please update to this version to continue using DDD due to large scale database changes. cs2000<br>
<i>
- New 'Minimum Required Version' mechanism added to allow future app developments to have a smooth transition.
- Adverts no longer duplicate when you refresh the firmware list.
- Major back-end database overhaul.
- Further redundant code cleaned up as a result of database cleanup.
- Overhaul of the update mechanism to allow it to work with the 'Minimum Required Version' system.
</i>

Version 2.6 <br>
Build 8042.27234<br>
SHA256 FA25B1197E6033FFC74ABF580D89EC3D8E58813054E6D8338139145943753D5F<br>
<i>
- Small GUI changes, just shuffled a few misc things around!
- Codebase cleanup, removing some of the old assets and functions used by previous versions of the app.
</i>

Version 2.5 <br>
Build 7979.27152<br>
SHA256 DCFB6620B3F7BAE843D4C1D10563CADE0D1E2CC363D7D2D89603F4CD61CF0472<br>
<i>
- Fixed an issue where the Download button wouldnt become active for the first firmware in the list until you clicked on another firmware first. This meant it was impossible to download firmware for models where only a single firmware was available, this is now resolved.
</i>

Version 2.4 <br>
Build 7888.31293<br>
SHA256 69A98268E413D1F2B593006947A011E716AA2F5554C1C7A63F9D31B08EA1322D<br>
<i>
- Minor bug fixes.
</i>

**Donations**<br>
DDD welcomes donations. The servers dont cost a huge ammount to keep online, but do ofcourse have a cost. Theirs also my time in sourcing and adding new firmware and of course app updates, web system updates and keeping trackm of new models. I do it for the lulz, but if you wanted to donate some cash for my time or server costs, this is of course much appreciated & your name will be shown in the app and on the website. Thank you very much for donating if you choose to do so! :)

PayPal Donation URL: https://www.paypal.com/donate/?cmd=_s-xclick&hosted_button_id=KRR8TN42WWL88

**Security**<br>
I have been informed that some AV apps very occasionally trigger when DDD is ran. This is most likely due to the way it downloads the files, the files are not downloaded to disk in the standard way until the "Save As" dialogue comes up, this could be seen by some AV algorithms as being a download that the user didn’t initiate.

Rest assured nothing nefarious is going on! I will try to remember (i am human) to update the link below with results for the current app version.

https://www.virustotal.com/gui/file-analysis/ODg2NDMwNDc4MzQ0YmIzZTU0YWNhOTNiMTNmZGViMWI6MTY0MTU2ODU0MA==


---

App should run on any windows machine from 7 upwards. You must be running Dot Net Framework 4.5 or higher however.

These files supplied by DDD are untouched/unmolested official DJI firmware files.

Come join our community!
https://dji-rev.com

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
