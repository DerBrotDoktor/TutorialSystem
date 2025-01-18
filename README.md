# TutorialSystem

**TutorialSystem** is a Unity project designed to help quickly, easily, and modularly create and extend tutorials.

## Features
- Create tutorials with multiple steps.
- Easily integrate custom logic.
- Modular structure to extend tutorials effortlessly.

## Usage
An example can be found in the demo scene.

1. Create a Tutorial Manager. (This handles starting tutorials)
2. Create a game object with the Tutorial script.
3. Add child objects as needed and attach the desired Tutorial Steps to them. (One step per game object)
   > These can be disabled to avoid triggering updates.
   > They are automatically enabled and disabled when it is their turn.
4. Add the new tutorial to the Tutorial Manager.
5. There are two ways to start the tutorial:
   1. Specify the tutorial as the next tutorial for a previous one. This way, it starts automatically after the previous tutorial is completed.
   2. Create a Tutorial Trigger and assign the tutorial to be started.

Steps and triggers can be easily inherited and overridden to implement custom logic.
