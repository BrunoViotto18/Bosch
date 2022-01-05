int DISPLAY_LED[] = {2, 3, 4, 5, 6, 7, 8, 9};
int BOTAO = 10;
int LED = 11;

int CARACTERE_d[] = {0, 1, 1, 1, 1, 0, 1, 0};
int CARACTERE_H[] = {0, 1, 1, 0, 1, 1, 1, 0};
int CARACTERE_I[] = {0, 1, 1, 0, 0, 0, 0, 0};
int CARACTERE_L[] = {0, 0, 0, 1, 1, 1, 0, 0};
int CARACTERE_O[] = {0, 0, 1, 1, 1, 0, 1, 0};
int CARACTERE_t[] = {0, 0, 0, 1, 1, 1, 1, 0};

void printCaractereDisplay(int* caractere)
{
  for (int i = 0; i < 8; i++)
  {
    digitalWrite(DISPLAY_LED[i], caractere[i]);
  }
}

void setup() {
  for (int i = 0; i < 8; i++)
  {
    pinMode(DISPLAY_LED[i], OUTPUT);
  }
  pinMode(BOTAO, INPUT_PULLUP);
  pinMode(LED, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  if (digitalRead(BOTAO) == LOW)
  {
    printCaractereDisplay(CARACTERE_L);
    digitalWrite(LED, HIGH);
  }
  else
  {
    printCaractereDisplay(CARACTERE_d);
    digitalWrite(LED, LOW);
  }
}
