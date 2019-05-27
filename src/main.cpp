#include <Arduino.h>

/*
START MOTORE DIREZIONE VELOCITA
STOP MOTORE
STOP

TIMED MOTORE DIREZIONE VELOCITA TEMPO
*/


// pinnatura motori (non siam sicuri siano giusti, modificarli a piacere)

#define A_UP 2
#define A_DOWN 3

#define B_UP 5
#define B_DOWN 4

#define C_UP 6
#define C_DOWN 7

#define D_UP 8
#define D_DOWN 9

#define E_UP 10
#define E_DOWN 11

void setup()
{

  // init
  Serial.begin(9600);

  for (size_t i = 2; i < 13; i++)
  {
    pinMode(i, OUTPUT);
  }

 // Serial.println("OK");
}

String getSerialData()
{
  Serial.println("OK");
  while (Serial.available() == 0)
  {
    ;
  }
  return Serial.readString();
}

void avviaMotore(String motore, String direz, int speed)
{
  if (motore == "A")
  {
    if (direz == "OPEN")
    {
      analogWrite(A_UP, speed);
    }

    if (direz == "CLOSE")
    {
      analogWrite(A_DOWN, speed);
    }
  }

  if (motore == "B")
  {
    if (direz == "UP")
    {
      analogWrite(B_UP, speed);
    }

    if (direz == "DOWN")
    {
      analogWrite(B_DOWN, speed);
    }
  }
  if (motore == "C")
  {
    if (direz == "UP")
    {
      analogWrite(C_UP, speed);
    }

    if (direz == "DOWN")
    {
      analogWrite(C_DOWN, speed);
    }
  }
  if (motore == "D")
  {
    if (direz == "UP")
    {
      analogWrite(D_UP, speed);
    }

    if (direz == "DOWN")
    {
      analogWrite(D_DOWN, speed);
    }
  }
  if (motore == "E")
  {
    if (direz == "LEFT")
    {
      analogWrite(E_UP, speed);
    }

    if (direz == "RIGHT")
    {
      analogWrite(E_DOWN, speed);
    }
  }
}

void fermaMotori() {
  for(size_t i = 2; i < 13; i++)
  {
    analogWrite(i, 0);
  }
  
}

void fermaMotore(String motore)
{
  if (motore == "A")
  {
    analogWrite(A_UP, 0);
    analogWrite(A_DOWN, 0);
  }

  if (motore == "B")
  {
    analogWrite(B_DOWN, 0);
    analogWrite(B_UP, 0);
  }
  if (motore == "C")
  {
    analogWrite(C_DOWN, 0);
    analogWrite(C_UP, 0);
  }
  if (motore == "D")
  { 
    analogWrite(D_DOWN, 0);
    analogWrite(D_UP, 0);
  }
  if (motore == "E")
  {
    analogWrite(E_DOWN, 0);
    analogWrite(E_UP, 0);
  }
}

void loop()
{
  // attendi input utente nel formato MOTORE;DIREZIONE;TEMPO(ms);VELOCITA(0-100)
  String input = getSerialData();
  input.replace("\n", "");
  char *inputC = (char *)malloc(input.length() * sizeof(char) + 1);
  strcpy(inputC, input.c_str());

  char *delim = " ";

  String command = String(strtok(inputC, delim));

  // split della stringa alla c
  String motore = String(strtok(NULL, delim));
  motore.replace("\n", "");

  Serial.println(command + " " + motore);

  if (command == "TIMED")
  {

    String direz = String(strtok(NULL, delim));

    int velocita = String(strtok(NULL, delim)).toInt();

    // mappa velocita da 0-100 a 0-255
    velocita = map(velocita, 0, 100, 0, 255);

    int tempo = String(strtok(NULL, delim)).toInt();

    // debug
    Serial.println(motore + " " + direz + " " + String(tempo) + " " + String(velocita));

    // scegli motore
    if (motore == "A")
    {
      // scegli direzione
      if (direz == "OPEN")
      {
        // attiva motore con velocita assegnata
        analogWrite(A_UP, velocita);
        // aspetta
        delay(tempo);
        // spegni motore
        analogWrite(A_UP, 0);
      }

      if (direz == "CLOSE")
      {

        analogWrite(A_DOWN, velocita);
        delay(tempo);
        analogWrite(A_DOWN, 0);
      }
    }

    // leggi sopra
    if (motore == "B")
    {

      if (direz == "UP")
      {

        analogWrite(B_UP, velocita);
        delay(tempo);
        analogWrite(B_UP, 0);
      }

      if (direz == "DOWN")
      {

        analogWrite(B_DOWN, velocita);
        delay(tempo);
        analogWrite(B_DOWN, 0);
      }
    }

    if (motore == "C")
    {

      if (direz == "UP")
      {

        analogWrite(C_UP, velocita);
        delay(tempo);
        analogWrite(C_UP, 0);
      }

      if (direz == "DOWN")
      {

        analogWrite(C_DOWN, velocita);
        delay(tempo);
        analogWrite(C_DOWN, 0);
      }
    }

    if (motore == "D")
    {

      if (direz == "UP")
      {

        analogWrite(D_UP, velocita);
        delay(tempo);
        analogWrite(D_UP, 0);
      }

      if (direz == "DOWN")
      {

        analogWrite(D_DOWN, velocita);
        delay(tempo);
        analogWrite(D_DOWN, 0);
      }
    }

    if (motore == "E")
    {

      if (direz == "UP")
      {

        analogWrite(E_UP, velocita);
        delay(tempo);
        analogWrite(E_UP, 0);
      }

      if (direz == "DOWN")
      {

        analogWrite(E_DOWN, velocita);
        delay(tempo);
        analogWrite(E_DOWN, 0);
      }
    }
  }

  if (command == "START")
  {
    String direz = String(strtok(NULL, delim));

    int velocita = String(strtok(NULL, delim)).toInt();

    // mappa velocita da 0-100 a 0-255
    velocita = map(velocita, 0, 100, 128, 255);
    avviaMotore(motore, direz, velocita);
  }

  if (command == "STOP")
  {
    if(input == "STOP") {
      fermaMotori();
      return;
    }
    fermaMotore(motore);
  }
}
