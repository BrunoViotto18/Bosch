#include <BLEDevice.h> 
#include <BLEServer.h> 
#include <BLEUtils.h> 
#include <BLE2902.h>
#include <LiquidCrystal.h>

// Constantes para a biblioteca Bluetooth
#define SERVICE_UUID "ab8028b1-198e-4351-b779-901fa0e03715" 
#define CHARACTERISTIC_UUID_RX "4aca9682-9736-4e5d-932b-e9b314050495"
#define CHARACTERISTIC_UUID_TX "0972128C-7613-4075-AD52-756F33D4DA95"

// Número de contas no sistema
#define CONTAS 3


// Inicializando biblioteca Bluetooth
BLECharacteristic *characteristicTX;
bool deviceConnected = false;

// Inicializando o LCD e 2 pinos
LiquidCrystal lcd(13,12,14,27,26,25);
int POTENC = 33;
int BOTAO = 32;

// Contas
String website[CONTAS] = {"Gmail", "Github", "Youtube"};
String email[CONTAS] = {"industriaquatro.0@gmail.com", "industriaquatro.0@gmail.com", "teste@gmail.com"};
String senha[CONTAS] = {"senhaGmail", "senhaGithub", "senhaYoutube"};
String VetorMain[CONTAS][3] = {website, email, senha};
int opcao = 0;

// LED do ESP32
const int LED = 2;


// Classes da biblioteca bluetooth
class ServerCallbacks: public BLEServerCallbacks {
  void onConnect (BLEServer* pServer){
    deviceConnected = true;
  };

  void onDisconnect(BLEServer* pServer){
    deviceConnected = false;
  }
};


class CharacteristicCallbacks: public BLECharacteristicCallbacks{
  void onWrite(BLECharacteristic* characteristic){

    std:: string rxValue = characteristic->getValue();

    if (rxValue.length()>0)
    {
      Serial.println("*******");
      Serial.print("Received Value: ");

      for (int i = 0; i < rxValue.length(); i++)
      {
      Serial.print(rxValue[i]);
      }
    
      Serial.println();

      if (rxValue.find("L1") != -1)
      {
       Serial.print("Turning Led on!");
       digitalWrite(LED, HIGH);
      }
      else if (rxValue.find("L0")!= -1)
      {
        Serial.print("Turining LED OFF");
        digitalWrite(LED, LOW);
      }
      
      Serial.println();
      Serial.println("*********");
    }
  }
};


void setup() {
  Serial.begin(9600);
  BLEDevice::init("Bruno");

  lcd.begin(16, 2);
  pinMode(BOTAO, INPUT_PULLUP);

  BLEServer*server = BLEDevice::createServer();
  server -> setCallbacks (new ServerCallbacks());
  BLEService*service = server->createService(SERVICE_UUID);

  characteristicTX = service->createCharacteristic(
  CHARACTERISTIC_UUID_TX,
  BLECharacteristic::PROPERTY_NOTIFY
  );

  BLECharacteristic * characteristic = service->createCharacteristic(CHARACTERISTIC_UUID_RX,
  BLECharacteristic::PROPERTY_WRITE
  );

  characteristic ->setCallbacks(new CharacteristicCallbacks());

  service->start();
  server->getAdvertising()->start();

  Serial.println("Waiting a Client connection to notify...");
}


void loop() {
  opcao = analogRead(POTENC);

  int i;
  for(i = 0; i < CONTAS; i++)
  {
    if(opcao <= (1023*4 / CONTAS * (i+1)))
    {
      lcd.clear();
      lcd.setCursor(0,0);
      lcd.write("> ");
      lcd.print(website[i]);
      if(i != CONTAS-1)
      {
        lcd.setCursor(0,1);
        lcd.write("  ");
        lcd.print(website[i+1]);
      }
      break;
    }
  }
  
  if (digitalRead(BOTAO) == LOW)
  {
    if (deviceConnected)
    {
      char* txStringEmail = (char*)malloc(sizeof(char) * email[i].length()+1);
      for (int j = 0; j < email[i].length(); j++)
      {
        txStringEmail[j] = email[i].charAt(j);
      }
      txStringEmail[email[i].length()] = '\0';
      
      char* txStringSenha = (char*)malloc(sizeof(char) * senha[i].length()+1);
      for (int j = 0; j < senha[i].length(); j++)
      {
        txStringSenha[j] = senha[i].charAt(j);
      }
      txStringSenha[senha[i].length()] = '\0';
      
      characteristicTX -> setValue(txStringEmail);
      characteristicTX ->notify();
      Serial.println(txStringEmail);
      
      while(digitalRead(BOTAO) != LOW)
      {
        delay(100);
      }
      
      characteristicTX -> setValue(txStringSenha);
      characteristicTX ->notify();
      Serial.println(txStringSenha);

      free(txStringEmail);
      free(txStringSenha);
    }
    delay(1000);
  }
  delay(10);
}
