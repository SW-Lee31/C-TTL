int joyrx = A4;
int joyry = A5;
int led_g = 6;
int led_r = 5;
int led_b = 4;
int sw = 2;
int joysw = 3;
boolean mode;

void setup() 
{
  Serial.begin(9600);   
  pinMode(sw, INPUT_PULLUP);
  pinMode(led_g, OUTPUT);
  pinMode(led_r, OUTPUT);
  pinMode(led_b, OUTPUT);
  
  attachInterrupt(digitalPinToInterrupt(sw), mode_change, FALLING);
}
void mode_change(){
    mode = !mode;
}

void loop() 
{
  if(mode == false)
  {
    digitalWrite(led_b, HIGH); // 수동 일때 파랑    
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
      Serial.println('B');
    }    
    else {
      Serial.println('S');
    }
  }
  
  else if (mode == true)
  {
    digitalWrite(led_g, HIGH); //자동 일떄 초록
    Serial.println('A');    
  }
}
