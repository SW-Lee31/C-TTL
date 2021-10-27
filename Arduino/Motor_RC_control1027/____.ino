#define EA 3  // 모터드라이버 EA 핀, 아두이노 디지털 3번 핀에 연결
#define EB 11  // 모터드라이버 EB 핀, 아두이노 디지털 11번 핀에 연결
#define M_IN1 4  // 모터드라이버 IN1 핀, 아두이노 디지털 4번 핀에 연결
#define M_IN2 5  // 모터드라이버 IN2 핀, 아두이노 디지털 5번 핀에 연결
#define M_IN3 13  // 모터드라이버 IN3 핀, 아두이노 디지털 13번 핀에 연결
#define M_IN4 12  // 모터드라이버 IN4 핀, 아두이노 디지털 12번 핀에 연결
#define R_Sensor 8  // 오른쪽 트랙킹(추적)센서 모듈 DO 핀, 아두이노 우노 보드의 8번 핀에 연결
#define C_Sensor 9  // 가운데 트랙킹(추적)센서 모듈 DO 핀, 아두이노 우노 보드의 9번 핀에 연결
#define L_Sensor 10  // 왼쪽 트랙킹(추적)센서 모듈 DO 핀, 아두이노 우노 보드의 10번 핀에 연결
int motorA_vector = 1;  // 모터의 회전방향이 반대일 시 0을 1로, 1을 0으로 바꿔주면 모터의 회전방향이 바뀜.
int motorB_vector = 1;  // 모터의 회전방향이 반대일 시 0을 1로, 1을 0으로 바꿔주면 모터의 회전방향이 바뀜.
int motor_speed = 255;  // 모터 스피드 0 ~ 255

void setup() {
  Serial.begin(9600);
  pinMode(EA, OUTPUT);  // EA 핀 출력 설정
  pinMode(EB, OUTPUT);  // EB 핀 출력 설정
  pinMode(M_IN1, OUTPUT);  // IN1 핀 출력 설정
  pinMode(M_IN2, OUTPUT);  // IN2 핀 출력 설정
  pinMode(M_IN3, OUTPUT);  // IN3 핀 출력 설정
  pinMode(M_IN4, OUTPUT);  // IN4 핀 출력 설정
  pinMode(R_Sensor, INPUT);  // 오른쪽 센서 D0 핀 입력 설정
  pinMode(C_Sensor, INPUT);  // 가운데 센서 D0 핀 입력 설정
  pinMode(L_Sensor, INPUT);  // 왼쪽 센서 D0 핀 입력 설정
  digitalWrite(EA, HIGH);  // EA 핀 출력 설정
  digitalWrite(EB, HIGH);
}

void loop() {
  // IN1 HIGH 우측모터 전진
  // IN2 HIGH 우측모터 후진
  // IN3 HIGH 좌측모터 전진
  // IN4 HIGH 좌측모터 후진

  int R =digitalRead(R_Sensor);
  int L =digitalRead(L_Sensor);
  int C =digitalRead(C_Sensor);
    
  if(R == HIGH)
  {
    ReStart();
    Right();
  }
  else if(L == HIGH)
  {
    ReStart();
    Left();
  }
  else if(C == HIGH)
  {
    ReStart();
    Run();
  }
  /* else if(R == HIGH && L == HIGH || R == HIGH && C == HIGH || C == HIGH && L == HIGH)
  {
    StopRun();
  }
  */
}

void reset()
{
  digitalWrite(M_IN1,LOW);
  digitalWrite(M_IN2,LOW);
  digitalWrite(M_IN3,LOW);
  digitalWrite(M_IN4,LOW);
}
void Run()
{
  reset();
  digitalWrite(M_IN1,HIGH);
  digitalWrite(M_IN3, HIGH);
   digitalWrite(M_IN2,HIGH);
  digitalWrite(M_IN4, HIGH);
  
}
void Back()
{
  reset();
  digitalWrite(M_IN2,LOW);
  digitalWrite(M_IN1, LOW);
  digitalWrite(M_IN3,LOW);
  digitalWrite(M_IN4, LOW);
}
void Right()
{
  reset();
  
  digitalWrite(M_IN1, LOW);
  digitalWrite(M_IN2, LOW);
  digitalWrite(M_IN3, HIGH);
  digitalWrite(M_IN4, HIGH);
}

void Left()
{
  reset();
  digitalWrite(M_IN1, HIGH);
  digitalWrite(M_IN2, HIGH);
  digitalWrite(M_IN3, LOW);
  digitalWrite(M_IN4, LOW);
}
void Stop()
{
  digitalWrite(EA , LOW);
  digitalWrite(EB, LOW);
}
void ReStart()
{
  digitalWrite(EA , HIGH);
  digitalWrite(EB, HIGH);
}
void StopRun()
{
  Stop();
  delay(10000);
  ReStart();
  Run();
}
