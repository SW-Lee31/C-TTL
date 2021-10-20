#define LOC_X A0
#define LOC_Y A1
#define LED_R 11
#define LED_G 10
#define LED_B 9
#define BUZ 8
#define SW_pin 2
#define debounceTime 100

volatile boolean led_buz_state;

/* int lastButtonState = LOW;
boolean Buttonstate;
long lastDebounceTime = 0;
long debounceDelay = 30; */

void setup() {
  Serial.begin(9600);

  pinMode(SW_pin, INPUT_PULLUP);
  pinMode(LOC_X, INPUT);
  pinMode(LOC_Y, INPUT);
  pinMode(BUZ, OUTPUT);
  pinMode(LED_R, OUTPUT);
  pinMode(LED_G, OUTPUT);
  pinMode(LED_B, OUTPUT);
  attachInterrupt(digitalPinToInterrupt(SW_pin), peep, FALLING);
}

void peep(){
  long lastTime = 0;
  long nowTime = millis();

  if ((nowTime - lastTime) - debounceTime){
     led_buz_state = !led_buz_state;
  }
  lastTime = nowTime;
}

void loop() {
  int locationX = analogRead(LOC_X);
  int locationY = analogRead(LOC_Y);
  int DlocX = locationX - 506;
  int DlocY = 0;
  if (locationY < 511)
  {
    DlocY = 511 - locationY;
  }
  else if (locationY > 511)
  {
    DlocY = -(locationY - 511);
  }


  /* boolean SWreading = digitalRead(SW_pin);
  
  if (SWreading != lastButtonState){
    lastDebounceTime = millis(); // 버튼 입력정보가 HIGH랑 다를 시 (풀업 시에는 눌렀을 때) millis (현재시간)을 lastDebountTIme에 저장
  }

  if ((millis() - lastDebounceTime) > debounceDelay){
    if (SWreading != Buttonstate){
      Buttonstate = SWreading;
      if (Buttonstate = HIGH){
        Serial.println("버튼 pressed");
        digitalWrite(LED_R, Buttonstate);
        digitalWrite(LED_G, Buttonstate);
        digitalWrite(LED_B, Buttonstate);
        lastButtonState = HIGH;
      }
    }
  }
  
  lastButtonState = SWreading; */
  
  Serial.print(DlocX);
  Serial.print(" / ");
  Serial.print(DlocY);
  Serial.print(" / ");
  Serial.println(digitalRead(led_buz_state));
  // digitalWrite(BUZ, led_buz_state);
  digitalWrite(LED_R, led_buz_state);
  digitalWrite(LED_B, led_buz_state);
  digitalWrite(LED_G, led_buz_state);
  
  if ((DlocX > -15 && DlocX < 5) && DlocY > 508){
    setColor(0, 125, 125);
  }
  else if ((DlocX > -5 && DlocX < 5) && (DlocY > -5 && DlocY < 5)){
    digitalWrite(LED_R, led_buz_state);
    digitalWrite(LED_B, led_buz_state);
    digitalWrite(LED_G, led_buz_state);
  }
  else if (DlocX < -505 && DlocY > 508){
    setColor(125, 0, 125);
  }
  else if (DlocX < -505 && (DlocY < 5 && DlocY > -10)){
    setColor(125, 125, 0);
  }
  else if (DlocX < -505 && DlocY < -11){
    setColor(75, 125, 50);
  }
  else if (DlocX < -505 && DlocY > 0){
    setColor(87, 33, 87);
  }
  else if ((DlocX > -505 && DlocX < 0) && DlocY > 0){
    setColor(88, 125, 88);
  }
  else if ((DlocX > -505 && DlocX < 3) && DlocY < 0){
    setColor(125, 125, 0);
  }
  else if (DlocX > 3 && DlocY < -100){
    setColor(30, 125, 150);
  }
  else if (DlocX > 3 && (DlocY > -100 && DlocY < 100)){
    setColor(99, 0, 77);
  }
  else if (DlocX > 3 && DlocY > 100){
    setColor(93, 77, 111);
  }
}

void setColor(int red, int green, int blue){
  analogWrite(LED_R, red);
  analogWrite(LED_G, green);
  analogWrite(LED_B, blue);
}
