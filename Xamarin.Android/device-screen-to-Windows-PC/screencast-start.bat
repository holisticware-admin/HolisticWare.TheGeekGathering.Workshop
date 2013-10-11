@ echo off
set ADB="%PROGRAMFILES%"\Android\android-sdk\platform-tools\adb.exe

%ADB% devices


:: The .jnlp itself doesn't includes the code, it downloads jar files
:: androidscreencast.jar and ddmlib.jar 
:: from http://androidscreencast.googlecode.com/svn/trunk/AndroidScreencast/dist/

:: java setting window.
:: And this window can setting proxy server and port number.
:: javaws -viewer
:: It seems your java needs proxy, etc.. run 


:: Or download both jar files manually and run
javaws -codebase file:///./ androidscreencast.jnlp 

::javaws androidscreencast.jnlp
 
pause