This Unity game provides a 3D display for the standard center-out cursor reaching task. 

There are two spherical objects, the cursor (yellow) and the target (blue), in a checkerboard scene (see game.png). The player controls the cursor and moves it towards the target. The cursor could go through the target. The target becomes semi-transparent when touched by the cursor. Cursor position is reset to the center at the start of each trial.

This game connects to MessageManager to receive and send Dragonfly messages. It receives target position and cursor movement commands, and sends cursor position back.

The output video is in a left-right side-by-side stereo layout. The default resolution is 1920x1080 with a 16:9 aspect ratio. One may choose a different resolution from the default, but should keep the aspect ratio the same. Changing the aspect ratio would end up with incorrect 3D effects.


## To build the project

### Prerequisites

Two additional external files are required:

* Dragonfly.Unity.dll - the Dragonfly library for Unity and C#

    This file is from the Dragonfly software under Dragonfly/lang/unity. One may need to build or rebuild the project to create this dynamic link library.

* Dragonfly\_config\_Unity.cs - message definitions for Unity and C#

    This file is from BCI/message_definitions. One may need to run build\_message\_defs\_cs\_Unity.m in Matlab to create this file.

### Steps

* Build or rebuild the above two files as needed and copy them to UnityVR\_CenterOut/Assets/Scripts. 
* Open the UnityVR\_CenterOut project with Unity. If the checkerboard scene is not shown, go to Project -> Assets -> _Scenes and double click on CenterOut.
* Go to File -> Build Settings and build the project.


## To run the game

Run the BCI/tools/start_UnityVR_CenterOut.bat script (for Windows).

Note that MessageManager has to run first. Otherwise this game would fail to connect to MessageManager and crash.
