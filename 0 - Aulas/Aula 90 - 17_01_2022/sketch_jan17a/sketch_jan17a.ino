#include <WiFi.h>
#include <PubSubClient.h>

/*
#define WIFI_SSID "Galaxy A318713"
#define WIFI_PASSWORD "12345678"
#define MQTT_SERVER "iot.eclipse.org"
#define MQTT_PORT 1883
#define MQTT_USER "Bruhhno"
#define MQTT_PASSWORD "Senha"
*/

const char* WIFI_SSID = "Galaxy A318713";
const char* WIFI_PASSWORD = "12345678";
const char* MQTT_SERVER = "iot.eclipse.org";
const int MQTT_PORT = 1883;
const char* MQTT_USER = "Bruhhno";
const char* MQTT_PASSWORD = "Senha";

WiFiClient espClient;
PubSubClient client(espClient);
  
int contador = 1;
char mensagem[30];

void setup() {
  Serial.begin(9600);
  WiFi.begin(WIFI_SSID, WIFI_PASSWORD);

  while (WiFi.status() != WL_CONNECTED)
  {
    Serial.print(".");
    delay(250);
  }
  Serial.println("\nConectado a rede WiFi!");
}

void loop() {
  // Conecta com o broker MQTT
  reconectarBroker();
  sprintf(mensagem, "MQTT ESP32 - Mensagem no. %d", contador);
  Serial.print("Mensagem enviada: ");
  Serial.println(mensagem);

  // Envia a mensagem para o broker
  client.publish("PasswordManager", mensagem);
  Serial.println();

  contador++;

  delay(1000);
}

void reconectarBroker()
{
  client.setServer(MQTT_SERVER, MQTT_PORT);
  while(!client.connected())
  {
    Serial.print(".");
    if (client.connect("ESP32Client", MQTT_USER, MQTT_PASSWORD))
    {
      Serial.println("\nConectado ao broker!");
    }
    else
    {
      Serial.print("\nFalha na conexão com o broker - Estado: ");
      Serial.println(client.state());
      delay(2000);
    }
  }
}
