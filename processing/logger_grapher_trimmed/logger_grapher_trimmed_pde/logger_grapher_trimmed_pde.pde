import processing.serial.*;

// Zero Adjustments (around 512 +- for mount angle offsets)
int xadj= -512;
int yadj= -512;
int zadj= -512;
int linefeed = 10;

// For storing serial port input
int sensors[] = new int[6];

// For line drawing purposes
int old_sensors[] = new int[6];
int xpos = 1;

// decimates the plot for slower CPUs. count_limit = 0 or 1 plots every datapoint. 5 plots every 5th. etc
// 1 pixel left to right is 1 datapoint. Thus, 800px wide display with 200hz should take 4 seconds to draw.
int count = 0;
int count_limit = 1;

// logging
String dataFolder = "../data/adc3/";
String folderName;
String logfilename;
PrintWriter logFile;
int logDay, logHour;
boolean logging = false;

Serial port;

//-------------------------------------SETUP-------------------------------
void setup()
{
  // prep screen
  size(800,600,P2D);
  background(0);
  drawBaselines();

  // prep serial port
  println(Serial.list());
  port = new Serial(this,Serial.list()[0],57600);
  port.bufferUntil(linefeed);
  
  // logging
  logDay = day();
  logHour = hour();
  folderName = dataFolder + nf(year(),4) + nf(month(),2) + nf(day(),2) + "/";
  logfilename = folderName + "adc3-" + nf(year(),4) + nf(month(),2) + nf(day(),2) + "-" + nf(hour(),2) + nf(minute(),2) + nf(second(),2) + ".log";
  startLogging();
}

//-------------------------------------serialEvent-------------------------------
void serialEvent(Serial port)
{
  String input = port.readStringUntil(linefeed);
  if(input != null)
  {
    input = trim(input);
    sensors = int(split(input,','));
    writeLog();
    count++;
    
    // debug printing
    // Printing SLOWS down everything!!
   // print(input);
   // print("  --  ");
   // printData();
  }
}

//-------------------------------------DRAW-------------------------------
void draw()
{
  // all we need to do is decide if it is time to draw a pixel on the plot, and if so, call plotSensors()
  if(count >= count_limit)
  {
    plotSensors();
    count = 0;
  }
}
//-------------------------------------drawBaselines-------------------------------
void drawBaselines()
{
  stroke(255,255,255);
  line(0,height*1/6,width,height*1/6);
  line(0,height*2/6,width,height*2/6);
  line(0,height*3/6,width,height*3/6);
  line(0,height*4/6,width,height*4/6);
  line(0,height*5/6,width,height*5/6);
}

//-------------------------------------printData-------------------------------
void printData()
{
  for(int i=0; i<sensors.length; i++)
  {
    print(sensors[i]);
    print(" ");
  }
  println();
}

//-------------------------------------adjustSensors-------------------------------
void adjustSensors()
{
  sensors[0] = sensors[0]+xadj;
  sensors[1] = sensors[1]+yadj;
  sensors[2] = sensors[2]+zadj;
}

//-------------------------------------plotSensors-------------------------------
void plotSensors()
{
  adjustSensors();
  stroke(255,0,0);
  line(xpos-1,(height*1/6)-((old_sensors[0]*200)/1024), xpos,(height*1/6)-((sensors[0]*200)/1024));
  stroke(0,255,0);
  line(xpos-1,(height*3/6)-((old_sensors[1]*200)/1024), xpos,(height*3/6)-((sensors[1]*200)/1024));
  stroke(0,0,255);
  line(xpos-1,(height*5/6)-((old_sensors[2]*200)/1024), xpos,(height*5/6)-((sensors[2]*200)/1024));
  
  old_sensors = sensors;
  
  if(xpos >= width)
  {
    xpos = 0;
    background(0);
    drawBaselines();
  }
  else
  {
    xpos++;
  }
}

//-------------------------------------formatLogEntry-------------------------------
String formatLogEntry()
{
  String Hour, Minute, Second;
  Hour = nf(hour(),2);
  Minute = nf(minute(),2);
  Second = nf(second(),2);
  String log_entry = Hour + ":" + Minute + ":" + Second + "," + sensors[0] + "," + sensors[1] + "," + sensors[2] + "," + sensors[3] + "," + sensors[4] + "," + sensors[5];
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