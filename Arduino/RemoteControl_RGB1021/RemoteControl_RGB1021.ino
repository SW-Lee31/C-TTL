#include <IRremote.h>
#define led_r 11
#define led_g 10
#define led_b 9
#define ir 8

IRrecv irrecv(8);
decode_results results;

void setup() {
  Serial.begin(9600);
  pinMode(led_r, OUTPUT);
  pinMode(led_g, OUTPUT);
  pinMode(led_b, OUTPUT);
  irrecv.enableIRIn(); // IR 수신 시작
}

void loop() {
  if (irrecv.decode(&results))
  {
      Serial.println(results.value, HEX);
      switch (results.value){
      case 0xFF30CF: setColor(125, 0, 0); break;
      case 0xFF18E7: setColor(0, 0, 125); break;
      case 0xFF7A85: setColor(0, 125, 0); break;
      case 0xFF10EF: onColor(); break;
      case 0xFF38C7: offColor(); break;
    }

    irrecv.resume();
  }

  delay(100);
}

void setColor(int red, int green, int blue){
  analogWrite(led_r, red);
  analogWrite(led_g, green);
  analogWrite(led_b, blue);
}

void offColor(){
  digitalWrite(led_r, LOW);
  digitalWrite(led_g, LOW);
  digitalWrite(led_b, LOW);
}

void onColor(){
  digitalWrite(led_r, HIGH);
  digitalWrite(led_g, HIGH);
  digitalWrite(led_b, HIGH);
}
