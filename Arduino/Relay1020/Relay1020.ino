#define sw 3
#define rc  2

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(sw, INPUT);
  pinMode(rc, OUTPUT);
}

void loop() {
  if (digitalRead(sw) == LOW) // 스위치를 누른다
  {
    digitalWrite(rc, HIGH); // 릴레이 HIGH -> NO가 활성화
  }
  else
  {
     digitalWrite(rc, LOW); // 릴레이 LOW -> NC가 활성화 (평소상태)
  }
  
}
