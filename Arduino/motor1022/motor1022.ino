#include <Servo.h>
#define EA 3
#define M_IN1 4
#define M_IN2 5
#define EB 11
#define M_IN3 13
#define M_IN4 12
#define servoPin 2

// Tracking Sensor
#define trackSensor_l 10
#define trackSensor_c 9
#define trackSensor_r 8

Servo servo;
boolean motorA_vector;

void setup() 
{
    pinMode(EA, OUTPUT);
    pinMode(M_IN1, OUTPUT);
    pinMode(M_IN2, OUTPUT);
    pinMode(M_IN3, OUTPUT);
    pinMode(M_IN4, OUTPUT);
    pinMode(trackSensor_l, INPUT);
    pinMode(trackSensor_c, INPUT);
    pinMode(trackSensor_r, INPUT);
    servo.attach(servoPin);
}

void loop() 
{
  // 좌측모터 전진 in1
  // 우측모터 전진 in3
  // 좌측모터 후진 in2
  // 우측모터 후진 in4
  
 if (digitalRead(trackSensor_c) == LOW){
    start_motor();
    m_forward();
 }
  
 if (digitalRead(trackSensor_c) == HIGH){
    stop_motor();
  }

 if (digitalRead(trackSensor_l) == LOW){
    start_motor();
    m_left();
 }

 if (digitalRead(trackSensor_r) == LOW){
    start_motor();
    m_right();
 }
  
}

void servo_look_around(){
  for (int angle = 0; angle < 180; angle++){
    servo.write(angle);
    delay(10);
  }

  for(int angle = 180; angle > 0; angle--){
    servo.write(angle);
    delay(10);
  }
}

void start_motor(){
  digitalWrite(EA, HIGH);
  digitalWrite(EB, HIGH);
}

void stop_motor(){
  digitalWrite(EA, LOW);
  digitalWrite(EB, LOW);
}

void m_forward(){
  clear_d();
  digitalWrite(M_IN1, HIGH);
  digitalWrite(M_IN3, HIGH);
}

void m_right(){
  clear_d();
  digitalWrite(M_IN3, HIGH);
}

void m_left(){
  clear_d();
  digitalWrite(M_IN1, HIGH);
}
void clear_d(){
  digitalWrite(M_IN1, LOW);
  digitalWrite(M_IN2, LOW);
  digitalWrite(M_IN3, LOW);
  digitalWrite(M_IN4, LOW);
}

void move_backward(int timer){
  digitalWrite(M_IN1, HIGH);
  digitalWrite(M_IN4, HIGH);
  delay(timer);
  move_backward_stop();
}

void move_backward_stop(){
  digitalWrite(M_IN1, LOW);
  digitalWrite(M_IN4, LOW);
}
