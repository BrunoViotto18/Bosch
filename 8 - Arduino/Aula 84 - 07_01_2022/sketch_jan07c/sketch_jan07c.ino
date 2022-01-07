#include <LiquidCrystal.h>

byte PLAYER[] = 
{
  B01110,
  B01110,
  B00100,
  B11111,
  B00100,
  B01110,
  B01010,
  B01010
};

byte DEAD[] = 
{
  B00000,
  B00000,
  B00000,
  B00000,
  B00000,
  B00000,
  B00000,
  B00000
};

byte SHOT[] = 
{
  B00000,
  B00000,
  B01110,
  B11111,
  B11111,
  B01110,
  B00000,
  B00000
};

byte CANNON1[] = 
{
  B00000,
  B00011,
  B00111,
  B01111,
  B01111,
  B00111,
  B00011,
  B00010
};

byte CANNON2[] = 
{
  B00000,
  B11111,
  B11110,
  B11110,
  B11110,
  B11110,
  B11111,
  B00010
};

int mapa[2][16] = 
{
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
  {4,5,0,0,0,0,0,3,0,0,0,0,0,0,1,0}
};

int BOTAO = 6;
LiquidCrystal lcd(12,11,5,4,3,2);

void printMapa()
{
  for (int i = 0; i < 2; i++)
  {
    lcd.setCursor(0,i);
    for (int j = 0; j < 16; j++)
    {
      if (mapa[i][j] == 0)
      {
        lcd.write(" ");
      }
      else
      {
        lcd.write(mapa[i][j]);
      }
    }
  }
}

void setup() {
  pinMode(BOTAO, INPUT_PULLUP);
  lcd.begin(16,2);
  lcd.createChar(1, PLAYER);
  lcd.createChar(2, DEAD);
  lcd.createChar(3, SHOT);
  lcd.createChar(4, CANNON1);
  lcd.createChar(5, CANNON2);
  lcd.clear();
  Serial.begin(9600);
}

int tick = 10;
void loop() {
  // Se botao for apertado
  if (digitalRead(BOTAO) == LOW && botaoFlag == 0)
  {
    if (mapa[1][14] == 1)
    {
      mapa[0][14] = 1;
      mapa[1][14] = 0;
    }
    else
    {
      mapa[0][14] = 0;
      mapa[1][14] = 1;
    }
    botaoFlag = 100/tick;
  }

  // Printa o mapa na tela
  printMapa();

  // Delay do botao
  if (botaoFlag > 0)
  {
    botaoFlag -= tick;
  }

  // Delay dos ticks
  delay(tick);
}
