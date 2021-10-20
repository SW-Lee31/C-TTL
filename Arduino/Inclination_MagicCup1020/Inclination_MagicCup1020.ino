#define R_sig 7
#define R_LED 6
#define L_sig 4
#define L_LED 5
boolean Rstatus;
boolean Lstatus;
int R_bright = 0;
int L_bright = 0;

void setup() {
  Serial.begin(9600);
  pinMode(R_sig, INPUT_PULLUP);
  pinMode(R_LED, OUTPUT);
  pinMode(L_sig, INPUT_PULLUP);
  pinMode(L_LED, OUTPUT);
}

void loop() {
  Rstatus = digitalRead(R_sig);
  Lstatus = digitalRead(L_sig);

  Serial.print("오른쪽 : ");
  Serial.print(Rstatus);
  Serial.print(" 왼쪽 : ");
  Serial.println(Lstatus);
  
  if (Rstatus == HIGH && R_bright < 125){
    R_bright++;
  }
  if (Rstatus == LOW && R_bright > 0){
    R_bright--;
  }

  if (Lstatus == HIGH && L_bright < 125){
    L_bright++;
  }
  if (Lstatus == LOW && L_bright > 0){
    L_bright--;
  }

  analogWrite(R_LED, R_bright);
  analogWrite(L_LED, L_bright);
  delay(30);
}
