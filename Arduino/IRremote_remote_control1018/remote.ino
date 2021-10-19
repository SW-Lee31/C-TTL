IRrecv recv(3);
decode_results results;
HEX return_val;

void execute(){
  
  if (recv.decode(&results))
  {
    Serial.println(results.value, HEX);
    return_val = (results.value, HEX);
    recv.resume();
  }

  return return_val;
}
