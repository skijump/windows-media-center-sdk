# Windows Media Center SDK for Windows 7

The official Windows Media Center SDK for Windows 7 documentation is on the Microsoft site [here](https://docs.microsoft.com/en-us/previous-versions/windows/desktop/windows-media-center-sdk/).

Preserving a bit of history for the diaspora that created Windows Media Center (the 'eHome' team at Microsoft) and the fans that still use since the actual installer has gone missing from the original download link.

Learn more about the feature and history over on [Wikipedia](https://en.wikipedia.org/wiki/Windows_Media_Center).

## Contents

* `/addendum/` - The original readme for the files in this separate download from the SDK can be found [here](addendum/Readme.txt). Almost everything here is a duplicate of what can be found elsewhere, with minor tweaks mostly in paths.
  * A couple of new and updated loose MCML samples (mostly to fix up the URLs to the defunct play.mediacentersandbox.com).
  * Source code for the Sample Explorer application you find in the Extras Library after installing the SDK as well as the desktop browsing tool. This is a good example of one approach for creating a testing / automation framework for your own application.
  * Source code for Animation Explorer and Preview Tool Launcher desktop tools. The Preview Tool actually has a pretty robust automation model itself and this source shows you how to take full advantage for your own authoring tools.
  * Templates and source code for the Visual Studio 2008 templates included with the SDK. Follow the instructions in Readme.txt for use with Visual Studio 2010.
  * Web Application Installer Template used to create the installers for the above applets. They are fully compatible with the InstallApplication Method in Windows 7 and can be used to craft installers for http://madeformediacenter.com/m4mc/.
* `/bin/` - Compiled SDK executables which _should_ run on Windows 7. As the original installer took care of the heavy lifting there is a little bit of work here to manually register some of the tools within Windows Media Center.
* `/docs/` - Currently working on porting the source (in a proprietary Word format) to Markdown. Originals are in `/docs/source/`. Also included are a few blog posts from 'back in the day' which were relevant.
* `/samples/` - Lots and lots of samples -- mostly in Media Center Markup Language which is simply XML. A few of these (`/EyeCandySource`, `/EyeCandySourceWeb`, `/RandMCML`, `PowerPlaylist`) weren't in the SDK -- these are from a personal collection.
* `/templates/` - Various and sundry Visual Studio templates which bootstrapped development. We tended to focus our efforts in enabling Visual Studio C# Express 2008 which you can download from [https://go.microsoft.com/?linkid=7729278](https://go.microsoft.com/?linkid=7729278).
* `/tools/` - Source code for many of the things you find in the `/bin/` folder. A few of them (most notably `MCMLPad.exe`) don't have source code. These were built in the main product and the source isn't publicly available.

Enjoy...!

> The organization name **Skijump** is in reference to an all volunteer  home theater PC (HTPC) enthusiast group of approximately 150 people which formed at Microsoft in 2002 to internally and externally evangelize this new feature of Windows.
