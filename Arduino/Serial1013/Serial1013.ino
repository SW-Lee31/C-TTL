const int LED_R = 11;
const int LED_G = 10;
const int LED_B = 9;

void setup() 
{
  // 시리얼 통신 시작 및 보레이트 지정(9600)
  Serial.begin(9600);

  pinMode(LED_R, OUTPUT);
  pinMode(LED_G, OUTPUT);
  pinMode(LED_B, OUTPUT);
}


  // 헤드램프 1라인 : 빨강
  // 헤드램프 2라인 : 파랑
  // 헤드램프 3라인 : 초록
  // 라인 1 ~ 3 중 입력 -> LED에 표시
void loop() 
{
  if (Serial.available())
  {
    char data = Serial.read();  // readString(), readStringUntil('\n') 으로 문자열 읽기 가능, 속도는 느림.
    
    switch (data)
    {
      case '1':
      Serial.println("라인1 가동");
      
      for (int i = 0; i < 200; i++)
      {
        setColor(i, 0, 0);
        delay(20);
        if (i == 199)
        {
          for (int j = 199; j >=0; j--)
          {
            setColor(j, 0, 0);
            delay(20);
          }
        }
      }
      break;

      case '2':
      Serial.println("라인2 가동");
      
      for (int i = 0; i < 200; i++)
      {
        setColor(0, 0, i);
        delay(20);
        if (i == 199)
        {
          for (int j = 199; j >=0; j--)
          {
            setColor(0, 0, j);
            delay(20);
          }
        }
      }
      break;

      case '3':
      Serial.println("라인3 가동");
      
      for (int i = 0; i < 200; i++)
      {
        setColor(0, i, 0);
        delay(20);
        if (i == 199)
        {
          for (int j = 199; j >=0; j--)
          {
            setColor(0, j, 0);
            delay(20);
          }
        }
      }
      break;

      default:
      Serial.println(data);
    }
    
  }
}

void setColor(int red, int green, int blue)
{
  analogWrite(LED_R, red);
  analogWrite(LED_G, green);
  analogWrite(LED_B, blue);
}
