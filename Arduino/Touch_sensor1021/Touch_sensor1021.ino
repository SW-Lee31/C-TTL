#define Tsens A0
#define buz A1
#define led_r 7
#define led_g 6
#define led_b 5

void setup() {
  Serial.begin(9600);
  pinMode(Tsens, INPUT);
  pinMode(buz, OUTPUT);
  pinMode(led_r, OUTPUT);
  pinMode(led_g, OUTPUT);
  pinMode(led_b, OUTPUT);
}

void loop() {
  Serial.println(analogRead(Tsens));
  delay(500);

  if (analogRead(Tsens) <= 1010){
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
 
}
