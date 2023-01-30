# Dock-Companion

<img src="https://github.com/tronfacex/Dock-Companion/blob/master/DC-Logo-Text.png" width="27%" ALIGN="left"></img>

<h2 id="about">About</h2>
Dock Companion is a C# console application that checks if a target application is already running, and if it finds an open window (including minimized) it shows the window. If the target application is determined to not be running it launches a new window.</br></br>

This application was made for use alongside popular <a href="https://www.rainmeter.net/">Rainmeter</a> Docks. Using it alongside Rainmeter docks like <a href="https://visualskins.com/skin/silmeria-dock">Silmeria Dock</a>, <a href="https://visualskins.com/skin/docker">Docker</a> and <a href="https://visualskins.com/skin/circle-launcher">Circle Launcher</a> basically adds taskbar-style functionality to the targeted applications. 

For example, when targeted at Chrome or Firefox those application will find and surface any already open windows instead of opening a brand new window each time they are clicked. 

Using Dock Companion with Firefox on Silmeria Dock:

![Silmeria After GIF](Silmeria-After.gif)

<strong>Instructions for initial setup including how to use it with the most <a href="https://visualskins.com/rainmeter-docks">popular Rainmeter docks</a> are below.</strong>

This project is published with a GNU General Public License v3.0.

<h2 id="table-of-contents">Table of Contents</h2>
<ul>
    <li><a href="#initial-setup">Initial Setup</a></li>
    <li><a href="#how-to-use-alongside-silmeria">How to Use With Rainmeter Silmeria Dock</a></li>
    <li><a href="#how-to-use-alongside-circle-launcher">How to Use With Rainmeter Circle Launcher</a></li>
    <li><a href="#how-to-use-alongside-docker">How to Use with Rainmeter Docker</a></li>
    <li><a href="#debugging-issues">Debugging Issues</a></li>
    <li><a href="footnotes">Notes</a></li>
</ul>

<h2 id="initial-setup">Initial Setup</h2>
<ol>
    <li>Download latest release .zip file.</li>
    <li>Ensure that you have .Net Framework 4.8 runtime installed. <a href="https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net48-web-installer"> Click here to download official Microsoft installer</a>.</li>
    <li>Unzip the zip file in your preferred file location on your machine.</li>
    <li>Run DockCompanion.exe.</li>
    <li>On initial launch the application will open a window that helps you create a Config.txt file.</li>
    <li>Click the "Browse..." button and navigate to the target application's exe file and click "OK". For instance, Mozilla Firefox usually has a default filepath of <strong>C:\Program Files\Mozilla Firefox\firefox.exe</strong>.</li>
    <li>Click "Save".</li>
    <li>Now use this instance of DockCompanion.exe to launch the target application instead of the target application .exe file.</li>
</ol>

<h2 id="how-to-use-alongside-silmeria">How to Use Alongside Silmeria Dock</h2>
<ol>
  <li>Navigate to Silmeria Dock's Settings.ini file. The default location is Rainmeter\Skins\Silmeria Dock\@Resources\Settings.ini.</li>
  <li>Find the reference to the application you would like to use Dock Companion with, find the field "Icon1Action", and replace the filepath for the target application .exe with the filepath for DockCompanion.exe. For Instance, the Mozilla Firefox reference should read <strong>Icon1Action=["C:Path\To\DockCompanion.exe"]</strong></li>
  <li>Save and close Settings.ini.</li>
  <li>Load or refresh the Silmeria Dock skin for the application in Rainmeter by right-clicking the skin and selecting Refresh Skin.</li>
</ol>

<strong>If you would like to setup a second application for use with DockCompanion:</strong>
<ol>
  <li>Create a second instance of the Dock Companion application by copy and pasting the entire Dock Companion folder.</li>
  <li>Delete Config.txt and go through initial setup by opening DockCompanion.exe. <strong>Each instance of Dock Companion requires a Config.txt file to exist in the same folder as DockCompanion.exe</strong>
    <ol type="2a">
        <li>Alternatively, you can edit the txt file directly. Line 1 should be the target application process name, and line 2 should be the filepath to the target application's exe file.</li>
    </ol>
  <li>Set the reference to DockCompanion.exe in Silmeria Dock's Settings.ini file.</li>
  <li>Load or refresh the Silmeria Dock skin for the application in Rainmeter.</li>
</ol>

<h2 id="how-to-use-alongside-circle-launcher">How To Use Alongside Circle Launcher</h2>
<ol>
  <li>Navigate to Circle Launcher's Variables.inc file. The default location is Rainmeter\Skins\Circle Launcher\@Resources\Variables.inc.</li>
  <li>Find the reference to the application you would like to use Dock Companion with, and replace the filepath for the target application .exe with the filepath for DockCompanion.exe. For Instance, the Mozilla Firefox reference should read <strong>MozillaFirefox=["C:Path\To\DockCompanion.exe"]</strong></li>
  <li>Save and close Variables.inc.</li>
  <li>Load or refresh the Circle Launcher skin for the application in Rainmeter by right-clicking the skin and selecting Refresh Skin.</li>
</ol>


