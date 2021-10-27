#define trig 9
#define echo 8
#define buz 7
#define led_r 6
#define led_g 5
#define led_b 4

long duration; 
long distance;

void setup() {
  Serial.begin(9600);
  pinMode(trig, OUTPUT);
  pinMode(echo, INPUT);
  pinMode(buz, OUTPUT);
  pinMode(led_r, OUTPUT);
  pinMode(led_g, OUTPUT);
  pinMode(led_b, OUTPUT);
}

void loop() {
  // 신호 초기화
  digitalWrite(trig, LOW);
  delayMicroseconds(2);

  digitalWrite(trig, HIGH);
  delayMicroseconds(10);
  digitalWrite(trig, LOW);

  // pulsein() 함수 사용 -> echo가 HIGH인 상태 um로 반환
  duration = pulseIn(echo, HIGH);
  // 거리 반환 계산 식 -> cm로 반환
  distance = (duration * 17) / 1000;

  Serial.print("거리 : ");
  Serial.print(distance);
  Serial.println("cm");

  if (distance < 10){
    setColor(true, false, false);
    beep();
  }
  else if (distance < 30){
    setColor(true, true, false);
  }
  else if (distance < 50){
    setColor(false, false, true);
  }
  
  
  delay(300);
}

void beep(){
  tone(buz, 300, 100);
}

void setColor(boolean red, boolean green, boolean blue){
  digitalWrite(led_r, red);
  digitalWrite(led_g, green);
  digitalWrite(led_b, blue);
}
