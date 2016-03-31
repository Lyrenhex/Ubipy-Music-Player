@echo off

set TCL_LIBRARY=C:\Program Files (x86)\Python35-32\tcl\tcl8.6
set TK_LIBRARY=C:\Program Files (x86)\Python35-32\tcl\tcl8.6
cd F:\GitHub\Ubipy-Music-Player
F:
python setup.py bdist_msi
pause