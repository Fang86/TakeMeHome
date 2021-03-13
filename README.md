# Take Me Home
Take Me Home allows you to return to your spawn point with the press of a button. You can also teleport back to the position you were previously at when you teleported home.

By default, the hotkey to teleport home is `P` and the hotkey to return to your location before teleporting home is `L`.

The first time you press to home hotkey it will log your initial spawnpoint and current location. Any time it is pressed after this, you will be teleported home.

## Manual Installation
In order to install this mod, you need to have `BepInEx installed`. After installing these, place `takemehome.dll` (extract zip) into `(Your Steam games directory)\Valheim\BepInEx\plugins`.

## Config
Before the config file is generated, you must run the game with the mod installed.

To edit the number of rows in your inventory go to `(Your Steam games directory)\Valheim\BepInEx\config` and open `takemehome.cfg` in notepad. Then change the keycode (usually a capital letter) after the "=" sign. There is a large list of unity key codes above each config entry - you can use any one of these key codes. 

## Changelog
1.0.2 - Fixed bug that teleported while naming a map pin
1.0.1 - Fixed issues with certain text input fields not preventing teleport (portals, signs, etc.)
1.0.0 - Initial release