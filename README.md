# Mp3Org

A simple datagrid-based mp3 tag editor. Great for editing messy tags. The objective of this app is to edit only the critical song tags, while cleaning all other less important tags. The relevant tags are shown in the screenshot below.

![Screen](/Screens/Mp3Org_screen.png?raw=true "Screen")
![GIF](/Screens/album-art.gif?raw=true "GIF")

## Features
 - Loads all mp3s in a selected directory into an editable table
 - Edits can be performed in the datagrid or in the fields below
 - Tags are saved after a cell or field is changed.
 - Automated cover search via Google Images for all mp3s displayed
 - Drag and drop covers from the Google Image search.
 - Rename file names with respect to the selected option
 
 ## Sample use
 1. Put several mp3 files in a directory.
 1. Open the app, select the folder, and load in the files
    - This cleans the superfluous tag field that may exist
    - This also tries to figure out the title and artist if the file is named simlarly to "Artist - Title.mp3"
 1. Edit the tags using the grid or the fields below
 1. Click "Search Covers", which opens up your default browser and performs a Google image search for each cover (separate tabs)
 1. Save the cover to the mp3 by draggng and dropping the image from the browser on the song's datagrid row (works for most images, however this does not work for some sites, such as beatport.
 1. Click "Run" to rename all tags to the selected naming convention.
 1. Add files to YouTubeMusic or other cloud service

## Latest Release
Get latest release as a portable Windows 10 application [here](https://github.com/chris-hendrix/mp3-org/releases).


 
 ## TagLib#
 This app would not be possible without the development of [TagLib#](https://github.com/mono/taglib-sharp).
