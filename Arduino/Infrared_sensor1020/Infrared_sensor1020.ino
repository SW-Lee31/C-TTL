#define sensor 3
#define buz 2
boolean sensor_val = 0;

void setup() {
  Serial.begin(9600);
  pinMode(sensor, INPUT_PULLUP);
  pinMode(buz, OUTPUT);
}

void loop() {
  sensor_val = digitalRead(sensor);
  Serial.println(sensor_val);

  delay(1000);
}
