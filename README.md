# <ins>Buggle Quest</ins>

### Game description:
- In this short and sweet game, play as Rubi, a ruby gold tortoise beetle, who is tasked to save their village from a swarm of parasitic wasps that approach the plains. Get points from collecting shiny soda bottlecaps and defeating the wasps with your trusty slingshot to help save your home and all your friends!

## _Project Evolution_

- **Current status:** Work in Progress
- **Development timeline:**
  - <ins>***Week 11:*** *Non-Playable Character Setup*</ins>
      - Prepare scripts for NPC interaction
      - Setup locations for NPCs
      - Plan dialogue/flavor text
  - <ins>***Week 12:*** *Working With NPCs*</ins>
      - Polishing code for NPC interactions
      - Creating NPC assets
      - Setting up NPC animators
      - Getting sound effects for interactions
  - <ins>***Week 13:*** *Fixing Bugs, Adjusting Volume, and New assets*</ins>
      - Fixing player spawn in walkable level
      - (If Time Permits) Add new enemy type
      - (If Time Permits) Add menu option for pause
      - (If Time Permits) Add secret level
  - <ins>***Week 14:*** *Polishing*</ins>
      - Bug fixes
      - Playtesting
  - <ins>***Week 15:*** *Final Polish, Documentation, and Beginning Presentation Preparation*</ins>
      - More bug fixes and optimization
      - Complete technical documentation
      - Start presentation materials
  - <ins>***Week 16:*** *Presentation Preparation*</ins>
      - Complete presentation materials
      - Practice demo and Q&A


---


# _Task 3: Complete Patterns Integration_

# Task 2 Foundation
- **Singleton Pattern:** GameManager, AudioManager
- **Basic game with centralized management**

## Task 3 Additions
## Observer Pattern
- **EventManager for decoupled communication**
- **Events implemented:** Updating Score, Updating Lives Count, Updating Enemy Kill Count, Win Panel, and Lose Panel
- **Observers:** UIManager, Achievements

## State Machine Pattern
- **Player States:** Move and Idle
- **Game States:** Enhanced from Task 2
- **State transitions:** When the idle state detects inputs from the W, A, S, or D keys, the state transitions into the move state. If no input is detected, it returns to the idle state.

### Key Integration Points
**1. Score System:** Singleton → Observer → UI
**2. Player Actions:** Input → State → Event → Audio
**3. Game Flow:** GameState → Events → Scene Changes

## Repository Statistics
- **Total Commits:** 26
- **Task 3 Commits:** 16
- **Lines of Code:** ~1,610
- **Development Time:** 55

## How to Play
- **Controls:**
  - WASD -> Move
  - Left Click -> Shoot
  - [E] -> Talk to NPCs!
- **Objective:** Collect bottlecaps and shoot away wasps to earn points. Gather 10,000 points to defeat the wasps once and for all!
- **New Features:** TALKING! Did you want to finally have a dialogue with someone? Well, now you can! Just press E near a fellow Buggle to talk to them!
