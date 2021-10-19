int SWITCH = 4;
int LED_R = 11;
int LED_G = 10;
int LED_B = 9;


void setup() {
  Serial.begin(9600);
  pinMode(SWITCH, INPUT);
  pinMode(LED_R, OUTPUT);
  pinMode(LED_G, OUTPUT);
  pinMode(LED_B, OUTPUT);
}

void loop() {
  bool sw_val = digitalRead(SWITCH);
  
  if (sw_val){
    setColor(0, 0, 0);
  }
  else{
    setColor(125, 0, 125);
  }
}

void setColor(int red, int green, int blue){
  analogWrite(LED_R, red);
  analogWrite(LED_G, green);
  analogWrite(LED_B, blue);
}
