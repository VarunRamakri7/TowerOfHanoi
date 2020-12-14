# Tower of Hanoi
Project Files from the Tower of Hanoi game made using Unity

## How To Play
The game opens to a Main Menu from where you can choose to start
the game, view the rules, or exit.
If you start the game, you will be in control of a First-Person
camera which you can be moved using WASD and the mouse for direction.
This lets you move around the environment. All you need to start
the game is to go onto the pedestal in the environment that is
marked. Once you step on the pedestal, you will be moved from the
First-Person view. This is done so that you can move the discs
between towers easily.
The game ends once all the discs have been successfully moved (in
order) from one tower to another.

### Controls
- Mouse - Menu elements, moving discs, direction (in First-Person view) 
- WASD - Move around (in First-Person view).

### Moving Discs
Click on the disc you want to move and then on the tower you want to move the disc to.
The disc and tower you select will be highlighted. If the movement is valid,
the disc will snap into place in the tower you have chosen. If the move is invalid,
a warning will appear.

## To Do:
- [x] Basic UI Implementation
- [x] Non functional game setup
- [x] Object highlighting
- [x] FPS Camera Setup
- [x] Disc Movement
- [x] Game Logic
- [x] Stack functionality
- [x] Basic full game functionality
- [x] End Game Screen
- [x] Bug fixes

## Known Bugs: (Now resolved)
- ~~`isTop` variable does not change correctly. This happens randomly. If you are unable
to move a disc in a valid move, check the disc's `isTop` value in the editor and change it to true.~~
- ~~Stack says empty when it is not. This also happens randomly. If you get a Stack related error,
press 1/2/3 to view the contents of the corresponding stack and j/k/l to clear the corresponding stack.~~

## My Methodology
Since you can only move the top most disc of each tower and move it to the top of another tower,
I use Stacks to solve the problem. The fact that Stacks follow LIFO is the reason I think they
are the best datastructure for this is problem.
I use 3 Stacks in total - One for each tower. As the player moves the disc, I pop the disc from
and push into the corresponding Stack.
The game ends when either Stack 1 or 3 have all the discs in the correct order.

