
import processing.serial.*;

Serial myPort;  // Create object from Serial class
String inString;
int SPScount;      // Data received from the serial port
int timer;      // last cycle's value container
int lf = 0x0A;
PFont f;

void setup() 
{
  size(100, 50);
  printArray(PFont.list());
  f = createFont("ArialMT-18", 18);
  textFont(f);
  
  printArray(Serial.list());
  String portName = Serial.list()[0];
  myPort = new Serial(this, Serial.list()[0], 115200);
  myPort.bufferUntil(lf);
}

void serialEvent(Serial p) {
  inString = p.readStringUntil(lf);
  SPScount++;
}


void draw()
{
  if (millis() - timer >= 1000) {  // 1 second count
    print(SPScount);               // display it to me
    println(" Samples Per Second");
    background(0);
    textAlign(LEFT);
    textFont(f);
    textSize(21);
    text(SPScount, 15, 30); 
    SPScount = 0;                  // reset the counter
    timer = millis();              // reset the timer
  }
}