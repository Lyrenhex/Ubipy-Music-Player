# Ubipy Music Player
A free (libre and gratis) cross-platform music player written in Python.

## Supported File Types
Currently, Ubipy only supports *most* MP3 files. Some are too complex for it, however, due to Pygame's (Ubipy is based off pygame) limitations.

Planned support:
- Ogg Vorbis (.ogg)

## Metadata
Ubipy determines track name, album, and artist from the mp3 metadata (specifically TIT2, TALB, and TPE1). More information regarding this is in the "Please read before adding music" file in the music folder.

There are plans to make files without required metadata use the directory tree to determine information.

## Support
Support with this project is welcome, hence the GNU GPL v3 license. If you'd like to tackle an issue, submit an issue, or submit a pull request, feel free. Or just spin off entirely if you want. :)