#include <MsTimer2.h>
#include "DHT.h"

#define DHTPIN 8 // DHT11 pin 번호
#define DHTTYPE DHT11   // DHT 11
// define DHTTYPE DHT22
// define DHTTYPE DHT33
DHT dht(DHTPIN, DHTTYPE);

const int CDS = A0; // A0에 조도센서 연결

const int BUZ = 7;

const int LED_R = 11;
const int LED_G = 10;
const int LED_B = 9;
String data;
volatile bool ledState = true;  
// 인터럽트(MsTimer)에서는 빠른 동작으로 처리되고 빠져나가야 함 (캐시메모리 활용)
// 그 때 사용하는 데이터타입이 volatile임 -> 항상 메모리 접근 (캐시메모리 활용 X) 
volatile int tick = 0;
// 인터럽트에는 volatile를 써주자!

void setup() {
  Serial.begin(9600);
  pinMode(LED_R, OUTPUT);
  pinMode(LED_G, OUTPUT);
  pinMode(LED_B, OUTPUT);
  pinMode(BUZ, OUTPUT);
  
  Serial.println(F("온,습도 센서 시작"));
  Serial.println("조도 센서 시작");

  MsTimer2::set(1000, timerISR);
  MsTimer2::start();
  
  dht.begin();
}

void loop() {
  delay(2000);

  readDHT11();
  
  if (readCDS() >= 400){
    setColor(125, 125, 125);
    digitalWrite(BUZ, HIGH);
    delay(200);
    digitalWrite(BUZ, LOW);
    delay(200);
    digitalWrite(BUZ, HIGH);
    delay(200);
    digitalWrite(BUZ, LOW);
  }
  else {
    setColor(0, 0, 0);
  }

   if (tick == 10){
    ledState = !ledState;
    digitalWrite(LED_B, ledState);
    tick = 0;
  } 
}

void setColor(int red, int green, int blue){
  analogWrite(LED_R, red);
  analogWrite(LED_G, green);
  analogWrite(LED_B, blue);
}

void setSound(double Octv){
  tone(BUZ, Octv);
  delay(300);
}

void timerISR(){
  tick++;
}
