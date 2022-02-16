#include <DHT.h>

#define DHTPIN 10
#define DHTTYPE DHT11

char temp_ch [10];
char hum_ch [10];
char sendstring_ch [10];

DHT dht(DHTPIN, DHTTYPE);

void setup() {
  dht.begin();
  Serial.begin(9600);
}

void loop() {
  
   float temp_fl = dht.readTemperature();
   float hum_fl = dht.readHumidity(); 

   dtostrf(temp_fl, 0, 2, temp_ch);                
   dtostrf(hum_fl, 0, 2, hum_ch);     

   strcat (sendstring_ch, temp_ch);                
   strcat (sendstring_ch, hum_ch); 
   
   Serial.print("sendstring_ch = ");
   Serial.println(sendstring_ch);

   memset(sendstring_ch, '\0', 10);               

delay(1000);


}      
