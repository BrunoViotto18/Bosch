#include <LiquidCrystal.h>
#include <DHT.h>

LiquidCrystal lcd(13,12,14,27,25,33);

DHT dht(35, DHT11);

int PIR = 32;
int TEMP = 22;

void setup() {
  lcd.begin(16,2);
  dht.begin();
  pinMode(PIR, INPUT);
  pinMode(TEMP, INPUT);
}

void loop() {
  lcd.clear();
  lcd.setCursor(0,0);

  lcd.write("MOV:");
  if (digitalRead(PIR) == HIGH)
  {
    lcd.write("ON");
  }
  else
  {
    lcd.print("OFF");
  }

  lcd.setCursor(9,0);
  lcd.write("Temp:");
  float temp = dht.readHumidity();
  lcd.print(temp);
  
  delay(100);
}
