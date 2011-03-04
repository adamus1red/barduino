const int transistorPin1 = 9;
const int transistorPin2 = 10;
const int ledPin = 13;

void setup() {
 pinMode(transistorPin1, OUTPUT); 
 pinMode(transistorPin2, OUTPUT);
 pinMode(ledPin, OUTPUT);
}

void loop() {
 digitalWrite(transistorPin1, HIGH);
 digitalWrite(ledPin, HIGH);
  delay(1000);
 digitalWrite(transistorPin1, LOW);
 digitalWrite(ledPin, LOW);
  delay(1000); 
 digitalWrite(transistorPin2, HIGH);
 digitalWrite(ledPin, HIGH);
 delay(1000);
 digitalWrite(transistorPin2, LOW);
 digitalWrite(ledPin, LOW);
 delay(1000);
}
