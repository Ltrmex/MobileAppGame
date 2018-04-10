# Mobile Applications Development 2 Project

### Instructions
> The application can be a game (UNITY is acceptable with C# scripting) or an interactive information app. What the app does is up 
to you. You can have a single page app, or one with many pages – that is a choice.
- > Mobile Applications Development 2 Projects Specs 2018

### Requirements
| Requirement      | Done  | Achieved By |
| :---:            | :---: |  :---:      |
| Well Designed UI | Yes   | Main menu, pause menu, game over screen, anything needed clearly visible |
| Storing Data     | Yes   | Completed by using Unity's PlayerPref, which stores user highscores locally |
| Sensors          | No    | --------------------------------------------------------------------------- |
| Interactivity    | Yes   | Tab panels, buttons, onlick gameobject towers placement, tower onlick upgrade |

### Required to Run
* Unity account
    - [Create Unity Account](https://id.unity.com/en/conversations/b354fb91-72d5-412e-a6bb-440eee53a36a01af)
* Lastest version of Unity
    - [Install Unity](https://unity3d.com/get-unity/download)
* Or you can get it from Windows Store:
    - [Get Endless Nightmare App](https://unity3d.com/get-unity/download)
    
### How to Run
* In Unity:
    - Open up command prompt and navigate where you would like to store the app
    - Clone this repository
        - git clone https://github.com/Ltrmex/MobileAppGame.git
    - Open up the project in Unity editor
        - Double click Main Menu scene from Assets->Scenes->Main Menu and press play button
        - Or at the top left corner of the Unity editor go to File->Build & Run
* From Windows Store:
    - Go to [Get Endless Nightmare App](https://unity3d.com/get-unity/download), install and launch the game

### Endless Nightmare - App Description
* It is a basic Tower Defense game where player is able to place towers which will shoot infinite waves of enemies

### Endless Nightmare - App Functionality
* Main menu with start, highscores and quit options
    - When start is pressed player is able to choose from three different difficulties which after game begins
        - Easy
        - Medium
        - Advanced
    - When highscores is pressed player can the the top five scores(waves passed) 
        - If not played before it's empty
        - Back button present to go back to main menu
        - Updates at the end of the game if one of the top five scores was beat
    -  When quit is pressed is simply exits the application
* Maps are generated from file
    - Array gets populated with cube gameobjects
    - File is collection of numbers
        - Each number represents index in the array
    - Each difficulty gets its own waypoints, start and end points, amount of lives, enemy health
* Three buttons available on the right top side
    - B to place beams towers
    - T to place basic towers
    - S to toggle tabs
* Two types of towers
    - Beam
        - Shoots beam which damages and slows the enemy
    - Basic
        - Shoots basic bullets to damage enemies
* Tabs contains three different tabs
    - Towers
    - Upgrades
    - Game Info
* Player can upgrade or buy new towers if collected enough gold by defeating enemies
* Player can place towers by selecting B or T to place
    - NOTE: Player must have enough gold to buy them
        - If not enough gold then message is displayed in game info tab
* Player can pause the game by pressing 'ESC' on keyboard
    - To continue press 'ESC' again
    - To exit press quit button
    - To go menu press main menu
* Upon player losing all the lives game over screen is displayed
    - Player can enter their name
        - If player beat one of top five, players name, wave number and difficulty gets put into top 5

### References
* Graphics:
    - [Dev Assets](http://devassets.com/)
    - [Open Game Art](https://opengameart.org/)
* Code:
    - [Learn Everything Fast](https://www.youtube.com/watch?v=82Mn8v55nr0)
    - [inScope Studios](https://www.youtube.com/watch?v=p3lAmkxTUz8)
    - [Open Game Art](https://opengameart.org/)
    - [Unity](https://unity3d.com/learn/tutorials/projects/space-shooter/spawning-waves)
    - [Unity](https://unity3d.com/learn/tutorials/topics/scripting/high-score-playerprefs)
    - [Brackeys](https://www.youtube.com/playlist?list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0)
