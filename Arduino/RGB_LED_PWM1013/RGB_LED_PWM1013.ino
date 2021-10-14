const int LED_R = 11;  // LED red에 핀4 연결
const int LED_G = 10;  // LED green에 핀3 연결
const int LED_B = 9;  // LED blue에 핀2 연결

void setup() 
{
  // 핀모드를 input, output을 꼭 설정해야 함.
 pinMode(LED_R, OUTPUT);  //핀4(LED red)를 출력으로 설정
 pinMode(LED_G, OUTPUT);  //핀3(LED green)를 출력으로 설정
 pinMode(LED_B, OUTPUT);  //핀2(LED blue)를 출력으로 설정

 analogWrite(LED_R, 0);
 analogWrite(LED_G, 0);
 analogWrite(LED_B, 0); 
}

void loop() 
{
  for (int i = 0; i < 130; i++)
  {
    setColor(i, 0, i);
    delay(25);
  }

  for (int i = 130; i >= 0; i--)
  {
    setColor(i, 0, i);
    delay(25);
  }
  delay(100);
}

void setColor(int red, int green, int blue)
{
  analogWrite(LED_R, red);
  analogWrite(LED_G, green);
  analogWrite(LED_B, blue);
}
