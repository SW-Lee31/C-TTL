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
  
  if (DlocY > 508)
  {
    digitalWrite(LED_R, HIGH);
    digitalWrite(LED_G, HIGH);
    digitalWrite(LED_B, HIGH);
  }
  
}
