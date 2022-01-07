#include <LiquidCrystal.h>

byte GRAU[] = 
{
  B00000,
  B01110,
  B01010,
  B01110,
  B00000,
  B00000,
  B00000
};

LiquidCrystal lcd(12,11,5,4,3,2);

void setup() {
  lcd.begin(16,2);
  lcd.createChar(1, GRAU);
  lcd.home();
  lcd.write(1);
  Serial.begin(9600);
}

void loop() {
  
}
