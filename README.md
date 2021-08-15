# LolAccountManager
![ExampleIMG](https://i.imgur.com/Bspz0CH.png)

[More screenshots can be found here](https://imgur.com/a/d2nNRYF)


LolAccountManager is a account manager for League Of Legends with the ability to automatically sign you into your accounts.



Use at your own risk!
## Features
- Keep track of all your league of legends accounts
- Sign in by double clicking on a account
- Ability to load and save accounts
- Rank (Solo/Flex)
- Run on Startup
- Start minimized
- BE and RP 



## Tested on these servers
- EUW
- PBE
- KR
- NA
- EUNE

## Todo:
- Language packs
- Feel free to add suggestions by opening an issue.

## Used Libraries
- Newtonsoft.Json

## Video 
[![Example Video](https://img.youtube.com/vi/2FM-Na2WFGI/0.jpg)](https://www.youtube.com/watch?v=2FM-Na2WFGI "LolAccountManager")

## Requirements
[.NET](https://dotnet.microsoft.com/download/dotnet/5.0)


## Please note
Release V1.3 kept getting flagged as malware (false positive), so I submitted LolAccountManager to microsoft for malware analysis. The analyst gave me this reply:

The file is not malware and we cannot reproduce any detection on the file. If detection is still observed, please follow the steps below to capture support log files from the system reporting detection.

On Windows 10, from elevated command prompt, change to directory "%programfiles%\windows defender" and execute mpcmdrun.exe with option GetFiles:
cd "%programfiles%\windows defender"
mpcmdrun.exe -GetFiles

On Windows 7, from elevated command prompt, change to directory "%programfiles%\microsoft security client" and execute mpcmdrun.exe with option GetFiles:
cd "%programfiles%\microsoft security client"



LolAccountManager isn't endorsed by Riot Games and doesn’t reflect the views or opinions of Riot Games or anyone officially involved in producing or managing League of Legends. League of Legends and Riot Games are trademarks or registered trademarks of Riot Games, Inc. League of Legends © Riot Games, Inc.
