int BUZZER = 3;
int TONE = 100;

void setup() {
  pinMode(BUZZER, OUTPUT);
}

void loop() {
  tone(BUZZER, TONE);
  TONE++;
  if (TONE > 5000)
  {
    TONE = 100;
  }
  delay(10);
}
