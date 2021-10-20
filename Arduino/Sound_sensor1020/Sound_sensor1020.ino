#define Ssens A0
int clap_cnt;

void setup() {
  Serial.begin(9600);
  pinMode(Ssens, INPUT);
}

void loop() {
  Serial.println(analogRead(Ssens));

  if (analogRead(Ssens) > 100)
  {
    clap_cnt++;
    Serial.print("박수 횟수 : ");
    Serial.print(clap_cnt);
    Serial.println("회");
  }
  delay(1650);
}
