#define SW_pin 7
#define lastButtonState HIGH // 마지막 버튼 상태

boolean Buttonstate; // 현재 버튼 상태
long lastDebounceTIme = 0; // 마지막 버튼 디바운스 타임
long debounceDelay = 30;  // 디바운스 딜레이
int ledState; // LED 상태값

void setup() {
  // put your setup code here, to run once:

}

void loop() {
  int reading = digitalRead(SW_pin);
  if (reading != lastButtonState){
    lastDebountTime = millis(); // 버튼 입력정보가 HIGH랑 다를 시 (풀업 시에는 눌렀을 때)
    // millis (현재시간)을 lastDebountTIme에 저장
  }

  if ((millis() - lastDebounceTime) > debounceDelay){
    if (reading != buttonState){
      buttonState = reading;
      if (buttonState = LOW){
        ledState = !ledState;
        Serial.println("버튼 pressed");
      }
    }
  }
  digitalWrite(LED_R, ledState);
  lastButtonState = reading;

}
