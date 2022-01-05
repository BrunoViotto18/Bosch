//Programa: Teste de Display LCD 16 x 2
//Autor: FILIPEFLOP
 
//Carrega a biblioteca LiquidCrystal
#include <LiquidCrystal.h>
 
//Define os pinos que serão utilizados para ligação ao display
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);
 
void setup()
{
  //Define o número de colunas e linhas do LCD
  lcd.begin(16, 2);
}
 
void loop()
{
  //Limpa a tela
  lcd.clear();
  //Posiciona o cursor na coluna 3, linha 0;
  lcd.setCursor(5, 0);
  //Envia o texto entre aspas para o LCD
  lcd.print("Bruhhno");
  lcd.setCursor(5, 1);
  lcd.print("Viotto");
  delay(5000);
   
  //Rolagem para a esquerda
  for (int posicao = 0; posicao < 5; posicao++)
  {
    lcd.scrollDisplayLeft();
    delay(300);
  }
   
  //Rolagem para a direita
  for (int posicao = 0; posicao < 9; posicao++)
  {
    lcd.scrollDisplayRight();
    delay(300);
  }
}
