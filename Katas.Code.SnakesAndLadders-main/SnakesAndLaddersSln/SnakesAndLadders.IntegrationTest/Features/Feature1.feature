Feature: Feature1

A short summarySnakes and Ladders is a board game involving two or more players rolling dice in order to move their tokens across a board. The board is made up of a collection of numbered squares and is adorned with 'snakes' and 'ladders', 
which link two squares on the board- snakes link the squares downwards whilst ladders link them going upwards. This means that landing at the bottom of a ladder moves you to the top of that ladder, whereas landing on the top of a snake moves 
you to the bottom of that snake. The objective of the game is to get your token to the final square before your opponents do.

From a technical point of view, the implementation of this game needs to be platform agnostic. We are going to want to launch this game on multiple devices and need a solid, robust game library which we can use as the backend for every frontend 
we stick on it. For this reason, we are not interested in the frontend you choose to use to test the game, only that the core game logic is separate and tested. of the feature


US 1 - Token Can Move Across the Board
=========================================
As a player
I want to be able to move my token
So that I can get closer to the goal


US 2 - Player Can Win the Game
=========================================
As a player
I want to be able to win the game
So that I can gloat to everyone around


US 3 - Moves Are Determined By Dice Rolls
=========================================
As a player
I want to move my token based on the roll of a die
So that there is an element of chance in the game


@US-1 @UAT1
Scenario: game is started
	Given the game is started
	When the token is placed on the board
	Then the token is on square 1
