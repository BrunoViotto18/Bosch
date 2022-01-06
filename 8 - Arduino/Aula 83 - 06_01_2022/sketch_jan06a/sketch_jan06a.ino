#include <LiquidCrystal.h>
#include <DHT.h>

const int TEMPERATURA = A0;
LiquidCrystal lcd(12,11,5,4,3,2);
DHT dht = DHT(13, DHT11);

void setup() {
  pinMode(TEMPERATURA, INPUT);
  lcd.begin(16,2);
  dht.begin();
  Serial.begin(9600);
}

void loop() {
  lcd.clear();
  lcd.setCursor(0,0);

  char string[17];
  lcd.print(dht.readTemperature());
  lcd.print("*C ");
  lcd.print(dht.readHumidity());
  lcd.print("%");

  Serial.print(2);//dht.readTemperature());
  Serial.print("ºC ");
  Serial.print(2);//dht.readHumidity());
  Serial.println("%");

  delay(100);
}
