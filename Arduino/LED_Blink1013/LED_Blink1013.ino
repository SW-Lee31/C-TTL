// LED blink

// 장치 초기화
void setup() {
  // PinMode : OUTPUT -> 출력 / INPUT -> 입력
  // LED_BUILTIN -> 이미 상수변수로 선언돼있음 (핀13 LED)

  // 시리얼통신을 위한 세팅
  Serial.begin(9600);     // 통신시작 및 속도설정(9600보레이트)
  
  // 핀모드 : 13핀을 출력으로 세팅함.
  pinMode(LED_BUILTIN, OUTPUT);
}

// Loop : 무한루프 동작
void loop() {
  digitalWrite(LED_BUILTIN, HIGH);   // digitalwrite(핀13 LED, HIGH신호로 write(1))
  Serial.println("LED On");
  delay(1000);                       
  digitalWrite(LED_BUILTIN, LOW);    
  Serial.println("LED Off");
  delay(1000);                       
}
