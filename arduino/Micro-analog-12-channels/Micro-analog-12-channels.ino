/*
  Heli Data Acquisition Unit v0.2
  ACSL
  Emery Premeaux
  
  Reads ALL analog channels of an Arduino Micro
  Sends text readable data via serial port to PC
  
  Sample Hz table (when RSD and ISD = 0) for sample count = x
  (Does not include overhead such as adding milis timestamps)
  
            samples to average
  Channels 1      2      3      4      5
      1    3225   1920   1590   1345   1240
      2    0      0      0      0      0       
      3    0      0      0      0      0            
      4    1035   666    0      0      338            
      5    0      0      0      0      0            
      8    0      0      0      0      0              
      10   0      0      0      0      0             
      12   280    192    150    123    105
      
  Sample Hz table (when RSD and ISD = 1) for sample count = x
  (Does not include overhead such as adding milis timestamps)
  
            samples to average
  Channels 1      2      3      4      5
      1    430    0      0      0      146
      2    0      0      0      0      0       
      3    0      0      0      0      0            
      4    0      0      0      0      0            
      5    136    0      0      0      34            
      8    0      0      0      0      0              
      10   0      0      0      0      0             
      12   61     0      0      0      14
  
 */

#define DEBUG 0      // Debug switch. 0 = off, 1 = on
#define SENSORS 3    // Number of analog sensors, from A0 to A11 (1-12 sensors)
#define SAMPLES 1     // Number of samples per pin to average
#define ISD 0        // Inter-Sample delay: delay between each sample. Generally set to 0
#define RSD 5        // Reporting Sample delay: between each cycle. Generally set to 0
#define SERIAL_SPEED 57600


int i, x , t, a;                      // For loop counters
int SensorValues[SENSORS][SAMPLES];  // 2D array to hold sensor values
int SensorAverage[SENSORS];         // Array for holding averaged sensor value for reporting 


void setup() {
  Serial.begin(SERIAL_SPEED);
}

void loop() {
  SensorsRead();
  SensorsAverage();
  SensorsPrint();
  delay(RSD);
}

void SensorsRead(){
  for (i=0; i < SAMPLES; i++) {
    for (x=0; x < SENSORS; x++) {
      SensorValues[x][i] = analogRead(x);
      if (DEBUG == 1) {
        Serial.print(x);
        Serial.print(":");
        Serial.print(i);
        Serial.print("=");
        Serial.print(SensorValues[x][i]);
        Serial.print(" ");
      }
      delay(ISD);
    }
    if (DEBUG == 1) {
      Serial.println();
    }
  }
}

void SensorsAverage(){
 //addition of the array rows and averageing
 for (a=0; a < SENSORS; a++) {
    SensorAverage[a] = 0;
    for (t=0; t < SAMPLES; t++) {
      SensorAverage[a] = SensorAverage[a] + SensorValues[a][t];
    }
    if (DEBUG == 1) {              // print some text if debug is on
      Serial.print("TotSens ");
      Serial.print(a);
      Serial.print(":");
      Serial.print(SensorAverage[a]);
    }
    
    SensorAverage[a] = SensorAverage[a]/SAMPLES;
    if (DEBUG == 1){
      Serial.print(" Avg:");
      Serial.println(SensorAverage[a]);
    } else {
      // Serial.print(a);
      // Serial.print(":");
      Serial.print(SensorAverage[a]);
      if (a < SENSORS - 1) {
        Serial.print(",");
      }
    }
  }
  Serial.println();
}

void SensorsPrint(){
 //output to the serial port
}
