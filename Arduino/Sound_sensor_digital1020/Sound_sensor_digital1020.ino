#define Ssens 4
int clap_cnt;

void setup() {
  Serial.begin(9600);
  pinMode(Ssens, INPUT);
}

void loop() {
  Serial.println(digitalRead(Ssens));
  delay(150);
/*
  if (analogRead(Ssens) > 100)
  {
    clap_cnt++;
    Serial.print("박수 횟수 : ");
    Serial.print(clap_cnt);
    Serial.println("회");
  }
  delay(1650);
  */
}
