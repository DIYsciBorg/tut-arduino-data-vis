/**
 * Simple Read
 * 
 * Read data from the serial port and change the color of a rectangle
 * when a switch connected to a Wiring or Arduino board is pressed and released.
 * This example works with the Wiring / Arduino program that follows below.
 */


import processing.serial.*;

Serial myPort;  // Create object from Serial class
String inString;
int val;      // Data received from the serial port
int old;      // last cycle's value container
int xpos;     // current x position
int lf = 10;
int verticalAdjust = 50;

void setup() 
{
  size(512, 256);  //P2D
  clearScreen();
  // I know that the first port in the serial list on my mac
  // is always my  FTDI adaptor, so I open Serial.list()[0].
  // On Windows machines, this generally opens COM1.
  // Open whatever port is the one you're using.
  
  printArray(Serial.list());
  String portName = Serial.list()[0];
  myPort = new Serial(this, Serial.list()[0], 115200);
  myPort.bufferUntil(lf);
}

void serialEvent(Serial p) {
  inString = p.readStringUntil(lf);
  if(inString != null)
  {
    inString = trim(inString);
    val = Integer.parseInt(inString);
    val= val - verticalAdjust;
    drawLine();
  }
}

void drawLine()
{
  stroke(255,0,0);                        // data color
  line(xpos-1, old, xpos, val);
  println(val);
  old = val;
  xpos++;
//  println(xpos);
//  if (xpos > width) {
//   xpos = 0;
//   clearScreen();
// }
}

void draw()
{
 if (xpos > width) {
   xpos = 0;
   clearScreen();
 }
}

void clearScreen()
{
  background(0);             // Set background to black
  stroke(255,255,255);       // center line color
  line(0,height*1/2,width,height*1/2);   // draw centerline
}