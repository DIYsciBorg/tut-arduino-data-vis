/*
  AnalogReadSerial
  Reads an analog input on pin 0, prints the result to the serial monitor.
  Attach the center pin of a potentiometer to pin A0, and the outside pins to +5V and ground.
 
 This example code is in the public domain.
 */
#define sampleCount 1
int adcReadings[sampleCount];
int sensorValue;
#define ISD 0        // Inter-Sample delay
#define RSD 0        // Reporting Sample delay before starting loop again


void setup() {
  Serial.begin(115200);
}

void loop() {
  int i, x, t;
  for (i=0; i < (sampleCount); i++) {
    adcReadings[i] = analogRead(A0);
//    Serial.print(adcReadings[i]);
//    Serial.print(" ");
    delay(ISD);
  }
  for (i=0; i < (sampleCount); i++) {
    x = x + adcReadings[i];
  }
//  Serial.print(" TOTAL:");
//    Serial.print(x);
 sensorValue = x / sampleCount; 
//  Serial.print(" AVG:");
  Serial.println(sensorValue);
  delay(RSD);     
}
