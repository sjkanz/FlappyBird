# Flappy Bird Unity Recreation
A basic recreation of the Flappy Bird game, developed as a beginner study tool of the Unity Game Engine and C# scripting. This project covered the building blocks of game development, from physics-based movement to dynamic object spawning.

## Overview This project was built following the Game Maker's Toolkit (GMTK) introductory tutorial. It is an application of 2D game design principles, focusing on creating an infinite game loop that includes player input through legacy movement systems, continuous obstacle generation, and score tracking.

### Key Features
- Utilized Rigidbody2D and CircleCollider2D to implement gravity and responsive "flap" mechanics via C#.
- Engineered a PipeSpawner script to instantiate pipe Prefabs at randomized heights using Random.Range.
- Implemented OnTriggerEnter2D to detect when the bird successfully passes through spaces between pipes to increment the score. Additionally, implemented Collision2D elements to check for collisions between the bird and the pipes and triggering "Game Over".
- Developed a LogicManager script to handle global game states, including active score updates and a "Game Over" UI toggle.
- Incorporated a system to destroy off-screen and unused objects, optimizing memory usage during gameplay.

### Tech Stack
Game Engine: Unity 2D (2021.3+)
Scripting Language: C#
IDE: Microsoft Visual Studio
Version Control: Git / GitHub

### Installation
1) Go to the Releases page by clicking on the Educational Build - GMTK Flappy Bird Tutorial Implementation listed under Releases on the righthand side.
2) Download the Finished.Product.zip file from the Assets folder to your computer.
3) Extract the zip folder to your computer.
4) Open the unzipped folder and run "Flappy Bird.exe". Alternatively, this may be listed as just "Flappy Bird"

Side note: Make sure the _Data folder remains in the same directory as the executable to ensure no errors in launching the game.

### What I Took Away
- Developed fundamental skills in C# scripting
- Immersed in details of legacy movement systems through manipulation of Transform.position
- Explored collision detection through hard collisions to register Game Over and trigger collisions to register points
- Cultivated game loop control by utilizing SceneManager.LoadScene 

### Credits
This project was created through following the tutorial by Mark Brown (Game Maker's Toolkit).
Original Tutorial: The Unity Tutorial For Complete Beginners
Assets: Sprites provided/inspired by the GMTK starter kit.
Developed by Sabine Kanz – https://www.linkedin.com/in/sabine-ka/
