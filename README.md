# About
I was after some different colours to what was available through the Windows command and PowerShell prompts (in particular the solarized colour scheme). This small utility allows you to change the RGB values of the built-in colours.

## Pre-requisites
Created with Visual Studio 2013 Express, compiled with .Net 3.5, and using CommandLineParser and ILMerge nuget packages. I use StyleCop to help me keep my coding style consistent, but it can be turned off by removing the line `<Import Project="$(ProgramFiles)\MSBuild\StyleCop\v4.7\StyleCop.targets" />` from `SetConsoleOptions.csproj`.

## Compiling
After extracting the code, download the required nuget packages using a command similar to `Update-Package -Reinstall` and then run `build.ps1` to generate a release exectuable.

## Acknowledgements
Thanks to Alex Shvedov and MercuryP for submitting the code to [http://pinvoke.net/default.aspx/kernel32.SetConsoleScreenBufferInfoEx](http://pinvoke.net/default.aspx/kernel32.SetConsoleScreenBufferInfoEx). 

# Usage
````
-c, --colour    Required. The console colour to change
-r, --red       Required. The decimal value to assign to the red value
-g, --green     Required. The decimal value to assign to the green value
-b, --blue      Required. The decimal value to assign to the blue value
````

## PowerShell Example
This is what I used in my `Microsoft.PowerShell_profile.ps1` to set my colour preferences on starting a PowerShell prompt:

```` ps1
# http://ethanschoonover.com/solarized
# base03
& "$($(get-item $PROFILE).DirectoryName)\SetConsoleOptions.exe" -c DarkGray -r 0 -g 43 -b 54
# base02
& "$($(get-item $PROFILE).DirectoryName)\SetConsoleOptions.exe" -c Black -r 7 -g 54 -b 66
# base01
& "$($(get-item $PROFILE).DirectoryName)\SetConsoleOptions.exe" -c DarkGreen -r 88 -g 110 -b 117
# base00
& "$($(get-item $PROFILE).DirectoryName)\SetConsoleOptions.exe" -c DarkYellow -r 101 -g 123 -b 131
# base0
& "$($(get-item $PROFILE).DirectoryName)\SetConsoleOptions.exe" -c DarkBlue -r 131 -g 148 -b 150
# base1
& "$($(get-item $PROFILE).DirectoryName)\SetConsoleOptions.exe" -c DarkCyan -r 147 -g 161 -b 161
# base2
& "$($(get-item $PROFILE).DirectoryName)\SetConsoleOptions.exe" -c White -r 238 -g 232 -b 213
# base3
& "$($(get-item $PROFILE).DirectoryName)\SetConsoleOptions.exe" -c Gray -r 253 -g 246 -b 227
# yellow
& "$($(get-item $PROFILE).DirectoryName)\SetConsoleOptions.exe" -c Yellow -r 65 -g 181 -b 137
# orange
& "$($(get-item $PROFILE).DirectoryName)\SetConsoleOptions.exe" -c DarkRed -r 203 -g 75  -b 22
# red
& "$($(get-item $PROFILE).DirectoryName)\SetConsoleOptions.exe" -c Red -r 220 -g 50 -b 47
# magenta
& "$($(get-item $PROFILE).DirectoryName)\SetConsoleOptions.exe" -c Magenta -r 211 -g 54 -b 130
# violet
& "$($(get-item $PROFILE).DirectoryName)\SetConsoleOptions.exe" -c DarkMagenta -r 108 -g 113 -b 196
# blue
& "$($(get-item $PROFILE).DirectoryName)\SetConsoleOptions.exe" -c Blue -r 38 -g 139 -b 210
# cyan
& "$($(get-item $PROFILE).DirectoryName)\SetConsoleOptions.exe" -c Cyan -r 42 -g 161 -b 152
# green
& "$($(get-item $PROFILE).DirectoryName)\SetConsoleOptions.exe" -c Green -r 133 -g 153 -b 0

# solarized dark mode
$((Get-Host).UI.RawUI).BackgroundColor = "DarkGray"
$((Get-Host).UI.RawUI).ForegroundColor = "DarkBlue"
$host.privatedata.ErrorForegroundColor = "Red"
$host.privatedata.ErrorBackgroundColor = "DarkGray"
$host.privatedata.WarningForegroundColor = "DarkRed"
$host.privatedata.WarningBackgroundColor = "DarkGray"
$host.privatedata.DebugForegroundColor = "Yellow"
$host.privatedata.DebugBackgroundColor = "DarkGray"
$host.privatedata.VerboseForegroundColor = "Yellow"
$host.privatedata.VerboseBackgroundColor = "DarkGray"
$host.privatedata.ProgressForegroundColor = "DarkCyan"
$host.privatedata.ProgressBackgroundColor = "Black"
````
