#include <Servo.h>
#include <MsTimer2.h>

#define DIST_S 150*58.2
#define PING_INTERVAL 33

#define servoPin 2
#define EA 3  // 모터드라이버 EA 핀, 아두이노 디지털 3번 핀에 연결
#define EB 11  // 모터드라이버 EB 핀, 아두이노 디지털 11번 핀에 연결
#define M_IN1 4  // 모터드라이버 IN1 핀, 아두이노 디지털 4번 핀에 연결
#define M_IN2 5  // 모터드라이버 IN2 핀, 아두이노 디지털 5번 핀에 연결
#define M_IN3 13  // 모터드라이버 IN3 핀, 아두이노 디지털 13번 핀에 연결
#define M_IN4 12  // 모터드라이버 IN4 핀, 아두이노 디지털 12번 핀에 연결
#define R_Sensor 8  // 오른쪽 트랙킹(추적)센서 모듈 DO 핀, 아두이노 우노 보드의 8번 핀에 연결
#define C_Sensor 9  // 가운데 트랙킹(추적)센서 모듈 DO 핀, 아두이노 우노 보드의 9번 핀에 연결
#define L_Sensor 10  // 왼쪽 트랙킹(추적)센서 모듈 DO 핀, 아두이노 우노 보드의 10번 핀에 연결
#define echo 6  // 초음파 센서 에코(Echo) 핀, 아두이노 우노 보드의 디지털 6번 핀 연결
#define trig 7  // 초음파 센서 트리거(Trigger) 핀, 아두이노 우노 보드의 디지털 7번 핀 연결
Servo servo;
uint8_t currentSensor = 0;  
unsigned long pingTimer;
long dist_r;
int servo_degree = 0;
bool mode_flag;
bool machine_flag;
int stop_count;
volatile boolean run_mode = true;


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
  pinMode(trig, OUTPUT);  // trig 출력 설정
  pinMode(echo, INPUT);  // echo 입력설정
  digitalWrite(EA, HIGH);  // EA 핀 출력 설정
  digitalWrite(EB, HIGH);
  servo.attach(servoPin);
  servo.write(servo_degree);
  pingTimer= millis(); // 초음파 타이머 핑 시간 초기화
  Serial.begin(9600);

  /* MsTimer2::set(1000, trig_ultra);
  MsTimer2::start();
  */
}

void loop() {
   if (millis() >= pingTimer){
      pingTimer += PING_INTERVAL;      // 다음 핑타임 설정
      dist_r = trig_ultra(trig, echo);
      if (dist_r > 0 && dist_r <= 20){
        Serial.println("Stuck Activate");
        Stop();
        delay(1000);
      }
     }
   
  /*
   if (dist_r > 0 && dist_r <= 15){
      Serial.println("Stuck Activate");
      Stop();
    }
  */
     
  if(Serial.available()){
     char cmd= Serial.read();

     
      if(cmd == 'A'){
          mode_Auto();
          Serial.println('A');
        }
      if(cmd == 'F'){
          Straight();
          Serial.println('F');
        }
      if(cmd == 'R'){
          Right();
          Serial.println('R');
        }
      if(cmd == 'L'){
          Left();
          Serial.println('L');
        }
      if(cmd == 'S'){
          Stop();
          servo.write(servo_degree);
          machine_flag = false;
        }
      if (cmd == 'M'){
        machine_flag = true;
        Serial.println('M');
      }

     
     

     if (machine_flag == true){
        machine_act(1);
        Serial.println('J');
        servo_degree = 0;
        machine_flag = false;
      }
      else if (machine_flag == false){
        servo_degree = 0;
        servo.write(servo_degree);
      }

     if (cmd == '1' || cmd == '2'){
      mode_flag = !mode_flag;
    }
  }
}

void mode_Auto(){
  int R =digitalRead(R_Sensor);
  int L =digitalRead(L_Sensor);
  int C =digitalRead(C_Sensor); 
  /* Serial.print('[');
  Serial.print(L);
  Serial.print('/');
  Serial.print(C);
  Serial.print('/');
  Serial.print(R);
  Serial.println(']'); */
  
  if ( (C==HIGH&& R==HIGH&& L==HIGH) && (C==HIGH&&R==HIGH)&&(C==HIGH&&L==HIGH))
  {
    Stop();
    delay(2000);
    Re();
    Straight();
    // StopRun();
  } 
  
  else if (C==HIGH)
  {    
    Re();
    Straight();
  }
  else if ( R==HIGH)
  {
    Re();
    Right();
  }
  else if ( L==HIGH)
  {
    Re();
    Left();
  }
  else if ( C==LOW && R==HIGH && L ==HIGH)
  {
    Straight();
  }
}

void Straight()
{     
    analogWrite(EA, 150);
    analogWrite(EB, 150);
    digitalWrite(M_IN1, HIGH);
    digitalWrite(M_IN3, HIGH);  
    digitalWrite(M_IN2, LOW);
    digitalWrite(M_IN4, LOW);   
}
void Stop()
{     
    analogWrite(EA, LOW);
    analogWrite(EB, LOW);
    digitalWrite(M_IN1, LOW);
    digitalWrite(M_IN3, LOW);
    digitalWrite(M_IN2, LOW);
    digitalWrite(M_IN4, LOW);   
}
void Right()
{     
    analogWrite(EA, 150);
    analogWrite(EB, 150);
    digitalWrite(M_IN1, LOW);
    digitalWrite(M_IN3, HIGH);
    digitalWrite(M_IN2, HIGH);
    digitalWrite(M_IN4, LOW);   
}
void Left()
{
    analogWrite(EA, 150);
    analogWrite(EB, 150);
    digitalWrite(M_IN1, HIGH);
    digitalWrite(M_IN3, LOW);
    digitalWrite(M_IN2, LOW);
    digitalWrite(M_IN4, HIGH);   
}
void Re()
{
  analogWrite(EA, 150);
  analogWrite(EB, 150);
}

 long trig_ultra(int TRIG, int ECHO)  // 초음파 센서 값 읽어오는 함수
{
  long dist;
  digitalWrite(TRIG, LOW); 
  delayMicroseconds(2); 
  digitalWrite(TRIG, HIGH); 
  delayMicroseconds(10);
  digitalWrite(TRIG, LOW);
  dist = pulseIn(ECHO, HIGH, DIST_S)/58.2;
  return(dist);
}

/*
 void trig_ultra(){
  long dist;
  digitalWrite(trig, LOW); 
  delayMicroseconds(2); 
  digitalWrite(trig, HIGH); 
  delayMicroseconds(10);
  digitalWrite(trig, LOW);
  dist = pulseIn(echo, HIGH, DIST_S)/58.2;
  dist_r = dist;
}
*/

void machine_act(int i)
{
  for (int j = 0; j < i; j++)
  {
    for (int servo_degree = 0; servo_degree <= 90; servo_degree++)
    {
        servo.write(servo_degree);
        delay(30);
    }

      for (int servo_degree = 90; servo_degree >= 0; servo_degree--)
      {
        servo.write(servo_degree);
        delay(30);
      }
  }
}

/* void StopRun()
{
  stop_count++;
  Stop();
  if(stop_count == 0)
  {
    delay(3000);
  }
  else if (stop_count  == 1)
  {
    Left();
    delay(500);
    Right();
    delay(500);
    Straight();
  }
  else if (stop_count  == 2)
  {
    Left();
    delay(500);
    Right();
    delay(500);
    Straight();
  }
  else if (stop_count  == 3)
  {
    delay(3000);
  }
 
}
 */
