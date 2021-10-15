int readCDS(){
  int CDS_val = analogRead(CDS);
  Serial.print("조도 값 : ");
  Serial.println(CDS_val);
  
  return CDS_val;
}
