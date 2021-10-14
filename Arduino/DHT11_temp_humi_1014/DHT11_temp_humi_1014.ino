#include "DHT.h"
#define DHTPIN 2 // DHT11 pin 번호
#define DHTTYPE DHT11   // DHT 11
// define DHTTYPE DHT22
// define DHTTYPE DHT33
DHT dht(DHTPIN, DHTTYPE);

const int LED_R = 11;
const int LED_G = 10;
const int LED_B = 9;
String data;

void setup() {
  Serial.begin(4800);
  pinMode(LED_R, OUTPUT);
  pinMode(LED_G, OUTPUT);
  pinMode(LED_B, OUTPUT);
  
  Serial.println(F("온,습도 센서 시작"));
  digitalWrite(LED_R, HIGH);
  delay(500);
  digitalWrite(LED_R, LOW);
  delay(500);
  digitalWrite(LED_G, HIGH);
  delay(500);
  digitalWrite(LED_G, LOW);
  delay(500);
  digitalWrite(LED_B, HIGH);
  delay(500);
  digitalWrite(LED_B, LOW);
  
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
  
  if (t > 30){
    setColor(200, 0 ,0);
  }
  else if (t > 27){
    setColor(204, 102, 0);
  }
  else {
    setColor(0, 200, 0);
  }
}

void setColor(int red, int green, int blue){
  analogWrite(LED_R, red);
  analogWrite(LED_G, green);
  analogWrite(LED_B, blue);
}
