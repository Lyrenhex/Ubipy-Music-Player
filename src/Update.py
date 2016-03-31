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

# Update Verification System

import urllib.request

def update(name, log, verid, namurl=None):
    if namurl is None:
        namurl = name.lower()
        if " " in namurl:
            namurl = namurl.split(" ")[0]
    log.debug("Verifying that " + name + " is its latest version...")
    log.debug("Current version is: " + verid)
    newver = str(urllib.request.urlopen("http://damianheaton.com/archives/" + namurl + "/key/version.txt").read()).split("'")[1]
    if verid != newver:
        log.warn("""A new update (""" + newver + """) is now available. It should be
    downloaded as soon as possible from http://damianheaton.com/archives/""" + namurl + """/dl .""")
        # make some noise about it
        if easygui.ynbox("""A new version (""" + newver + """) is now available.
    Would you like to go and download this update now?""",
                            name + " Update Available"):
            if not webbrowser.open("http://damianheaton.com/archives/" + namurl + "/dl", 2):
                easygui.msgbox("""Unable to open the download web page. Please visit
    damianheaton.com/archives/""" + namurl + """/dl in order to update.""",
                               name + " Update Launch Failed")
