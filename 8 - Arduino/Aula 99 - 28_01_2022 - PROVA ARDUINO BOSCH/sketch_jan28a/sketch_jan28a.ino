#include <WiFi.h>
#include <FirebaseESP32.h>
#include <LiquidCrystal.h>
#include <DHT.h>

#define WIFI_SSID "Galaxy A318713"
#define WIFI_PASSWORD "12345678"
#define FIREBASE_HOST "https://prova-6d5e2-default-rtdb.firebaseio.com/"
#define FIREBASE_AUTH "68bDCGviE2tihn432QMgsIeMLsMXg4g1Pxuydmt7"
#define DHTPIN 4
#define DHTTYPE DHT11

FirebaseData firebaseData;
FirebaseJson json;

LiquidCrystal lcd(13,12,14,27,26,25);
DHT dht(DHTPIN, DHTTYPE);

const int LED1 = 33;
const int LED2 = 32;
const int LED3 = 35;
const int LED4 = 34;
const int BOTAO = 2;

const int DELAY = 1;
bool interrupcao = false;


void Interrompido(){
  digitalWrite(LED1, LOW);
  digitalWrite(LED2, LOW);
  digitalWrite(LED3, LOW);
  digitalWrite(LED4, LOW);
    
  if (interrupcao){
    Serial.print("\n\nNão interrupto!\n\n");
    interrupcao = false;
  }
  else{
    Serial.print("\n\nInterrompido!\n\n");
    interrupcao = true;
  }

  while (interrupcao){
    delay(100);
  }
  
  return;
}


void setup() {
  // Inicializando o Serial
  Serial.begin(9600);

  // Conectando-se com a rede wifi
  WiFi.begin(WIFI_SSID, WIFI_PASSWORD);
  while (WiFi.status() != WL_CONNECTED)
  {
    Serial.print(".");
    delay(300);
  }
  
  // Print do IP da rede
  Serial.print("Connected with IP: ");
  Serial.println(WiFi.localIP());

  // Inicializando conexão com o banco de dados
  Firebase.begin(FIREBASE_HOST, FIREBASE_AUTH);
  Firebase.reconnectWiFi(true);
  Firebase.setReadTimeout(firebaseData, 1000 * 60);
  Firebase.setwriteSizeLimit(firebaseData, "tiny");

  // Inicializando o LCD
  lcd.begin(16,2);

  // Inicializando o DHT
  dht.begin();

  pinMode(BOTAO, INPUT);
  pinMode(LED1, OUTPUT);
  pinMode(LED2, OUTPUT);
  pinMode(LED3, OUTPUT);
  pinMode(LED4, OUTPUT);
  attachInterrupt(BOTAO, Interrompido, FALLING);
}

void loop() {
  // Lê a temperatura e a humidade
  float t = dht.readTemperature();
  float h = dht.readHumidity();

  // Seta um JSON com a temperatura e humidade
  json.set("/temperatura", t);
  json.set("/umidade", h);

  // Envia a temperatura e humidade para o FireBase
  digitalWrite(LED4, HIGH);
  Firebase.updateNode(firebaseData, "/Sensor", json);
  digitalWrite(LED4, LOW);

  Serial.print("Temperatura: ");
  Serial.print(t);
  Serial.println("*C");
  Serial.print("Umidade: ");
  Serial.print(h);
  Serial.println("%");
  Serial.print('\n');

  // Acende LEDS específicos de acordo com a temperatura
  if (t <= 25){
    Serial.println("LED1");
    digitalWrite(LED1, HIGH);
    digitalWrite(LED2, LOW);
    digitalWrite(LED3, LOW);
  }
  else if (t < 27){
    Serial.println("LED2");
    digitalWrite(LED1, LOW);
    digitalWrite(LED2, HIGH);
    digitalWrite(LED3, LOW);
  }
  else{
    Serial.println("LED3");
    digitalWrite(LED1, LOW);
    digitalWrite(LED2, LOW);
    digitalWrite(LED3, HIGH);
  }

  // Printa a temperatura e humidade do DHT no LCD
  // Temperatura
  lcd.clear();
  lcd.setCursor(0,0);
  lcd.print("Temp: ");
  lcd.print(t);
  lcd.print("*C");
  
  // Humidade
  lcd.setCursor(0,1);
  lcd.print("Umidade: ");
  lcd.print(h);
  lcd.print("%");

  delay(30000);
}
