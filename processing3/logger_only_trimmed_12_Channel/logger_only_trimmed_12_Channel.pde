/* Helpful info:
  long timeMillis = System.currentTimeMillis();
  long timeNano = System.nanoTime();
  http://www.dataq.com/data-acquisition/general-education-tutorials/what-you-really-need-to-know-about-sample-rate.html
  http://www.nthelp.com/ascii.htm
  http://www.live-graph.org/help/graphSettings.html
  
*/

import processing.serial.*;

int sensorCount = 12;

// For storing serial port input
String sensors[] = new String[sensorCount];


// logging
String dataFolder = "../data/adc3/";
String folderName;
String logfilename;
PrintWriter logFile;
int logDay, logHour;
boolean logging = false;

PFont f;
int SPScount;      // Data received from the serial port
int timer;      // last cycle's value container


Serial port;

//-------------------------------------SETUP-------------------------------
void setup()
{
  // prep screen
  size(100, 50);
//  printArray(PFont.list());
  f = createFont("ArialMT-18", 18);
  textFont(f);
 
  // prep serial port
  println(Serial.list());
  port = new Serial(this,Serial.list()[0],115200);
  port.bufferUntil(0x0A);
  
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
  String input = port.readStringUntil(0x0A);
  if(input != null)
  {
    input = trim(input);
    sensors = split(input,',');
    writeLog();
    SPScount++;
   }
}

//-------------------------------------DRAW-------------------------------
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


//-------------------------------------printData-------------------------------
void printData()
{
  for(int i=0; i < sensorCount; i++)
  {
    print(sensors[i]);
    print(" ");
  }
  println();
}



//-------------------------------------formatLogEntry-------------------------------
String formatLogEntry()
{
  String Hour, Minute, Second, log_time, log_entry;
  Hour = nf(hour(),2);
  Minute = nf(minute(),2);
  Second = nf(second(),2);
  long timeMillis = System.currentTimeMillis();
  log_time = Hour + ":" + Minute + ":" + Second + ":" + timeMillis + ",";
  String dataPoints = join(sensors, ",");
  log_entry = log_time + dataPoints;
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