--------------------------------------------------------

# Task 2: Singleton Implementation

## Student Info
- **Name:** Kaitlyn Grover
- **ID:** 01278586

## Pattern: Singleton
### Implementation
Much of the code I have for my project was inspired by and carried from the demo we worked on for my class. I knew that the game I would have wanted to make would need that kind of code, so I used it. I implemented it as a MonoBehaviour class with an Instance to get the code working properly for my project. The singleton pattern I used would be implemented in my project’s game manager so it can further oversee and command the uses and logic of the other commands and scripts associated with it, acting as the project’s main access point.
 

### Game Integration
The singleton pattern is implemented in my project’s main game manager, where most of my most important commands sit. There, it can view, evaluate, and coordinate things around my project that utilizes the game manager. Things like bits of my button Ui, my random coin generator, text Ui, my win & lose conditions, my ability to replay, and even my stats. There were some issues regarding other Ui elements complicating the scripts, though messing with other scripts helped make the singleton pattern and the game manager work properly again. Working with a singleton and the game manager is something I still find somewhat complicated, but one must persist.

## Game Description
- **Title:** Buggle Quest
- **Controls:** 
  - WASD -> Move
  - Left Click -> Shoot
- **Objective:** <ins>Collect bottlecaps and shoot away wasps to earn points. Gather 10,000 points to defeat the wasps once and for all!<ins>

## Repository Stats
- **Total Commits:** 10
- **Development Time:** 28 hours

--------------------------------------------------------
