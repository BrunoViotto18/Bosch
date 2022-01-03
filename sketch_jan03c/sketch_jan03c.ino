int BOTAO = 2;
int LED = 3;

void setup() {
  pinMode(BOTAO, INPUT);
  pinMode(LED, OUTPUT);
}

void loop() {
  if(digitalRead(BOTAO) == HIGH){
    digitalWrite(LED, HIGH);
  }else{
    digitalWrite(LED, LOW);
  }

}
