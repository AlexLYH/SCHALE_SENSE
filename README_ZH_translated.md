```markdown
# SCHALE.GameServer

**This document is based on [https://github.com/rafi1212122/SCHALE.GameServer](https://github.com/rafi1212122/SCHALE.GameServer) and personal operational experience. Please download the resource configuration file from the link above. If you have any questions, please inquire on the Discord community.**

## Installation Preparation Stage

### 1. Install [SQL Server Express 2022](https://go.microsoft.com/fwlink/p/?linkid=2216019&clcid=0x804&culture=zh-cn&country=cn)
  * Open the downloaded installation program.
  * Select "Basic".
  * Choose your preferred installation path.
  * Begin the installation.

### 2. Install [SSMS(SQL Server Management Studio 20)](https://aka.ms/ssmsfullsetup)
  * Use the default path.
  * Install.

### 3. Install [Microsoft Visual Studio 2022](https://visualstudio.microsoft.com/zh-hans/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false)
  * Install the Community version.
  * Select all components with C# and "Visual Studio Extension Development" workloads.
  * Install with default path.

### 4. Install [LDPlayer 9](https://lddl01.ldmnq.com/downloader/ldplayerinst9.exe?n=ldplayer9_ld_999_ld.exe)

### 5. Install [Python](https://www.python.org/ftp/python/3.12.3/python-3.12.3-amd64.exe)
  * Choose custom installation, all other options default.
  * Choose installation path.
  * Install and wait for completion.

### 6. Install Frida
  * Press win+R to open Run, type cmd.
  * Type `pip install frida` in cmd and press Enter.
  * Wait for download and installation to complete.
  * Type `pip install frida-tools` and press Enter.
  * Wait for download and installation to complete (may take some time).

### 7. Push Frida-server to the emulator
  * Download [frida-server-16.x.x-android-x86_64.xz](https://github.com/frida/frida/releases/download/16.3.1/frida-server-16.3.1-android-x86_64.xz) and extract it.
  * Place frida-server-16.x.x-android-x86_64 in the `\leidian\LDPlayer9` directory.
  * Open the emulator and enable ADB debugging and ROOT permissions in settings.
  * Open cmd in the navigation bar under the `\leidian\LDPlayer9` directory.
  * Type `adb push frida-server-16.x.x-android-x86_64 /data/local/tmp` and press Enter.
  * Wait for the transfer to complete.

## Resource Configuration Stage
  * Open and extract the downloaded SCHALE.GameServer-master.zip.
  * Open SCHALE.GameServer.sln in Microsoft Visual Studio 2022.
  * Select "Terminal" from the top menu bar "View" dropdown.
  * If in `...\SCHALE.GameServer-master>`, type `cd SCHALE.GameServer` to navigate to the following path.
  * Enter the following in `\SCHALE.GameServer-master\SCHALE.GameServer`:
    `dotnet publish -a x64 --use-current-runtime --self-contained false -p:InvariantGlobalization=false`.
  * ~~Find and create a Resources folder under `\SCHALE.GameServer-master\SCHALE.GameServer\bin\Release\net8.0\win-x64`, then create an excel folder under it, and unzip Excel.zip into this folder~~ (this step is now integrated into `SCHALE.GameServer.exe`).
  * Open SSMS, connect by default (remember to check Trust Server Certificate).
  * Run `\SCHALE.GameServer-master\SCHALE.GameServer\bin\Release\net8.0\win-x64\SCHALE.GameServer.exe` (suspended in the background) (allow through firewall for the first run).
  * Find ba.js, open it with Notepad, and modify the 5th line `REPLACE THIS WITH YOUR LOCAL IP` to your current IPV4 address (viewable in Network and Internet settings).

## Game Startup Stage
  *It is recommended to place ba.js in the \leidian\LDPlayer9 directory.*
    
  **The following operations must be performed each time you start!**
  * Open LDPlayer.
  * Start Frida.
      * Open cmd in the navigation bar under (the drive where you installed)\leidian\LDPlayer9.
      * Type the following in the cmd that opens:
        ```
        adb shell
        su    //Superuser
        cd /data/local/tmp    //Navigate to this directory
        chmod 755 frida-server-16.x.x-android-x86_64
        ./frida-server-16.x.x-android-x86_64    //Start Frida
        ```
    **!!! After completing this step, do not close the cmd !!!**  
  
  * (PC) Open a cmd with the same path again.
  * (Emulator) Start the game ブルアカ.
  * When the Yostar logo appears, type and press Enter:
    `frida -U "ブルアカ" -l ba.js --realm=emulated` (suspended in the background).
  * When `Attatching...` appears and SCHALE.GameServer.exe shows Ping, it is basically successful.
   
  **###Before entering the private server, you need to first connect to the official server to download resources and go through the beginner's tutorial###**
  
  **###If an error occurs when setting the name and voice file for the first login, restart SCHALE.GameServer.exe, close the game, and start again from the "Start Game ブルアカ" step###**

## Notes
- This project is still in its early stages, and there are many options that cannot be used yet. If you encounter any issues, try logging in again or restarting.
- If SCHALE.GameServer.exe fails to Ping, please check if the IPV4 address in ba.js matches your current address.
- If you have successfully installed SQL Server Express, please refrain from attempting to uninstall or delete it on your own, as it may prevent successful installation in the future.
- If, unfortunately, you have encountered multiple failures in installing SQL Server Express on your computer and are unwilling to reinstall the system, here is an alternative solution:
    - Requires a high-performance computer and sufficient hard disk storage.
    - Install VMware Workstation Pro.
    - Fill in the license key obtained from a network search.
    - Obtain a Windows 10/11 image from the official Windows website or other legitimate channels.
    - Create and install a Windows virtual machine.
      Refer to the tutorial on installing Windows 10 in VMware on the CSDN blog.
    - After creating the virtual machine, you need to set:
      - On your computer: Settings -> System -> Display -> Graphics card -> Default graphics settings, enable "Hardware-accelerated GPU scheduling".
      - (Virtual machine settings): Processor: Check virtualization Intel VT-x/EPT or AMD-V/RVI(V).
      - (Virtual machine settings): Display: Check "Accelerate 3D graphics", select "Specify monitor settings", set the number of monitors to 1, and set the graphics memory to half of the given memory.
    - Start the virtual machine.
    - Activate Windows using KMS.
    - After completion, you can proceed with the installation.
      See [VMware Installation Guide for Win10 in VMware_VMware Installation Guide for Win10-CSDN Blog](https://blog.csdn.net/lvlheike/article/details/120398259).
    * After creating the virtual machine, you need to set:
