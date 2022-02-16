int LED1 = 3;
int LED2 = 4;
int LED3 = 5;
int POT = 0;
int pot;
 
void setup()
{
  pinMode(LED1, OUTPUT);
  pinMode(LED2, OUTPUT);
  pinMode(LED3, OUTPUT);
}

void loop()
{
  digitalWrite(LED1, LOW);
  digitalWrite(LED2, LOW);
  digitalWrite(LED3, LOW);
  pot = map(analogRead(POT), 0,1023, 1,99);
  if (pot <= 33){
    digitalWrite(LED1, HIGH);
  }else if (pot <= 66){
    digitalWrite(LED2, HIGH);
  }else{
    digitalWrite(LED3, HIGH);
  }
}
