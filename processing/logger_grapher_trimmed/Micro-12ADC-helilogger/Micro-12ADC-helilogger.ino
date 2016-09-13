/*
  
 
 Data out to zigbee use Serial1.....
 Data out to usb use Serial...
 */

// the setup routine runs once when you press reset:
void setup() {
  // initialize serial communication at 9600 bits per second:
  Serial.begin(57600);      // USB monitor
  Serial1.begin(57600);     // Zigbee port
}

// the loop routine runs over and over again forever:
void loop() {
  // read the input on analog pin 0-11:
  int sensorValue0 = analogRead(A0);
  int sensorValue1 = analogRead(A1);
  int sensorValue2 = analogRead(A2);
  int sensorValue3 = analogRead(A3);
  int sensorValue4 = analogRead(A4);
  int sensorValue5 = analogRead(A5);
  int sensorValue6 = analogRead(A6);
  int sensorValue7 = analogRead(A7);
  int sensorValue8 = analogRead(A8);
  int sensorValue9 = analogRead(A9);
  int sensorValue10 = analogRead(A10);
  int sensorValue11 = analogRead(A11);
  
  
  // print sensor values 0-11 to the USB monitor:
  Serial.print(sensorValue0);
  Serial.print(",");
  Serial.print(sensorValue1);
  Serial.print(",");
  Serial.print(sensorValue2);
  Serial.print(",");
  Serial.print(sensorValue3);
  Serial.print(",");
  Serial.print(sensorValue4);
  Serial.print(",");
  Serial.print(sensorValue5);
  Serial.print(",");
  Serial.print(sensorValue6);
  Serial.print(",");
  Serial.print(sensorValue7);
  Serial.print(",");
  Serial.print(sensorValue8);
  Serial.print(",");
  Serial.print(sensorValue9);
  Serial.print(",");
  Serial.print(sensorValue10);
  Serial.print(",");
  Serial.println(sensorValue11);
  
  // print sensor values 0-11 to the ZigBee:
  Serial1.print(sensorValue0);
  Serial1.print(",");
  Serial1.print(sensorValue1);
  Serial1.print(",");
  Serial1.print(sensorValue2);
  Serial1.print(",");
  Serial1.print(sensorValue3);
  Serial1.print(",");
  Serial1.print(sensorValue4);
  Serial1.print(",");
  Serial1.print(sensorValue5);
  Serial1.print(",");
  Serial1.print(sensorValue6);
  Serial1.print(",");
  Serial1.print(sensorValue7);
  Serial1.print(",");
  Serial1.print(sensorValue8);
  Serial1.print(",");
  Serial1.print(sensorValue9);
  Serial1.print(",");
  Serial1.print(sensorValue10);
  Serial1.print(",");
  Serial1.println(sensorValue11);
  
  
  delay(20);        // delay in between sets sample rate (practical limit by baud rate
                    //  5 = 200Hz
                    // 10 = 100Hz 
                    // 20 = 50Hz
                    // 50 = 20Hz  
  
}
