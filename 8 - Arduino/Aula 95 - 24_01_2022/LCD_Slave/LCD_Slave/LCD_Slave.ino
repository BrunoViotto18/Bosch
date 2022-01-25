
#include <LiquidCrystal.h>
LiquidCrystal lcd(2,3,4,5,6,7);

String receivestring_ch;
String temp_ch;
String hum_ch;


void setup()
{
   lcd.begin(16, 2);
   Serial.begin(9600);
   Serial1.begin(9600);
}

void loop()
{

 while(Serial1.available()){ 
    delay(10);
    if (Serial1.available() >0) {
           char c = Serial1.read();                     // gets one byte from serial buffer
           receivestring_ch += c;                      // construct the recievestring_ch
       }
    }
    
 if (receivestring_ch.length() >0) {
     Serial.print("receivestring_ch = ");             
     Serial.println(receivestring_ch);                  

     temp_ch = receivestring_ch.substring(0, 4);   
     hum_ch = receivestring_ch.substring(5, 9); 

     receivestring_ch = ""; //  
     Serial.print("Temperatura = ");                       
     Serial.println(temp_ch);                  
     Serial.print("Humidade = ");                 
     Serial.println(hum_ch);               
     Serial.println();                   

     float temp = 0.00;                        
     float hum = 0.00;                     

     
     char carray1[6];                                  
     temp_ch.toCharArray(carray1, sizeof(carray1));
     temp = atof(carray1);
     
     char carray2[6];
     hum_ch.toCharArray(carray2, sizeof(carray2));
     hum = atof(carray2);

  {
  
 }

   lcd.setCursor(0, 0);
   lcd.print(temp, 2);
   
   lcd.setCursor(0, 1);     
   lcd.print(hum, 2);

   temp = 0;
   hum = 0;

   delay(1000);
  
}
}





  
