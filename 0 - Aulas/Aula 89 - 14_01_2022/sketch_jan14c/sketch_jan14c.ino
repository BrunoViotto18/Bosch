#include <LiquidCrystal.h>

#define CONTAS 3

LiquidCrystal lcd(25, 26, 27, 14, 12, 13);
int BOTAO = 32;
int POTENC = 33;

String website[CONTAS] = {"Gmail", "Github", "Youtube"};
String email[CONTAS] = {"industriaquatro.0@gmail.com", "industriaquatro.0@gmail.com"};
String senha[CONTAS] = {"industria4.0", "industria4.0"};

int opcao = 0;

void setup() {
  lcd.begin(16, 2);
  pinMode(BOTAO, INPUT_PULLUP);
}

void loop() {
  opcao = analogRead(POTENC);
  
  for(int i = 0; i < CONTAS; i++)
  {
    if(opcao <= (1023 / CONTAS * (i+1)))
    {
      lcd.clear();
      lcd.setCursor(0,0);
      lcd.write("> ");
      lcd.print(website[i]);
      if(i != CONTAS-1)
      {
        lcd.setCursor(0,1);
        lcd.write("  ");
        lcd.print(website[i+1]);
      }
      break;
    }
  }
  
  if (digitalRead(BOTAO) == LOW)
  {
    
  }
  delay(50);
}
