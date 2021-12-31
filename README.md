# MakePlace Plugin

A plugin to automatically save and load housing furniture layouts for FFXIV. It can also import/export layouts from the [MakePlace](https://jawslouis.itch.io/makeplace) program since it uses the same file format.

## Installation

* You will need to use the [FFXIV Quick Launcher](https://goatcorp.github.io/) to run the game. This allows third-party plugins (such as this) to be used.
* Open the settings window by using the command `/xlsettings` in the chat, or by hitting `Esc` and selecting Dalamud Settings.
* Click on the "Experimental" tab
* Copy the following url into a new line on the Custom Plugin Repositories section: https://raw.githubusercontent.com/jawslouis/MakePlacePlugin/master/MakePlacePlugin.json
* Click on the `+` button. Make sure the new entry has "Enabled" checked.
* Click the "Save and Close" button
* Open the plugins window by typing `/xlplugins` in the chat, or hit `Esc` and select Dalamud Plugins
* Search for "MakePlace Plugin" and click "Install"

## Usage
Type `/makeplace` to open the plugin screen. Most functions are only available when in Rotate Furniture mode.

![Settings](screenshot.png?raw=true)  

* **Label Furniture**: Shows a small tooltip over each furniture, with a button to apply the layout position to the furniture
* **Save**: Saves the *currently loaded* layout to file. You start with a blank layout each time you enter the house, and will need to either import a layout or load the current house layout. 
* **Load**: Loads the layout from the specified file. The plugin will check the currently placed furniture in the house to see if there is a match with the layout. It also checks if there is a match for the dye color. All layout furniture with no match will be grayed out.
* **House Layout**: Loads the current furniture layout in the house
* **Apply**: Applies the layout position to all applicable furniture (those that are not grayed out). 
* **Time Interval**: The time period between each furniture placement when applying the entire layout. Setting this too low (e.g. 200ms) may cause some furniture placements to be missed. 

###

## FAQ
### Help! I can't get the plugin to work.
Create a github issue or post on the [discord channel](https://discord.gg/YuvcPzCuhq) for help with troubleshooting.

### Does the plugin work if the game is not in English?
Saving and loading layouts will work in all languages. However, the MakePlace program only recognizes English furniture names. Please reload the client in English and save/load the layout if you want to transfer layouts to/from the MakePlace program.

### Can I use this to copy layouts from other houses?
No. You can only load layouts when in furniture layout mode, in your own house.

### Does the plugin use furniture from my inventory or storage?
It uses the furniture that is already placed in the house. It won't touch your inventory or storage, so there's no worries about messing up inventory management. Also, since placing furniture binds it and makes it untradeable, it's best that the player does it directly.

### Is it safe to use the plugin?
Since all third-party plugins are not in line with the game's terms of service, there is always an inherent risk. The plugin's automated furniture placement may also be detectable by the server as there is a very short interval between placing each furniture. You can increase the time interval between each furniture placement to reduce this risk.

Overall, I believe that the danger is low since SE focuses more on ToS violations that upset the game-balance (e.g. RMT). You can also reduce your risk by keeping a low profile and not mentioning the use of the plugin within the game. 

### How do I update the plugin?
When an update is available, simply return to the plugins window and click on the "Update Plugins" button.

### Why does this plugin look familiar?
This plugin builds upon the foundation laid by 3 other great plugins: [HousingPos](https://github.com/Bluefissure/HousingPos), [BDTH](https://github.com/LeonBlade/BDTHPlugin) and [HouseMate](https://github.com/lmcintyre/Housemate). The UI in particular borrows heavily from HousingPos.

## Donate
Thank you for using the plugin. If you enjoy my work and wish to support me, you can use the below links:

Ko-fi: [https://ko-fi.com/jawslouis](https://ko-fi.com/jawslouis)

Patreon: [https://www.patreon.com/jawslouis](https://www.patreon.com/jawslouis)
