const int ledPin = 13;
int ledState = 0;

void setup() {
  pinMode(ledPin, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  recvSerial();
}

void recvSerial() {
  digitalWrite(ledPin, LOW);
  if (Serial.available()) {
    String serialData = Serial.readString();
    Serial.println(serialData);
    digitalWrite(ledPin, HIGH);
  }
}
