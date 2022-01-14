#include <WiFi.h>
#include <FirebaseESP32.h>
#include <DHT.h>

/*#define WIFI_SSID "Vivo-Internet-BF17"
#define WIFI_PASSWORD "78814222"*/
#define WIFI_SSID "Galaxy A318713"
#define WIFI_PASSWORD "12345678"
#define FIREBASE_HOST "https://dsmod3-default-rtdb.firebaseio.com/"
#define FIREBASE_AUTH "4k6JNrElbIda17kE2eqdhFayrlY8yuMU9lcKKBBE"

FirebaseData firebaseData;
FirebaseJson json;

DHT dht(34, DHT11);

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
}

void loop() {
  float t = dht.readTemperature();
  float h = dht.readHumidity();
  json.set("/temperatura", t);
  json.set("/umidade", h);
  Firebase.updateNode(firebaseData, "Sensor/Bruno", json);
  Serial.println("Loop");
}
