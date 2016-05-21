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

# Legal Notices

def printGNU(name):
    # Print the GNU GPL
    print(name + """  Copyright (C) 2016 Damian Heaton
This program comes with ABSOLUTELY NO WARRANTY; type 'show w'.
This is free software, and you are welcome to redistribute it
under certain conditions; type 'show c'.
http://gnu.org/licenses/gpl.html for details.
Otherwise, press enter (or any other command) to run.""")

    i = 1
    while i == 1:
        cmd = input("> ").lower()
        if cmd == "show w":
            print("""
    15. Disclaimer of Warranty.

    THERE IS NO WARRANTY FOR THE PROGRAM, TO THE EXTENT PERMITTED BY APPLICABLE
    LAW. EXCEPT WHEN OTHERWISE STATED IN WRITING THE COPYRIGHT HOLDERS AND/OR
    OTHER PARTIES PROVIDE THE PROGRAM "AS IS" WITHOUT WARRANTY OF ANY KIND,
    EITHER EXPRESSED OR IMPLIED, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
    WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE. THE
    ENTIRE RISK AS TO THE QUALITY AND PERFORMANCE OF THE PROGRAM IS WITH YOU.
    SHOULD THE PROGRAM PROVE DEFECTIVE, YOU ASSUME THE COST OF ALL NECESSARY
    SERVICING, REPAIR OR CORRECTION.
    """)
        elif cmd == "show c":
            print("""
    2. Basic Permissions.

    All rights granted under this License are granted for the term of copyright
    on the Program, and are irrevocable provided the stated conditions are met.
    This License explicitly affirms your unlimited permission to run the
    unmodified Program. The output from running a covered work is covered by
    this License only if the output, given its content, constitutes a covered
    work. This License acknowledges your rights of fair use or other equivalent,
    as provided by copyright law. You may make, run and propagate covered works
    that you do not convey, without conditions so long as your license otherwise
    remains in force. You may convey covered works to others for the sole purpose
    of having them make modifications exclusively for you, or provide you with
    facilities for running those works, provided that you comply with the terms
    of this License in conveying all material for which you do not control
    copyright. Those thus making or running the covered works for you must do
    so exclusively on your behalf, under your direction and control, on terms
    that prohibit them from making any copies of your copyrighted material outside
    their relationship with you. Conveying under any other circumstances is
    permitted solely under the conditions stated below. Sublicensing is not
    allowed; section 10 makes it unnecessary.
    """)
        elif cmd == "show":
            print("show c for conditions, show w for warranty")
        else:
            i = 0
            print("Running program.")
