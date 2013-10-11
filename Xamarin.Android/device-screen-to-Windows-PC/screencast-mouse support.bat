@ echo off
set ADB="%PROGRAMFILES%"\Android\android-sdk\platform-tools\adb.exe

%ADB% devices

pause

%ADB% shell

:: su
:: chmod 777 /data/dalvik-cache
:: cd /data/dalvik-cache
:: chmod 777 ./

pause