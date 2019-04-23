# Windows Media Center SDK for Windows 7

Preserving a bit of history for the diaspora that created Windows Media Center (the 'eHome' team at Microsoft) since the actual installer has gone missing from the original download link.

Learn more about the feature and history over on [Wikipedia](https://en.wikipedia.org/wiki/Windows_Media_Center).

## Contents

* `/addendum/` - The original readme for the files in this separate download from the installer can be found [here](addendum/Readme.txt). Almost everything here is a duplicate of what can be found elsewhere, with minor tweaks mostly in paths.
* `/bin/` - Compiled executables which _should_ run on Windows 7. As the original installer took care of the heavy lifting there is a little bit of work here to manually register some of the tools within Windows Media Center.
* `/docs/` - Currently working on porting the source (in a proprietary Word format) to Markdown. Originals are in `/docs/source/`.
* `/samples/` - Lots and lots of samples -- mostly in Media Center Markup Language which is simply XML. A few of these (`/EyeCandySource`, `/EyeCandySourceWeb`, `/RandMCML`) weren't in the SDK -- these are from @retrosight personal collection.
* `/templates/` - Various and sundry Visual Studio templates which bootstrapped development. We tended to focus our efforts in enabling Visual Studio C# Express 2008.
* `/tools/` - Source code for many of the things you find in the `/bin/` folder. A few of them (most notably, MCMLPad.exe) don't have source code. These were built in the main product and the source isn't publicly available.

Enjoy...!
