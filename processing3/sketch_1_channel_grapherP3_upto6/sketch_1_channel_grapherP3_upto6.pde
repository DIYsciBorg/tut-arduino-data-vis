/**
 * Simple Read
 * 
 * Read data from the serial port and change the color of a rectangle
 * when a switch connected to a Wiring or Arduino board is pressed and released.
 * This example works with the Wiring / Arduino program that follows below.
 */


import processing.serial.*;

Serial port;  // Create object from Serial class
String inString;

int val;      // Data received from the serial port
int old;      // last cycle's value container
int xpos;     // current x position
int verticalAdjust = 0;   //384

int sensors[] = new int[5];        //how many data points in each serial send?
int old_sensors[] = new int[5];  

// logging
String dataFolder = "../data/adc3/";
String folderName;
String logfilename;
PrintWriter logFile;
int logDay, logHour;
boolean logging = false;


void setup() 
{
  frameRate(400);
//  smooth();
  size(800, 600);  //P2D
  clearScreen();
  // I know that the first port in the serial list on my mac
  // is always my  FTDI adaptor, so I open Serial.list()[0].
  // On Windows machines, this generally opens COM1.
  // Open whatever port is the one you're using.
  
  printArray(Serial.list());
  String portName = Serial.list()[0];
  port = new Serial(this, Serial.list()[0], 115200);
  port.bufferUntil(0x0a);
  
   // logging
  logDay = day();
  logHour = hour();
  folderName = dataFolder + nf(year(),4) + nf(month(),2) + nf(day(),2) + "/";
  logfilename = folderName + "adc3-" + nf(year(),4) + nf(month(),2) + nf(day(),2) + "-" + nf(hour(),2) + nf(minute(),2) + nf(second(),2) + ".log";
  startLogging();
}

void serialEvent(Serial p) {
  inString = port.readStringUntil(0x0A);
  if(inString != null)
  {
    inString = trim(inString);
    if (sensors.length > 1){
      sensors = int(split(inString,','));
    }else{
      sensors[0]=int(inString);
    }
    printData();
 //   writeLog();
  }
}

void drawLine()
{
  stroke(255,255,0);                        // data color
//  point(xpos, val);
  line(xpos-1, old, xpos, val-verticalAdjust);
  old = val-verticalAdjust;
  xpos++;
//  println(xpos);
  if (xpos > width) {
   xpos = 0;
   clearScreen();
 }
}

void draw()
{
 if(inString != null)
  {
  //  inString = trim(inString);
//    val = Integer.parseInt(inString);
    val = sensors[0];
//    val = val - verticalAdjust;
    println(val);
    drawLine();
  }
}

void clearScreen()
{
  background(0);             // Set background to black
  stroke(255,255,255);       // center line color
  line(0,height*1/2,width,height*1/2);   // draw centerline
}

void printData()
{
  for(int i=0; i<sensors.length; i++)
  {
    print(sensors[i]);
    print(" ");
  }
  println();
}

String formatLogEntry()
{
  String Hour, Minute, Second;
  Hour = nf(hour(),2);
  Minute = nf(minute(),2);
  Second = nf(second(),2);
  String log_entry = Hour + ":" + Minute + ":" + Second + "," + sensors[0] + "," + sensors[1] + "," + sensors[2]+ sensors[3] + "," + sensors[4] + "," + sensors[5];
  return log_entry;
}

//-------------------------------------writeLog-------------------------------
void writeLog()
{
  if (logging)
  {
    String log_entry = formatLogEntry();
    logFile.println(log_entry);
    logFile.flush();
  }
}

//-------------------------------------startLogging-------------------------------
void startLogging()
{
  // open file
  openLogFile();
  // start running
  logging = true;
  println("Started logging to " + logfilename);
}

//-------------------------------------stopLogging-------------------------------
void stopLogging()
{
  logging = false;
  closeLogFile();
  println("Stopped Logging.");
}

//-------------------------------------openLogFile-------------------------------
void openLogFile()
{
  // logfilename = logfileTextField.getText();
  if (logfilename.equals(""))
  {
    // set tentative file name
    logfilename = dataFolder + "addc3-" + nf(year(),4) + nf(month(),2) + nf(day(),2) + "-" + nf(hour(),2) + nf(minute(),2) + nf(second(),2) + ".log";
  }
  logFile = createWriter(logfilename);
  println("Log file opened: " + logfilename);
}

//-------------------------------------closeLogFile-------------------------------
void closeLogFile()
{
  logFile.flush();
  logFile.close();
  println("Log file close.");
  // set tentative file name
  logfilename = dataFolder + "adc-" + nf(year(),4) + nf(month(),2) + nf(day(),2) + "-" + nf(hour(),2) + nf(minute(),2) + nf(second(),2) + ".log";
}