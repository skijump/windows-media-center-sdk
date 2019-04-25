Copyright Microsoft Corporation

Welcome to PowerPlaylist 2
------------------------------------------------------------------
PowerPlaylist 2 adds a custom Start Menu strip to Windows Media Center with five tiles. Each tile represents an audio, slideshow or visualization combination which will start when the tile is selected.

To modify PowerPlaylist 2 settings
------------------------------------------------------------------
Use the PowerPlaylist 2 Editor in the Windows Start Menu to make changes, including the title of the Start Menu strip and the name, image, audio source, slideshow folder and visualization for each tile. Read on for information on how to manually edit these settings using the XML and registry keys directly. Images used for the tiles should conform to the specifications outlined in the Windows Media Center SDK.

To manually change the PowerPlaylist 2 Start Menu strip title
------------------------------------------------------------------
Edit the 'Title' registry key at...

	HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center\Start Menu\Applications\{94761d39-3aaf-4c54-a2d3-cbda27d2229c}

To manually change the title and image for each PowerPlaylist 2 tile
------------------------------------------------------------------
Here is the list of registry keys to modify; Change 'Title', 'ImageURL' or 'InactiveImageUrl' for each of those as you so desire. These are listed in the order in which they appear in Windows Media Center.

	HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{dfd75e76-7530-4d0d-a126-71863200a556}
	HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{b9b49dbf-fb85-4a80-beb7-5732c4ba849e}
	HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{4a03b055-eea0-466f-b4fd-ae72d41fdb02}
	HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{f8216194-c5c8-4fc8-98b8-b33ef15b36aa}
	HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Entry Points\{9580a0b8-f06f-4422-94d2-4aae0a26b3b3}

To manually hide any given tile
------------------------------------------------------------------
Change the AppID for the registry keys shown in the 'To manually change the title and image for each PowerPlaylist 2 tile' section to anything other than a GUID. To show the tile set AppID to {94761d39-3aaf-4c54-a2d3-cbda27d2229c}.

To manually change the audio, slideshow and visualizations for each PowerPlaylist 2 tile
------------------------------------------------------------------
1) Launch Notepad with Administrator privileges.

2) Open c:\programdata\Microsoft\PowerPlaylist2\Data\Data.xml

	Note: This folder path is hidden from Explorer so you will need to manually type the path.

3) Each PowerPlaylist tile is represented in the XML which is similar to the following:

	<Table>
		<ID>1</ID>
		<Audio>C:\Users\Public\Music\Playlists\PowerPlaylist1.wpl</Audio>
		<SlideshowFolder>C:\Users\Public\Pictures\Sample Pictures</SlideshowFolder>
		<Visualization></Visualization>
		<HideTile>false</HideTile>
	</Table>

4) You can modify the Audio, SlideshowFolder and Visualization values as you wish.

	Audio can take a pointer to any audio playable in Windows Media Center -- a single WMA / MP3, playlist from Windows Media Player (Zune playlists aka *.zpl don't work) or an internet radio URL (like Radio Paradise at http://www.changeip.com/radio/rp.asx) should all work fine. If you set this to an empty string, only the slideshow will play.
	SlideshowFolder can take a folder path. If you want it to work on Extenders it needs to be in one of the default locations (like \Users\Public\Pictures\*) or a folder you have added via the Library settings. If you set this to an empty string only the audio will play.
	Visualization can take a Visualization name and preset, separated by a colon. For example: Alchemy:Random. You can also specify just the name or preset -- refer to the SDK NavigateToPage reference for how this is handled.
	DisableTile can be true or false. This value is only used by the PowerPlaylist 2 Editor and does not influence the behavior of PowerPlaylist 2 at runtime. You can manually hide / show tiles using the instructions above.
	
	Note: If SlideshowFolder and Visualization both have values, the SlideshowFolder will be the winner.

5) Whatever you do, don't change <ID> -- that will most certainly break PowerPlaylist 2.

Release Notes / Known Issues
------------------------------------------------------------------
• The setup adds five playlists named PowerPlaylistX.wpl where X is a sequential number to C:\Users\Public\Music\PowerPlaylist\ which you can modify in Windows Media Player. If you already have those playlists in that location I'm pretty sure they will be overwritten. They will also be deleted when you uninstall. If you want to preserve your playlists, create new ones with unique names and modify data.xml as outlined above.
• Known Issue: Visualizations don't work on Media Center Extender. As a result, you will get a black screen if you have specified a visualization.
• Known Issue: Skip / Replay / Queue features don't work on Media Center Extender when you use a playlist (examples: *.ASX, *.WPL).