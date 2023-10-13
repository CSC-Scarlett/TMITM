// download the sound library by processing

import processing.sound.*;

// Global Variables
PImage teeth;
PImage character;
PImage background;

int locationX = -80;
int locationY = 466;
int charRelativeX;
int speedY = 0;
int frame = 0;

PImage start;
PImage restart;
PImage restartText;
PImage restartSelected;

SoundFile teethAggressive;
SoundFile teethNeutral;
SoundFile teethLatched;

void setup() {
  size(800,800);
  background(250);
}

void draw() {
  
}
