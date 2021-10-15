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

void setup() {
  Serial.begin(9600);
  pinMode(LED_R, OUTPUT);
  pinMode(LED_G, OUTPUT);
  pinMode(LED_B, OUTPUT);
  pinMode(BUZ, OUTPUT);
  
  Serial.println(F("온,습도 센서 시작"));
  Serial.println("조도 센서 시작");
  
  dht.begin();
}

void loop() {
  delay(2000);
  float h = dht.readHumidity();
  float t = dht.readTemperature();

  if (isnan(h) || isnan(t)) {
    Serial.println(F("Failed to read from DHT sensor!"));
    return;
  } // 오류 처리 (제대로 된 값이 안 들어온 경우) isnan ->  숫자정보가 아님.

  float hic = dht.computeHeatIndex(t, h, false);

  /* Serial.print(F("습도: "));
  Serial.print(h);
  Serial.print(F("%  온도: "));
  Serial.print(t);
  Serial.println(F("℃"));
  */

  // UI에 정보 송신 양식(파싱)  -> [라인번호/온도/습도]
  Serial.print("[1/");
  Serial.print(t);
  Serial.print("/");
  Serial.print(h);
  Serial.print("]");
  Serial.print("[2/");
  Serial.print(t + 6);
  Serial.print("/");
  Serial.print(h + 7);
  Serial.println("]");
  
  int CDS_val = analogRead(CDS);
  Serial.print("조도 값 : ");
  Serial.println(CDS_val);

  if (CDS_val >= 400){
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
