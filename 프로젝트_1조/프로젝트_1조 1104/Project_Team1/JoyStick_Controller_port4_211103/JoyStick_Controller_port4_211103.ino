int joyrx = A4;
int joyry = A5;
int led_g = 6;
int led_r = 5;
int led_b = 4;
int sw = 2;
int joysw = 3;
boolean mode;
boolean ma_ac;

void setup() 
{
  Serial.begin(9600);   
  pinMode(sw, INPUT_PULLUP);
  pinMode(joysw, INPUT_PULLUP);
  pinMode(led_g, OUTPUT);
  pinMode(led_r, OUTPUT);
  pinMode(led_b, OUTPUT);
  
  attachInterrupt(digitalPinToInterrupt(sw), mode_change, FALLING);
}

void mode_change()
{
    mode = !mode;
}
void machaine_activate()
{
    ma_ac = !ma_ac;
}

void loop() 
{
  if(mode == false)
  {
    if (ma_ac == false){
      digitalWrite(led_r, LOW);
      digitalWrite(led_g, LOW);
      digitalWrite(led_b, HIGH);// 수동 일때 파랑    
      if (analogRead(joyry) >= 1000){
        Serial.println('R');
      }
      else if (analogRead(joyry) <= 20){
       Serial.println('L');
      }
      else if (analogRead(joyrx) >= 1000){
        Serial.println('F');
      }
      else if (analogRead(joyrx) <= 20){
        machaine_activate();
      }  
      else {
        Serial.println('S');
      }
    }

    else if (ma_ac == true){
        digitalWrite(led_r, HIGH);
        digitalWrite(led_g, LOW);
        digitalWrite(led_b, LOW);// 지게 동작 시 빨강
        Serial.println('M');
        delay(1000);
        ma_ac = false;
      }
    
  }
  
  else if (mode == true)
  {
    digitalWrite(led_r, LOW);
    digitalWrite(led_g, HIGH);
    digitalWrite(led_b, LOW); //자동 일떄 초록
    Serial.println('A');    
  }

}
