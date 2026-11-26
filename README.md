# BlockDestroyer

*Note: This repository is going to be archived on Github. I don't know if I'm going to ever revisit it, but if I do, it will be on my self-hosted forge: http://code.ericmesa.com/djotaku/blockdestroyer*

An arkanoid or brick breaker clone from an older version of [this Unity class](https://gamedev.tv/courses/unity6-complete-2d)

Get binaries from this repo (click on "Releases") or play on the net via WebGL: (I don't have this up anymore I'll have to see if I can find the code in one of my server backups)

Watch a video of the game playing itself: https://youtu.be/uwbml6dCAfM

# Things I've Improved after the end of the Section Lectures
 - Created my own levels

 - Added ability to change title with each new level (did this on my own without any help! WHOOO!)
 
 - Added controller support. A lot of help from /r/Unity3D and others on making sure my settings were correct. Also, Udemy class Laser defender code showed me what I needed in C# to make the controller work. But I figured out on my own how to setup an options page and make those options work throughout the game to allow the user to use either a mouse or the controller.

# Things I learned in this section

 - Moving things on the screen based on the mouse

 - Unity World Units as a way to decide where things are in the world. Has to do with the size if your camera.

 - Physics makes the ball fall while collisions make it bounce

 - A trigger collider is used to detect if the player has reached a certain area. Here we use an empty with a collider and make it a trigger in order to know when the ball has been missed by the paddle

 - Learned how to export/import scenes and scripts

 - Learned about right-clicking and refactoring in Visual Studio

 - Learned how to print the score to the screen and how to persist it from one level to another via the Singleton Pattern.

 - Using tags in Unity so that the scripts can do different things to the objects based on the tag

 - Prefabs vs Duplicates. Prefabs are more useful because they allow you to effect changes across all the instances of the Prefab in the game.
 
  - how to make your game play itself for play testing
