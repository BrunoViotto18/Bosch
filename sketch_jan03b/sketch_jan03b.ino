int LED1 = 2;
int LED2 = 3;
int LED3 = 4;
int LED4 = 5;

void binario(){
  if(digitalRead(LED1) == HIGH){
    digitalWrite(LED1, LOW);
    if(digitalRead(LED2) == HIGH){
      digitalWrite(LED2, LOW);
      if (digitalRead(LED3) == HIGH){
        digitalWrite(LED3, LOW);
        if(digitalRead(LED4) == HIGH){
          digitalWrite(LED1, LOW);
          digitalWrite(LED2, LOW);
          digitalWrite(LED3, LOW);
          digitalWrite(LED4, LOW);
        }else{
          digitalWrite(LED4, HIGH);
        }
      }else{
        digitalWrite(LED3, HIGH);
      }
    }else{
      digitalWrite(LED2, HIGH);
    }
  }else{
    digitalWrite(LED1, HIGH);
  }
}

void setup() {
  pinMode(LED1, OUTPUT);
  pinMode(LED2, OUTPUT);
  pinMode(LED3, OUTPUT);
  pinMode(LED4, OUTPUT);
}

void loop() {
  binario();
  Serial.write(digitalRead(LED1));
  delay(500);
}
