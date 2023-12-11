# RobotSimulator

## Introduction
Console app that simulates a robot moving on a 5x5 table.
The robot must be placed on the table before issue further commands.
Any command that would mean the robot would fall of the table is ignored.
Commands are issued via command line input.

## Instrucions on how to run
Once you've cloned the repository, run the RobotSimulator command line project.
We have to first place the robot before issuing any other commands.
Commands are not case sensative.

## Commands

### Place
The place command places the robot on the table as long as the coordinates are valid.
You can place robot at anytime.
The syntax is place followed by a space then 2 numbers and a direction, seperated by commas.
Here is an example - PLACE 0,0,NORTH

### Move
The move command moves the robot forward in 1 space in the direction the robot is facing.
Simply type move to use it.

### Left
The left command turns the robot anti-clockwise.
Simply type left to use it.

### Right
The right command turns the robot clockwise.
Simply type right to use it.

### Report
The report command outputs the robots current coordinates and the direction to the command line.
Simply type report to use it.

### Exit
Use the exit command to exit the console app.

