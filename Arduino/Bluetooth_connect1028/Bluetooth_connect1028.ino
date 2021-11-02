#include <SoftwareSerial.h>

SoftwareSerial BT(9, 8);

void setup() {
  Serial.begin(9600);
  BT.begin(9600);

}

void loop() {
  while(BT.available()){
    byte data = BT.read();
    Serial.write(data);
  }

  while(Serial.available()){
    byte data = Serial.read();
    BT.write(data);
    Serial.write(data);
  }
}
