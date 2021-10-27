#define sensor_a 10
#define sensor_b 9
#define sensor_c 8
 

void setup() {
  Serial.begin(9600);
  pinMode(sensor_a, INPUT);
  pinMode(sensor_b, INPUT);
  pinMode(sensor_c, INPUT);
}

void loop() {
  Serial.print("[");
  Serial.print(digitalRead(sensor_a));
  Serial.print("/");
  Serial.print(digitalRead(sensor_b));
  Serial.print("/");
  Serial.print(digitalRead(sensor_c));
  Serial.println("]");
}
