## Installation

* Place the files in the directory game/na/art/mod/lif-button-zoom/ under the game root directory.
* Add the following line in the file /game/na/script/client/init.cs. It should be tha last line in the //CM_Inventory (around line 108).

  exec("art/mod/lif-button-zoom/init.cs");
  * Alternativly it is possible to load the mod from the console, instead of automactically from a script file  
  (if you just want to test the mod). Join your server, open the console using `ctrl`+`~`, and then write `exec("art/mod/lif-button-zoom/init.cs");`

## Usage

* Press ctrl+right mouse button to zoom 
