const int led1Pin = 2;
const int led2Pin = 3;
const int led3Pin = 4;
const int led4Pin = 5;

const int TimerPin = A0;       // Potentiometer 1 connected to analog pin A0
const int WaterLevelPin = A1;  // Potentiometer 2 connected to analog pin A1

const int buttonPin = 6;  // The digital pin where the button is connected
int buttonState = 0;      // Variable to store the button state (0 for not pressed, 1 for pressed)

void setup() {
  Serial.begin(9600);
  pinMode(led1Pin, OUTPUT);
  pinMode(led2Pin, OUTPUT);
  pinMode(led3Pin, OUTPUT);
  pinMode(led4Pin, OUTPUT);

  pinMode(buttonPin, INPUT);  // Set the button pin as an input
}


bool isManualMode = false;
bool isActiveWaterPump = false;
bool isActiveWashingMotor = false;
bool isWashingStart = false;
int TimerPercentage = 10;

void loop() {

  // Read the state of the button (LOW when pressed, HIGH when not pressed)
  buttonState = digitalRead(buttonPin);

  // Check if the button is pressed
  if (buttonState == LOW) {
    isWashingStart = true;
    Serial.println("WashingMotorStart:0");
  }

  if (!isWashingStart) {
    int Timer = analogRead(TimerPin);
    TimerPercentage = map(Timer, 0, 1023, 0, 10);
    Serial.print("T:");
    Serial.println(TimerPercentage);
  } else {
    int WaterLevel = analogRead(WaterLevelPin);
    int WaterLevelPercentage = map(WaterLevel, 0, 1023, 1, 11);
    Serial.print("W:");
    Serial.println(WaterLevelPercentage);


    if (WaterLevelPercentage == 11) {
      Serial.print("Washing:");
      Serial.println(TimerPercentage);
      delay(1000 * TimerPercentage);

      // for (int i = TimerPercentage; 0 < i; i--) {
      //   Serial.print("Washing:");
      //   Serial.println(i);
      //   delay(1000);
      // }
      Serial.println("WashingComplete:0");
    }
  }




  // for (int i = 1; i <= 11; i++) {

  //   Serial.print("A:");
  //   Serial.println(i);
  //   // Serial.println(i); // Print the current value
  //   delay(1000);  // Add a delay of 500 milliseconds between each print
  // }



  // Serial.print("B:");
  // Serial.println(pot2Percentage);
  // delay(300);
}

// void loop() {
//   // Read the values of the potentiometers
//   int WaterLevel = analogRead(pot1Pin);
//   int Timer = analogRead(pot2Pin);


//   float phvalue = map (WaterLevel, 0, 1023, 0, 140)/10.0;
//   Serial.println(phvalue,1);
//   delay(200);
//    float tubidity = map (Timer, 0, 1023, 0, 500)/10.0;
//   Serial.println(tubidity,1);
//   delay(200);

//   // Calculate the percentage values
//   int pot1Percentage = map(WaterLevel, 0, 1023, 0, 100);
//   int pot2Percentage = map(Timer, 0, 1023, 0, 100);

//   // Check conditions for LED 1
//   if (pot1Percentage < 46) {
//     digitalWrite(led1Pin, HIGH);
//   } else {
//     digitalWrite(led1Pin, LOW);
//   }

//   // Check conditions for LED 2
//   if (pot1Percentage > 53) {
//     digitalWrite(led2Pin, HIGH);
//   } else {
//     digitalWrite(led2Pin, LOW);
//   }

//   // Check conditions for LED 3
//   if (pot1Percentage < 46 || pot1Percentage > 53) {
//     digitalWrite(led3Pin, HIGH);
//   } else {
//     digitalWrite(led3Pin, LOW);
//   }

//   // Check conditions for LED 4
//   if (pot2Percentage > 10) {
//     digitalWrite(led4Pin, HIGH);
//   } else {
//     digitalWrite(led4Pin, LOW);
//   }

//   // Add a delay to avoid rapid changes
//   delay(500);

//    if (Serial.available() > 0) {
//     String command = Serial.readStringUntil('\n');

//     // Process commands
//     if (command == "A") {
//       digitalWrite(led1Pin, HIGH);
//     } else if (command == "B") {
//       digitalWrite(led1Pin, LOW);
//     } else if (command == "C") {
//       digitalWrite(led2Pin, HIGH);
//     } else if (command == "D") {
//       digitalWrite(led2Pin, LOW);
//     } else if (command == "E") {
//       digitalWrite(led3Pin, HIGH);
//     } else if (command == "F") {
//       digitalWrite(led3Pin, LOW);
//     } else if (command == "G") {
//       digitalWrite(led4Pin, HIGH);
//     } else if (command == "H") {
//       digitalWrite(led4Pin, LOW);
//    }}}