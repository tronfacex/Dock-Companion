# Dock-Companion
<strong>Background</strong></br>
This is a small Windows console application I built using two blocks of code from StackOverflow and a conversation with <a href="https://openai.com/blog/chatgpt/"> OpenAI's ChatGPT</a>. It is the first C# application I've ever made that wasn't a Unity project or a tutorial.

I believe that due to my inexperience working with things like the System namespace and DLLImport using ChatGPT accelerated my development time greatly. I was able to bounce issues and ideas off the AI to debug my code and learn new things much more quickly.

This project is published with a GNU General Public License v3.0.

<strong>The StackOverflow threads & ChatGPT transcript that form the basis of this project are below:</strong>

This thread covers the method used to find all open windows and add their window title and handle to a dictionary that can be queried:</br>
https://stackoverflow.com/questions/7268302/get-the-titles-of-all-open-windows

This was used as the starting point for figuring out the SetForeGroundWindow:</br>
https://stackoverflow.com/questions/3971512/c-sharp-how-to-select-an-open-application-window

I've added a transcript of my ChatGPT conversation to the project see the file ChatGPT Transcript 1-24-23.pdf.

<strong>Summary</strong></br>
Dock Companion is a standalone launcher that checks if a specific application is already running, and if it finds an open window (including minimized) of that application it shows the window. If the application is determined to not be running it launches the application. 

This barebones application was made for use with alongside the <a href="https://www.rainmeter.net/">Rainmeter</a> skin <a href="https://visualskins.com/skin/circle-launcher">Circle Launcher</a>. Using it with Circle Launcher basically adds taskbar-style functionality to applications. See instructions for using it alongside Circle Launcher below.

<strong>Initial Setup</strong></br>
1. Download latest release .zip file.
2. Ensure that you have .Net Framework 4.8 runtime installed - <a href="https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net48-web-installer">Click here to download official Microsoft installer</a>.
3. Unzip the zip file in your preferred file location on your machine.
4. Run DockCompanion.exe.
5. Dock Companion requires a Config.txt file to be present in the root folder. On initial launch the application will open a window that helps you create a Config.txt file.
6. Next, open two windows of the application you are targeting for use Dock Companion. For instance, if you are using Dock Companion with Mozilla Firefox open <strong>two separate Firefox windows</strong>. 
7. Click "Find Windows" to get a list of all open window titles.
8. Evaluate the window titles of your target application for a unique phrase that can be used to identify the target application when Dock Companion searches the open windows. 
9. Type that unique phrase into the Text Field labelled "Search Phrase". For Instance, Mozilla Firefox windows always have a title that ends in <strong>Mozilla Firefox</strong>. 
10. Click the "Browse..." button and navigate to the target application's exe file and click "OK". For instance, Mozilla Firefox usually has a default filepath of <strong>C:\Program Files\Mozilla Firefox\firefox.exe</strong>.
11. Click "Save".

<strong>How To Use Alongside Circle Launcher</strong></br>
1. Navigate to Circle Launcher's Variables.inc file. The default location is Rainmeter\Skins\Circle Launcher\@Resources\Variables.inc.
2. Find the reference to the application you would like to use Dock Companion with and replace the filepath for the target application .exe with the filepath for DockCompanion.exe. For Instance, the Mozilla Firefox reference should read <strong>MozillaFirefox=["C:Path\To\DockCompanion.exe"]</strong>
3. Save and close Variables.inc.
4. Load or refresh the Circle Launcher skin for the application in Rainmeter by right-clicking the skin and selecting Refresh Skin.

<strong>If you would like to setup a second application for use with DockCompanion:</strong>
1. Create a second instance of the Dock Companion application by copy and pasting the entire Dock Companion folder.
2. Edit the Config.txt file in the new instance of Dock Companion to your desired values or delete Config.txt and go through initial setup by opening DockCompanion.exe. <strong>Each instance of Dock Companion requires a Config.txt file to exist in the same folder as DockCompanion.exe</strong>.
3. Set the reference to DockCompanion.exe in Circle Launcher's Variables.inc file.
4. Load or refresh the Circle Launcher skin for the application in Rainmeter.
