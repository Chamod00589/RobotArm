void setup() {
  Serial.begin(9600); // initialize serial communication at 9600 bps
    pinMode(LED_BUILTIN, OUTPUT);
}

void loop() {

  // Check for commands from the serial port
  if (Serial.available() > 0) {
    String command = Serial.readStringUntil('\n');

    // Check for LED control commands
    if (command == "LED_ON") {
      digitalWrite(LED_BUILTIN, HIGH); 
      // digitalWrite(ledPin, HIGH); // Turn on the LED
    } else if (command == "LED_OFF") {
      // digitalWrite(ledPin, LOW); // Turn off the LED
      digitalWrite(LED_BUILTIN, LOW); 
    }
  }

  for (int i = 1; i <= 100; ++i) {

    Serial.print("PotValue:"); // print the current value of i
    Serial.println(i); // print the current value of i
    // delay(1); // add a small delay for readability in the serial monitor
  }

  // while (true) {
  //   // This loop will continue indefinitely after printing 1 to 1000.
  //   // You can modify or add additional code here if needed.
  // }
}

