# Fortnite Config Tool

![Fortnite Config Tool](https://i.imgur.com/Rkylkac.png)

This is a simple tool to quickly and easily edit Fortnite's GameUserSettings.ini. Fortnite's in-game options are quite limited which makes custom resolutions and specific FPS limits impossible to achieve.

*You still have to configure the custom resolution on your PC. This can be done via NVIDIA/AMD Control Panel or by following along with this [YouTube tutorial](https://www.youtube.com/watch?v=YO4a-yV073o).*

**Please stay hydrated. Fortnite with stretched resolution is known to cause an an increase in persperation.**

****

## Features

* Set custom resolutions not possible via the in-game menu
* Set FPS limit to any value
* Lightweight & Fast
  * Less than 250kb decompressed
  * Programmed in native C# with no unnecessary plugins/frameworks
* Fullscreen toggle
  * Must be enabled to enter a custom resolution (custom resolutions do not work outside of fullscreen mode)
* Uncapped FPS toggle
  * Must be disabled to enter a custom FPS cap
* Backup option (enabled by default)
  * Creates a GameUserSettings.old file in the config's directory
* Loads current config values on launch
* Dynamic read-only handling
  * Read-only attribute disabled before writing new config and re-enabled afterwards (only if it was before)
  * There should be no reason to set config as read-only but this was the best way to handle all possible scenarios
* Button to open your config directory
* Button to open FCT's GitHub repo
* Button to launch NVCP if possible
  * This button only applies to NVIDIA users
  * If someone with an AMD GPU would like to help me make this button dynamic based on user's GPU, please add my Discord below
  
## Support

* Discord: ```Takoid#3709```

## Download
[Releases](https://github.com/TakoidGit/FortniteConfigTool/releases)
