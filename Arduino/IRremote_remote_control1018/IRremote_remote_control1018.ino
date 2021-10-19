#include <MsTimer2.h>
#include <IRremote.h>

int SWITCH = 4;
int LED_R = 11;
int LED_G = 10;
int LED_B = 9;

void remote_resv()
{
  
}

void setup()
{
  pinMode(led_pin, OUTPUT);

  MsTimer2::set(500, remote_resv); // 500ms period
  MsTimer2::start();
}

void loop()
{
}
