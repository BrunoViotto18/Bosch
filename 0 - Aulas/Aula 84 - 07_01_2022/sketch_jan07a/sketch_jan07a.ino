#include <Servo.h>

int servo = 2;
int POT = A0;

Servo SERVO;

void setup() {
  SERVO.attach(servo);
  SERVO.write(0);
  Serial.begin(9600);
}

void loop() {
  SERVO.write(map(analogRead(POT), 0, 1023, 0, 179));
}
