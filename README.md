# Dock-Companion
<img src="https://github.com/tronfacex/Dock-Companion/blob/master/DC-Logo-Text.png" width="25%" ALIGN="left"></img>
<strong>Background</strong></br>
Dock Companion is a small Windows console application I built using two blocks of code from StackOverflow and a conversation with <a href="https://openai.com/blog/chatgpt/"> OpenAI's ChatGPT</a>.

The StackOverflow threads that form the starting point of this project can be found [in the ATTRIBUTIONS file.](ATTRIBUTIONS.md)

The full transcript of my conversation with ChatGPT can be found [here.](https://github.com/tronfacex/Dock-Companion/blob/20cf476de8181917586f40c372f660c0f5a8f16b/ChatGPT%20Transcript%201-24-22.pdf)

This project is published with a GNU General Public License v3.0.

<strong>Summary</strong></br>
Dock Companion is a C# console application that checks if a target application is already running, and if it finds an open window (including minimized) of the target application it shows the window. If the target application is determined to not be running it launches a new window of the target application. 

This application was made for use alongside the <a href="https://www.rainmeter.net/">Rainmeter</a> skin <a href="https://visualskins.com/skin/circle-launcher">Circle Launcher</a>. Using it with Circle Launcher basically adds taskbar-style functionality to applications. Instructions for initial setup including how to use it with Circle Launcher below.

<strong>Initial Setup</strong></br>
1. Download latest release .zip file.
2. Ensure that you have .Net Framework 4.8 runtime installed - <a href="https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net48-web-installer">Click here to download official Microsoft installer</a>.
3. Unzip the zip file in your preferred file location on your machine.
4. Run DockCompanion.exe.
5. On initial launch the application will open a window that helps you create a Config.txt file. 
6. Click the "Browse..." button and navigate to the target application's exe file and click "OK". For instance, Mozilla Firefox usually has a default filepath of <strong>C:\Program Files\Mozilla Firefox\firefox.exe</strong>.
7. Click "Save".

<strong>How To Use Alongside Circle Launcher</strong></br>
1. Navigate to Circle Launcher's Variables.inc file. The default location is Rainmeter\Skins\Circle Launcher\@Resources\Variables.inc.
2. Find the reference to the application you would like to use Dock Companion with, and replace the filepath for the target application .exe with the filepath for DockCompanion.exe. For Instance, the Mozilla Firefox reference should read <strong>MozillaFirefox=["C:Path\To\DockCompanion.exe"]</strong>
3. Save and close Variables.inc.
4. Load or refresh the Circle Launcher skin for the application in Rainmeter by right-clicking the skin and selecting Refresh Skin.

<strong>If you would like to setup a second application for use with DockCompanion:</strong>
1. Create a second instance of the Dock Companion application by copy and pasting the entire Dock Companion folder.
2. Delete Config.txt and go through initial setup by opening DockCompanion.exe. <strong>Each instance of Dock Companion requires a Config.txt file to exist in the same folder as DockCompanion.exe</strong>. Alternatively, you can edit the txt file directly. Line 1 should be the target application process name and line 2 should be the filepath to the target application's exe file. 
3. Set the reference to DockCompanion.exe in Circle Launcher's Variables.inc file.
4. Load or refresh the Circle Launcher skin for the application in Rainmeter.

<strong>Debugging tool</strong></br>
Dock Companion makes an educated guess what an application's Process Name will be based on the programs exe filename. There are some cases where the Process Name does not match the exe filename. 

In those cases Dock Companion will fail to find open windows of the target application. You can solve this by using the Debug tool to find the true Process Name for a given window and to override the original Config.txt file. Follow these instructions to Debug the Config.txt:
1. Navigate to the Dock Companion folder and open DockCompanionConfigSetup.exe.
2. Click "Debug" at the bottom of the window. The debug window will open.
3. Open an instance of the target application.
4. Return to the debug window and click "Find Windows".
5. Look through the list of open windows and double click the entry for the target application. This will add the true Process Name to the Process Name field.
6. Click "Browse..." and navigate to the target application exe file.
7. Click "Save"
