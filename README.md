# Fortnite Config Tool

![Fortnite Config Tool](https://i.imgur.com/wnPzcKq.png)

This is a simple tool to easily and quickly edit Fortnite's GameUserSettings.ini.

*You still have to configure the custom resolution on your PC. This can be done via NVIDIA/AMD Control Panel or by following along with this [YouTube tutorial](https://www.youtube.com/watch?v=YO4a-yV073o)*

## Features

* Custom resolution
* Custom FPS cap
* Fullscreen toggle
  * Must be enabled to enter a custom resolution
* Uncapped FPS toggle
  * Must be disabled to enter a custom FPS cap
* Backup option
  * Creates a GameUserSettings.old file in the config's directory, enabled by default
* Reads current config file and loads current values on launch
* Dynamic read-only handling
  * Read-only attribute disabled before writing new config and re-enabled afterwards (only if it was before)
* Button to open your config directory
* Button to open FCT's GitHub repo
* Button to launch NVCP if possible
  * This button only applies to NVIDIA users
  * If someone with an AMD GPU would like to help me make this button dynamic based on user's GPU, please add my Discord below
  
## Support

* Discord: ```Takoid#3709```
  * Send me a message and I will respond as soon as I can

## Download
[Releases](https://github.com/TakoidGit/FortniteConfigTool/releases)
