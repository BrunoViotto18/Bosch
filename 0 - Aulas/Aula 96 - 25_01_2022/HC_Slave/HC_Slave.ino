//Armazena o caracter recebido
char buf;
int LED = 13;
 
void setup()
{
  //Define o pino 13 como saida
  pinMode(LED, OUTPUT);
  Serial.begin(115200);
  Serial1.begin(38400);
}

void loop()
{
  while(Serial1.available() > 0)
  {
    buf = Serial1.read();
    //Caso seja recebido o caracter L, acende o led
    if (buf == 'L')
    {
      digitalWrite(LED, HIGH);
    }
    //Caso seja recebido o caracter D, apaga o led
     if (buf == 'D')
    {
      digitalWrite(LED, LOW);
    }
  }
}
