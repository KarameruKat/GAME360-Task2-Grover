# Task 3: Complete Patterns Integration

<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> main
# Project Evolution
# Task 2 Foundation
- **Singleton Pattern:** GameManager, AudioManager
- **Basic game with centralized management**
<<<<<<< HEAD

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
- **Total Commits:** 22
- **Task 3 Commits:** 12
- **Lines of Code:** ~1,610
- **Development Time:** 55

## How to Play
- **Controls:**
  - WASD -> Move
  - Left Click -> Shoot
  - [E] -> Talk to NPCs!
- **Objective:** Collect bottlecaps and shoot away wasps to earn points. Gather 10,000 points to defeat the wasps once and for all!
- **New Features:** TALKING! Did you want to finally have a dialogue with someone? Well, now you can! Just press E near a fellow Buggle to talk to them!
=======
# Task 2: Singleton Implementation
=======
>>>>>>> main

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
- **Total Commits:** 24
- **Task 3 Commits:** 14
- **Lines of Code:** ~1,610
- **Development Time:** 55

## How to Play
- **Controls:**
  - WASD -> Move
  - Left Click -> Shoot
<<<<<<< HEAD
- **Objective:** <ins>Collect bottlecaps and shoot away wasps to earn points. Gather 10,000 points to defeat the wasps once and for all!<ins>

## Repository Stats
- **Total Commits:** 10
- **Development Time:** 28 hours

--------------------------------------------------------
>>>>>>> main
=======
  - [E] -> Talk to NPCs!
- **Objective:** Collect bottlecaps and shoot away wasps to earn points. Gather 10,000 points to defeat the wasps once and for all!
- **New Features:** TALKING! Did you want to finally have a dialogue with someone? Well, now you can! Just press E near a fellow Buggle to talk to them!
>>>>>>> main
