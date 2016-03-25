# Ubipy Music Player
A free (libre and gratis) cross-platform music player written in Python.

## Supported File Types
Ubipy supports the following file types:
- MP3 (audio only)
- Ogg Vorbis (.ogg, tracklength dependant features are disabled for these files.)

## Metadata
Ubipy, by default, determines track name, album, and artist from the mp3 metadata (specifically TIT2, TALB, and TPE1). More information regarding this is in the "Please read before adding music" file in the music folder.

~~There are plans to make files without required metadata use the directory tree to determine information.~~

If the track name, album, or artist is not available via the file's metadata, then Ubipy will now resort to determine each respective piece of information via the song's file path.

## Support
Support with this project is welcome, hence the GNU GPL v3 license. If you'd like to tackle an issue, submit an issue, or submit a pull request, feel free. Or just spin off entirely if you want. :)
