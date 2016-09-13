void setup() {
  Serial.begin(57600);
}

void loop() {
  Serial.print(analogRead(A0));
  Serial.print(",");
  Serial.print(analogRead(A1));
  Serial.print(",");
  Serial.print(analogRead(A2));
  Serial.print(",");
  Serial.print(analogRead(A3));
  Serial.print(",");
  Serial.print(analogRead(A4));
  Serial.print(",");
  Serial.println(analogRead(A5));
  delay(5);        // delay in between reads for stability
}
