#include <WiFi.h>
#include <FirebaseESP32.h>
#include <LiquidCrystal.h>

/*#define WIFI_SSID "Vivo-Internet-BF17"
#define WIFI_PASSWORD "78814222"*/
#define WIFI_SSID "Galaxy A318713"
#define WIFI_PASSWORD "12345678"
#define FIREBASE_HOST "https://sensorldr-16e00-default-rtdb.firebaseio.com/"
#define FIREBASE_AUTH "FBpXnC9ZRg3Oqlc4eB5RgYt3ng5RziZqr8JkZ5F2"

#define LDR A0
#define LED 33

FirebaseData firebaseData;
FirebaseJson json;
LiquidCrystal lcd(13,12,14,27,26,25);


int readLDR(){
  int ldr = map(analogRead(LDR), 0, 4095, 0, 100);
  return ldr;
}


void setup() {
  Serial.begin(9600);
  
  WiFi.begin(WIFI_SSID, WIFI_PASSWORD);
  while(WiFi.status() != WL_CONNECTED)
  {
    Serial.print(".");
    delay(250);
  }
  
  Serial.print("Connected with IP: ");
  Serial.println(WiFi.localIP());

  Firebase.begin(FIREBASE_HOST, FIREBASE_AUTH);
  Firebase.reconnectWiFi(true);
  Firebase.setReadTimeout(firebaseData, 1000 * 60);
  Firebase.setwriteSizeLimit(firebaseData, "tiny");
  
  lcd.begin(16,2);

  pinMode(LED, OUTPUT);
}


void loop() {
  int ldr = readLDR();
  json.set("/luminosidade", ldr);

  digitalWrite(LED, HIGH);
  Firebase.updateNode(firebaseData, "/Sensor", json);
  digitalWrite(LED, LOW);
  
  Serial.print("Luz: ");
  Serial.print(ldr);
  Serial.println("%");

  lcd.clear();
  lcd.setCursor(0,0);
  lcd.print("Luz: ");
  lcd.print(ldr);
  lcd.print("%");
  
  delay(15000);
}
