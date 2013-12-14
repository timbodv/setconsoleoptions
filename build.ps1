
$MSBUILD = "C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe"
& $MSBUILD SetConsoleOptions.sln /t:Clean /p:Configuration=Release
& $MSBUILD SetConsoleOptions.sln /t:Build /p:Configuration=Release

if ($(Test-Path .\output) -eq $false) { mkdir output }
& ".\packages\ilmerge.2.13.0307\ilmerge.exe" /target:exe /out:".\output\setconsoleoptions.exe" ".\bin\Release\SetConsoleOptions.exe" ".\bin\Release\CommandLine.dll"
