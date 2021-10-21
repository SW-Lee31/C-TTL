#define les 8
#define buz A0
#define sens A1
#define t_sens 2
#define i_sens A2
#define track 7

boolean l_status;

void setup() {
  Serial.begin(9600);
  pinMode(les, OUTPUT);
  pinMode(buz, OUTPUT);
  pinMode(sens, INPUT);
  pinMode(t_sens, INPUT);
  pinMode(i_sens, INPUT);
  pinMode(track, INPUT);
  attachInterrupt(digitalPinToInterrupt(t_sens), Lcontrol, FALLING);
}

void Lcontrol(){
  l_status = !l_status;
}

void loop() {
  digitalWrite(les, l_status);
  Serial.println(digitalRead(track));
  if (analogRead(i_sens) < 50)
  {
    Serial.println("[적외선] 물체감지");
  }
  
  if (l_status == true){
    if (analogRead(sens) > 100){
    tone(buz, 300);
    Serial.println("[레이저] 물체감지");
  }
    else{
     noTone(buz);
    }
  }
  else{
    noTone(buz);
  }
  
  delay(500);

  /* if (analogRead(les) <= 1010){
    digitalWrite(led_r, HIGH);
    digitalWrite(led_g, HIGH);
    digitalWrite(led_b, HIGH);
    tone(buz, 300, 100);
  }
  else{
    digitalWrite(led_r, LOW);
    digitalWrite(led_g, LOW);
    digitalWrite(led_b, LOW);
  }
  */
 
}
