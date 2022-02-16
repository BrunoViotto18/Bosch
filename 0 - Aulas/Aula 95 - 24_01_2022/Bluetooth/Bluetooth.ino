char buf;
int LED = 8;

void setup(){
  pinMode(LED, OUTPUT);
  Serial.begin(9600);
}

void loop(){
  while(Serial.available() > 0){
    buf = Serial.read();
    if (buf == 'L'){
      digitalWrite(LED, HIGH);
    }
    if (buf == 'D'){
      digitalWrite(LED, LOW);
    }
  }
}
