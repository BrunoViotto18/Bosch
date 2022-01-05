int LED = 3;
int POT = 0;
int tempo;

void setup() {
  pinMode(LED, OUTPUT);
}

void loop() {
  /*tempo = analogRead(POT);
  digitalWrite(LED, HIGH);
  delay(tempo);
  digitalWrite(LED, LOW);
  delay(tempo);*/
  analogWrite(LED, analogRead(POT)/4);
}
