#include <Wire.h>
#include <LiquidCrystal_I2C.h>

String inputString = "";         // string to przetrzymywania przychodzących danych
boolean stringComplete = false;  // czy string jest gotowy  
String commandString = "";

int led1Pin = 19;
int led2Pin = 20;
int led3Pin = 21;

boolean isConnected = false;

LiquidCrystal_I2C lcd(0x27, 2, 1, 0, 4, 5, 6, 7, 3, POSITIVE); //Tworzymy obiekt z parametrami lcd. first is I squared C adress, rest are pin assignments for PC


void setup() {
  
  Serial.begin(9600);
  initDisplay();
}

void loop() {

if(stringComplete)
{
  stringComplete = false;
  getCommand();
  
  if(commandString.equals("STAR"))
  {
    lcd.clear();
  }
  if(commandString.equals("STOP"))
  {
    lcd.clear();
    lcd.print("Ready to connect");    
  }
  else if(commandString.equals("TEXT"))
  {
    String text = getTextToPrint();
    printText(text);
  }
  
  inputString = "";
}

}

void initDisplay()
{
  lcd.begin(16, 2);
  lcd.print("Ready to connect");
}



void getCommand()
{
  if(inputString.length()>0)
  {
     commandString = inputString.substring(1,5);
  }
}

String getTextToPrint()
{
  String value = inputString.substring(5,inputString.length()-2);
  return value;
}

void printText(String text)
{
  lcd.clear();
  lcd.setCursor(0,0);
    if(text.length()<16)
    {
      lcd.print(text);
    }else
    {
      lcd.print(text.substring(0,16));
      lcd.setCursor(0,1);
      lcd.print(text.substring(16,32));
    }
}

void serialEvent() {
  while (Serial.available()) {
    // pobranie bajtu
    char inChar = (char)Serial.read();
    // dodanie bajtu do reszty
    inputString += inChar;
    // Jeśli przyhcodzący charakter to znak nowej lini to zaznaczamy, że jest koniec stringa
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}
