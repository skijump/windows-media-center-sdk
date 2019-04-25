This template is designed to help you create an installer compatible with Windows Media Center for your HTML or MCML web application. If you have any questions send an email to charlieo@microsoft.com for assistance.

Prerequisites
----------------------------------

1) Install the latest version of WiX 3.x from http://wix.sourceforge.net/releases/.
2) Download the GUIDGen tool from http://www.microsoft.com/downloads/details.aspx?familyid=94551f58-484f-4a8c-bb39-adb270833afc.

License.txt
----------------------------------

1) Modify as appropriate for your application. The contents of this file are displayed during setup when run from within Windows Media Center. It must be in plain text format.

License.rtf
----------------------------------

1) Modify as appropriate for your application. In most cases the content will match that of License.txt.

Registration.xml
----------------------------------

1) Edit as appropriate for your application. A simple version for pure web applications (HTML or MCML) is included in this template and should work for most scenarios. See the Windows Media Center SDK for more information on how to craft the XML for the registration API if you require more advanced usage.

2) Read and follow the comments included in this file to achieve the desired outcome.

3) Replace all instances of PUT_GUID_X_HERE with a GUID including curly braces. For example: {########-####-####-####-############}

4) Application Title and Description are NOT displayed in the Media Center user interface but are required. Entrypoint Title and Description ARE displayed in the Windows Media Center user interface and are also required. You can use identical values for these attributes.

Setup.wxs
----------------------------------

1) Replace all instances of PUT_GUID_X_HERE with a unique GUID WITHOUT the curly braces. For example: ########-####-####-####-############

	A) Line 14
	B) Line 15
	C) Line 97

2) Edit as appropriate to reflect the company name:

	A) Line 79

3) Edit as appropriate to reflect the locale:

	A) Line 81

3) Edit as appropriate to reflect the application name:

	B) Line 83

4) This template is designed to make the installer work for Windows Vista and later versions (including Windows 7).

   To restrict to Windows 7 and later versions change line 187 and 242 to use VersionNT >= 601.
                     
Setup-en-us.wxl
----------------------------------

1) Edit as appropriate. These values govern what appears when the installer is run outside of Windows Media Center.
2) If you are building an installer for multiple cultures you will need to have unique .wxl files: Setup-de-de.wxl, Setup-en-uk.wxl, etc.

Build the MSI
----------------------------------

1) Launch a command prompt with Administrator privileges.
2) Navigate to the folder containing this template with your edits.
3) Run Build.bat.

Test the MSI
----------------------------------
1) Run Setup-en-us.msi (or the appropriate culture version).