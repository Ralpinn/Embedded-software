void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
pinMode(13,OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
String readString;
String Q;

  while (Serial.available()){
    delay(1);
    if(Serial.available()){
      char c = Serial.read();
      if  (isControl(c)){
        break;
        }
        readString += c;
      }
    }

Q = readString;
if  (Q=="on"){
  digitalWrite(13,HIGH);
  }
  
if  (Q=="off"){
  digitalWrite(13,LOW);
  }
}