<strong>If you would like to setup a second application for use with DockCompanion:</strong>
<ol>
  <li>Create a second instance of the Dock Companion application by copy and pasting the entire Dock Companion folder.</li>
  <li>Delete Config.txt and go through initial setup by opening DockCompanion.exe. <strong>Each instance of Dock Companion requires a Config.txt file to exist in the same folder as DockCompanion.exe</strong>
    <ol type="2a">
        <li>Alternatively, you can edit the txt file directly. Line 1 should be the target application process name, and line 2 should be the filepath to the target application's exe file.</li>
    </ol>
  <li>Set the reference to DockCompanion.exe in Circle Launcher's Variables.inc file.</li>
  <li>Load or refresh the Circle Launcher skin for the application in Rainmeter.</li>
</ol>

<h2 id="how-to-use-alongside-docker">How to Use Alongside Docker</h2>
<ol>
  <li>Navigate to Docker's Settings.ini file. The default location is Rainmeter\Skins\Docker\@Resources\Basic.ini for the Basic Dock and Rainmeter\Skins\Docker\@Resources\Advanced.ini for the Advanced Dock.</li>
  <li>Find the reference to the application you would like to use Dock Companion with, find the field "LeftMouseUpAction", and replace the filepath for the target application .exe with the filepath for DockCompanion.exe. For Instance, the Mozilla Firefox reference should read <strong>LeftMouseUpAction=["C:Path\To\DockCompanion.exe"]</strong></li>
  <li>Save and close Settings.inc.</li>
  <li>Load or refresh the Silmeria Dock skin for the application in Rainmeter by right-clicking the skin and selecting Refresh Skin.</li>
</ol>

<strong>If you would like to setup a second application for use with DockCompanion:</strong>
<ol>
  <li>Create a second instance of the Dock Companion application by copy and pasting the entire Dock Companion folder.</li>
  <li>Delete Config.txt and go through initial setup by opening DockCompanion.exe. <strong>Each instance of Dock Companion requires a Config.txt file to exist in the same folder as DockCompanion.exe</strong>
    <ol type="2a">
        <li>Alternatively, you can edit the txt file directly. Line 1 should be the target application process name, and line 2 should be the filepath to the target application's exe file.</li>
    </ol>
  <li>Set the reference to DockCompanion.exe in Docker's Basic.ini/Advanced.ini file.</li>
  <li>Load or refresh the Docker skin for the application in Rainmeter.</li>
</ol>

<h2 id="debugging-issues">Debugging Issues</h2>
<p>There are two primary reasons why Dock Companion fails: a <strong>mismatched Process Name</strong> or an <strong>invalid filepath in the Config.txt file</strong>. Both issues can be solved using the Debug tool.</p>

<p><strong>Mismatched Process Name</strong>

Dock Companion assumes an application's Process Name based on the program's exe filename. There are some cases where the Process Name does not match the exe filename. In those cases Dock Companion will fail to find open windows of the target application. Solve this issue by using the Debug tool to find the true Process Name for a given window and override the original Config.txt file.

Follow these instructions to Debug the Config.txt:
<ol>
  <li>Navigate to the Dock Companion folder and open DockCompanionConfigSetup.exe.</li>
  <li>Click "Debug" at the bottom of the window. The debug window will open.</li>
  <li>Open an instance of the target application.</li>
  <li>Return to the debug window and click "Find Windows".</li>
  <li>Look through the list of open windows and double click the entry for the target application. This will add the true Process Name to the Process Name field.</li>
  <li>Click "Browse..." and navigate to the target application exe file.</li>
  <li>Click "Save"</li>
</ol></p>


<p><strong>Invalid Target Application Filepath</strong>

If no target application windows are launched when DockCompanion.exe is run without any open windows it indicates that the target application filepath doesn't exist. <strong>Delete Config.txt and run the initial setup again.</strong>

Alternatively, open Config.txt and examine the filepath on line 2 to ensure it is a valid.

The Debug Tool can also be used to reset the filepath and set an alternative Process Name. 

Follow these instructions to Debug the Config.txt via the Debug Tool:
<ol>
  <li>Navigate to the Dock Companion folder and open DockCompanionConfigSetup.exe.</li>
  <li>Click "Debug" at the bottom of the window. The debug window will open.</li>
  <li>Open an instance of the target application.</li>
  <li>Return to the debug window and click "Find Windows".</li>
  <li>Look through the list of open windows and double click the entry for the target application. This will add the true Process Name to the Process Name field.</li>
  <li>Click "Browse..." and navigate to the target application exe file.</li>
  <li>Click "Save"</li>
</ol></p>

<h2 id="footnote">Notes</h2>
<p>Dock Companion was created by adapting two blocks of code found on StackOverflow, and a conversation with <a href="https://openai.com/"> OpenAI's ChatGPT</a>.</p>

The StackOverflow threads that form the starting point of this project can be found in the [ATTRIBUTIONS file.](ATTRIBUTIONS.md)

The full transcript of my conversation with ChatGPT can be found [here.](ChatGPT-Transcript-1-26-22.pdf)

This project is published with a GNU General Public License v3.0.
