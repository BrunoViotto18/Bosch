#include <ezButton.h>

#define tam 11

//int leds[tam] = {2,9,5,7,6,4,11,10,1,3,8};
int leds[tam] = {1,2,3,4,5,6,7,8,9,10,11};
int LED = 0;

ezButton button(2);

void setup() {
  for(int led = 3; led < 14; led++){
    pinMode(led, OUTPUT);
  }
  Serial.begin(9600);
}

void loop() {
  button.loop();
  
  /*for(int led = 0; led < tam; led++){
    digitalWrite(leds[led] + 2, HIGH);
    while (1){
      if(button.isPressed()){
        Serial.println("The button is pressed");
        break;
      }
      Serial.println("LOOP");
    }
    delay(1000);
  }
  for(int led = 10; led >= 0; led--){
    digitalWrite(leds[led] + 2, LOW);
    while (1){
      if(button.isPressed()){
        Serial.println("The button is pressed");
        break;
      }
    }
    delay(1000);
  }*/
  if(button.isPressed()){
    if (LED < 11){
      digitalWrite(leds[LED] + 2, HIGH);
      Serial.print("Botao ");
      Serial.println(LED);
      LED++;
      delay(100);
    }else{
      digitalWrite(leds[LED-11] + 2, LOW);
      Serial.print("Botao ");
      Serial.println(LED);
      LED++;
      if (LED == 23)
      {
        LED = 0;
      }
      delay(100);
    }
    Serial.println("Botao Pressionado!");
    delay(500);
  }
}

/*void loop() {
  for(int led = 3; led < tam+3; led++){
    digitalWrite(led, HIGH);
    delay(1000);
  }
  for(int led = 13; led >= 3; led--){
     digitalWrite(led,LOW);
    delay(1000);
  }
}*/
