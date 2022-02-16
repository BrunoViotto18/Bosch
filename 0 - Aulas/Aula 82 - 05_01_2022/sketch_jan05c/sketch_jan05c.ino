/*#include <LiquidCrystal.h>

LiquidCrystal lcd(12, 11, 5, 4, 3, 2);

void setup() {
  lcd.begin(16, 2);
  lcd.clear();
  lcd.setCursor(0,0);
  lcd.print("Hello");
  lcd.setCursor(0,1);
  lcd.print("World!");
  // put your setup code here, to run once:

}

void loop() {
  lcd.setCursor(0,0);
  lcd.print("Hello");
  lcd.setCursor(0,1);
  lcd.print("World!");
  // put your main code here, to run repeatedly:

}*/

/*
#include <LiquidCrystal.h>
 
//Define os pinos que serão utilizados para ligação ao display
LiquidCrystal lcd(12, 11, 6, 5, 4, 3);
 
void setup()
{
  //Define o número de colunas e linhas do LCD
  lcd.begin(16, 2);
  lcd.setCursor(0,0);
}

void loop()
{
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("Subindo");
  delay(2000);
  lcd.clear();
  lcd.setCursor(0, 1);
  lcd.print("Descendo");
  delay(2000);
  
  /*lcd.print(" LCD 16x2");
  delay(5000);
  //Rolagem para a esquerda
  for (int posicao = 0; posicao < 3; posicao++)
  {
    lcd.scrollDisplayLeft();
    delay(300);
  } 
  //Rolagem para a direita
  for (int posicao = 0; posicao < 6; posicao++)
  {
    lcd.scrollDisplayRight();
    delay(300);
  }*/


#include <LiquidCrystal.h>
 
//Define os pinos que serão utilizados para ligação ao display
LiquidCrystal lcd(12, 11, 6, 5, 4, 3);
int pot = 0; 
void setup()
{
  //Define o número de colunas e linhas do LCD
  lcd.begin(16, 2);
  lcd.setCursor(0,0);
}

void loop()
{
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print(analogRead(pot));
  delay(50);
}
