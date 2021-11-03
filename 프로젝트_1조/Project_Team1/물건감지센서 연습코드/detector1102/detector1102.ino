int LED_R = 3;
int LED_G = 4; 
int Buzzer_pin= 5;
int count_A; 
int count_B; 
int Laser_pinA = 6;
int Laser_pinB = 7;
int Sensor_A = A1;
int Sensor_B = A2;


void setup() {
  Serial.begin(9600);
  //pinMode(LED_R,OUTPUT);
  pinMode(Laser_pinA, OUTPUT);
  
  //pinMode(Buzzer_pin, OUTPUT);

  //pinMode(LED_G,OUTPUT);
  //pinMode(Laser_pinB, OUTPUT);
    
  
}

void loop() {
  digitalWrite(Laser_pinA, HIGH);
  //digitalWrite(Laser_pinB, HIGH); 
  //int SensorA_val = analogRead(Sensor_A);
  //int SensorB_val = analogRead(Sensor_B); 

  /*if(SensorA_val>=135){
     count_A ++;   
     delay(3000);//물건 지나가는 시간   
    }    
  // delay(500);
  if(count_A >= 20){
    count_A=0;  
    digitalWrite(LED_R, HIGH);
    digitalWrite(Buzzer_pin, HIGH);
    Serial.println('1');
    delay(1000);
    digitalWrite(LED_R, LOW);
    digitalWrite(Buzzer_pin, LOW); 
    } 
   
   if(SensorB_val>=108){
     count_B ++;     
     delay(3000);//물건 지나가는 시간 
    }  
  
  //delay(500);
  
  if(count_B>=20){ 
    count_B=0; 
    digitalWrite(LED_G, HIGH);
    digitalWrite(Buzzer_pin, HIGH);
    Serial.println('2');
    delay(1000);
    digitalWrite(LED_G, LOW);
    digitalWrite(Buzzer_pin, LOW); 
    } */
}
