const int LED_R = 11;
const int LED_G = 10;
const int LED_B = 9;
String strData;


void setup() 
{
  // 시리얼 통신 시작 및 보레이트 지정(9600)
  Serial.begin(9600);

  pinMode(LED_R, OUTPUT);
  pinMode(LED_G, OUTPUT);
  pinMode(LED_B, OUTPUT);
  Serial.setTimeout(100);  // 데이터 수신 대기시간 설정 -> 반응속도 올림
}


  // 헤드램프 1라인 : 빨강
  // 헤드램프 2라인 : 파랑
  // 헤드램프 3라인 : 초록
  // 라인 1 ~ 3 중 입력 -> LED에 표시
void loop() 
{
  if (Serial.available())
  {
    strData = Serial.readStringUntil('\n');
    //  readStringntil  -> Serial Monitor 에서는 NL&CR 말고 LineEnding 없음을 쓸 것
    if (strData.equals("L1"))
    {
      Serial.println("1라인 가동");
      
      for (int i = 0; i < 3; i++)
      {
      setColor(255, 0, 0);
      delay(500);
      setColor(0, 0, 0);
      delay(500);
      }
    }
    else if (strData.equals("L2"))
    {
      Serial.println("2라인 가동");
      
      for (int i = 0; i < 3; i++)
      {
      setColor(0, 0, 255);
      delay(500);
      setColor(0, 0, 0);
      delay(500);
      }
    }
    else if (strData.equals("L3"))
    {
      Serial.println("3라인 가동");
      
      for (int i = 0; i < 3; i++)
      {
      setColor(0, 255, 0);
      delay(500);
      setColor(0, 0, 0);
      delay(500);
      }
    }
    else
    {
      Serial.println(strData);
    }
  }
}

void setColor(int red, int green, int blue)
{
  analogWrite(LED_R, red);
  analogWrite(LED_G, green);
  analogWrite(LED_B, blue);
}
