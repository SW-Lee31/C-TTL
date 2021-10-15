void readDHT11(){
  float h = dht.readHumidity();
  float t = dht.readTemperature();

  if (isnan(h) || isnan(t)) {
    Serial.println(F("Failed to read from DHT sensor!"));
    return;
  } // 오류 처리 (제대로 된 값이 안 들어온 경우) isnan ->  숫자정보가 아님.

  float hic = dht.computeHeatIndex(t, h, false);

  /* Serial.print(F("습도: "));
  Serial.print(h);
  Serial.print(F("%  온도: "));
  Serial.print(t);
  Serial.println(F("℃"));
  */

  // UI에 정보 송신 양식(파싱)  -> [라인번호/온도/습도]
  Serial.print("[1/");
  Serial.print(t);
  Serial.print("/");
  Serial.print(h);
  Serial.print("]");
  Serial.print("[2/");
  Serial.print(t + 6);
  Serial.print("/");
  Serial.print(h + 7);
  Serial.println("]");
}
