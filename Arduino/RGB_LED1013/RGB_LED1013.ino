const int LED_R = 4;  // LED red에 핀4 연결
const int LED_G = 3;  // LED green에 핀3 연결
const int LED_B = 2;  // LED blue에 핀2 연결

void setup() 
{
 pinMode(LED_R, OUTPUT);  //핀4(LED red)를 출력으로 설정
 pinMode(LED_G, OUTPUT);  //핀3(LED green)를 출력으로 설정
 pinMode(LED_B, OUTPUT);  //핀2(LED blue)를 출력으로 설정
}

void loop() 
{
  digitalWrite(LED_R, HIGH); // LED_R -> ON
  delay(500);
  digitalWrite(LED_R, LOW); // LED_R -> Off
  delay(500);
  digitalWrite(LED_G, HIGH); // LED_R -> On
  delay(500);
  digitalWrite(LED_G, LOW); // LED_R -> Off
  delay(500);
  digitalWrite(LED_B, HIGH); // LED_R -> On
  delay(500);
  digitalWrite(LED_B, LOW); // LED_R -> Off
  delay(500);
  digitalWrite(LED_R, HIGH);
  digitalWrite(LED_B, HIGH);
  delay(500);
  digitalWrite(LED_R, LOW);
  digitalWrite(LED_B, LOW);
  delay(500);
  digitalWrite(LED_G, HIGH);
  digitalWrite(LED_B, HIGH);
  delay(500);
  digitalWrite(LED_G, LOW);
  digitalWrite(LED_B, LOW);
  delay(500);
  digitalWrite(LED_R, HIGH);
  digitalWrite(LED_G, HIGH);
  delay(500);
  digitalWrite(LED_R, LOW);
  digitalWrite(LED_G, LOW);
  delay(500);
  digitalWrite(LED_R, HIGH);
  digitalWrite(LED_B, HIGH);
  digitalWrite(LED_G, HIGH);
  delay(500);
  digitalWrite(LED_R, LOW);
  digitalWrite(LED_B, LOW);
  digitalWrite(LED_G, LOW);
  delay(500);
}
