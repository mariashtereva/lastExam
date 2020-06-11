int redPin = 11;
int greenPin = 10;
int bluePin = 9;
void setup()
{
  pinMode(redPin, OUTPUT);
  pinMode(greenPin, OUTPUT);
  pinMode(bluePin, OUTPUT);
}
void loop()
{
  // RED
  setColor(255, 0, 0);
  delay(1000);
  //BLUE
  setColor(0, 0, 255);
  delay(1000);
  //GREEN
  setColor(0, 255, 0);
  delay(1000);
  
  // CYAN
  setColor(0, 255, 255);
  delay(1000);
  //MAGENTA
  setColor(80, 0, 80);
  delay(1000);
  //YELLOW
  setColor(255, 255, 0);
  delay(1000);
}
void setColor(int red, int green, int blue)
{
  analogWrite(redPin, red);
  analogWrite(bluePin, blue);
  analogWrite(greenPin, green);
}