"""
    Ubipy Cross-Platform Free Music Player
    Copyright (C) 2016 Damian Heaton <me@damianheaton.com>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
"""

# Index Songs

import random
import os

def indexAll(baseDir="music"):
    songs = []
    shuffledSongs = []
    artists = []
    artists2 = []
    albums = []
    albums2 = []
    maxsong = -1
    ogg = False
    for folder in os.listdir(baseDir):
        if os.path.isdir(os.path.join(baseDir, folder)):
            artists.append(os.path.join(baseDir, folder))
            artists2.append(folder)
            for subfolder in os.listdir(os.path.join(baseDir, folder)):
                if os.path.isdir(os.path.join(baseDir, folder, subfolder)):
                    albums.append(os.path.join(baseDir, folder, subfolder))
                    albums2.append(subfolder + ", by " + folder)
                    for file in os.listdir(os.path.join(baseDir, folder,
                                                        subfolder)):
                        if file.endswith(".mp3") or file.endswith(".ogg"):
                            try:
                                songs.append(os.path.join(baseDir, folder,
                                                          subfolder, file))
                                shuffledSongs.append(os.path.join(baseDir, folder,
                                                          subfolder, file))
                                maxsong += 1
                            except Exception as e:
                                log.error("Exception while handling "
                                              + os.path.join(baseDir, folder,
                                                             subfolder, file)
                                              + ": " + e)
                                continue
                        if file.endswith(".ogg"):
                            ogg = True

    random.shuffle(shuffledSongs)

    return [maxsong, ogg, songs, shuffledSongs, artists, artists2, albums,
            albums2]

def indexArtist(artist, baseDir="music"):
    songs = []
    shuffledSongs = []
    maxsong = -1
    for subfolder in os.listdir(os.path.join(baseDir, artist)):
        if os.path.isdir(os.path.join(baseDir, artist, subfolder)):
            for file in os.listdir(os.path.join(baseDir, artist,
                                                subfolder)):
                if file.endswith(".mp3") or file.endswith(".ogg"):
                    try:
                        songs.append(os.path.join(baseDir, artist,
                                                  subfolder, file))
                        shuffledSongs.append(os.path.join(baseDir, artist,
                                                  subfolder, file))
                        maxsong += 1
                    except Exception as e:
                        log.error("Exception while handling "
                                      + os.path.join(baseDir, artist,
                                                     subfolder, file)
                                      + ": " + e)
                        continue

    random.shuffle(shuffledSongs)

    return [maxsong, songs, shuffledSongs]

def indexAlbum(artist, album, baseDir="music"):
    songs = []
    shuffledSongs = []
    maxsong = -1
    for file in os.listdir(os.path.join(baseDir, artist,
                                        album)):
        if file.endswith(".mp3") or file.endswith(".ogg"):
            try:
                songs.append(os.path.join(baseDir, artist,
                                          album, file))
                shuffledSongs.append(os.path.join(baseDir, artist,
                                          album, file))
                maxsong += 1
            except Exception as e:
                log.error("Exception while handling "
                              + os.path.join(baseDir, artist,
                                             album, file)
                              + ": " + e)
                continue

    random.shuffle(shuffledSongs)

    return [maxsong, songs, shuffledSongs]
