int joyrx = A1;
int joyry = A0;
int sw = 2;
int ledg = 8;
int ledr = 9; 
boolean mode;

void setup() 
{
  Serial.begin(9600); 
  pinMode(ledg,OUTPUT);
  pinMode(ledr,OUTPUT);
  pinMode(sw, INPUT_PULLUP);
  attachInterrupt(digitalPinToInterrupt(sw), mode_change, FALLING);
}
void mode_change(){
    mode = !mode;
}

void loop() 
{
  if(mode == false)
  {
    Serial.write('P');
    digitalWrite(ledr, HIGH);
    if (analogRead(joyrx) <= 520 && analogRead(joyrx) >= 515 && analogRead(joyry) <= 515 && analogRead(joyry) >= 505){
      Serial.write('S');
    }
    else if (analogRead(joyry) >= 1000){
      Serial.write('R');
    }
    else if (analogRead(joyry) <= 20){
      Serial.write('L');
    }
    else if (analogRead(joyrx) >= 1000){
      Serial.write('F');
    }
    else if (analogRead(joyrx) <= 20){
      Serial.write('B');
    } 
  }
  else if (mode == true)
  {
    Serial.write('A');
    digitalWrite(ledr, LOW);
  }
}
