# Flappy Bird Unity Recreation
A 2D recreation of the classic Flappy Bird mobile game, developed as a beginner study tool of the Unity Game Engine and C# scripting. This project covers the fundamental building blocks of game development, from physics-based movement to dynamic object spawning.

## 🚀 Overview This project was built following the Game Maker's Toolkit (GMTK) introductory curriculum. It serves as a practical application of 2D game design principles, focusing on creating a "game loop" that includes player input, obstacle generation, score tracking, and fail-state management.

### ✨ Key Features
Physics-Based Movement: Utilized Rigidbody2D and CircleCollider2D to implement gravity and responsive "flap" mechanics via C#.

Dynamic Spawning System: Engineered a PipeSpawner script to instantiate pipe Prefabs at randomized heights using Random.Range.

Collision & Trigger Logic: Implemented OnTriggerEnter2D to detect when the bird successfully passes through pipes to increment the score.

Game Manager & UI: Developed a LogicManager script to handle global game states, including real-time score updates and a "Game Over" UI toggle.

Object Pooling Concepts: Incorporated a "Dead Zone" cleanup system to Destroy off-screen objects, optimizing memory usage during gameplay.

### 🛠️ Tech Stack
Game Engine: Unity 2D (2021.3+)

Scripting Language: C#

IDE: Microsoft Visual Studio

Version Control: Git / GitHub

### 🔧 Installation & Setup
Go to the Releases page of this repository.

Download the FlappyBird_v1.0_Windows.zip file from the Assets section.

Extract the ZIP folder to your computer.

Open the folder and run FlappyBird.exe.

Note: Ensure the _Data folder remains in the same directory as the executable for the game to launch.
### 🧠 Lessons Learned
- Developed fundamental skills in C# scripting
- Immersed in details of legacy movement systems through manipulation of Transform.position
- Explored collision detection through hard collisions to register Game Over and trigger collisions to register points
- Cultivated game loop control by utilizing SceneManager.LoadScene 

### 📜 Credits
This project was developed using the foundational tutorial by Mark Brown (Game Maker's Toolkit).

Original Tutorial: The Unity Tutorial For Complete Beginners

Assets: Sprites provided/inspired by the GMTK starter kit.

Developed by Sabine Kanz – https://www.linkedin.com/in/sabine-ka/
