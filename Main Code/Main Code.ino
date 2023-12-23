#include <Servo.h>

// Define servo motor pins
int leftHandPin = 8;   // Replace with your pin number
int rightHandPin = 7;  // Replace with your pin number
int bendPin = 6;       // Replace with your pin number

// Create servo objects
Servo leftHandServo;
Servo rightHandServo;
Servo bendServo;


const int trigPin = 5;  // Connect the trig pin of the sensor to digital pin 5
const int echoPin = 4;  // Connect the echo pin of the sensor to digital pin 4
int rightHandServoPosition = 100;
int leftHandServoPosition = 30;
int bendServoPosition = 50;
bool ArmMode = true;
int MaxSpeed = 100;

const int xPin = A0;  // Connect the X-axis of the joystick to analog pin A0
const int yPin = A1;  // Connect the Y-axis of the joystick to analog pin A1
const int swPin = 2;  // Connect the switch of the joystick to digital pin 2

// Motor control pins
int rightForward = 3;
int rightBackward = 9;
int leftBackward = 10;
int leftForward = 11;

void setup() {
  // Attach servo motors to respective pins
  leftHandServo.attach(leftHandPin);
  rightHandServo.attach(rightHandPin);
  bendServo.attach(bendPin);


  // Set initial positions for the servos
  leftHandServo.write(leftHandServoPosition);    // Replace with your initial position 30 - 70 =50
  rightHandServo.write(rightHandServoPosition);  // Replace with your initial position 100 - 50 = 50
  bendServo.write(bendServoPosition);            // Replace with your initial position down-50  up-0
  delay(1000);


  Serial.begin(9600);  // Initialize serial communication at 9600 bits per second
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);

  pinMode(swPin, INPUT_PULLUP);  // Set the switch pin as input with internal pull-up resistor


  pinMode(rightForward, OUTPUT);
  pinMode(rightBackward, OUTPUT);
  pinMode(leftBackward, OUTPUT);
  pinMode(leftForward, OUTPUT);



  analogWrite(rightForward, 0);
  analogWrite(leftForward, 0);
  analogWrite(rightBackward, 0);
  analogWrite(leftBackward, 0);
}


void loop() {

  // Serial.println(rightHandServo.attached());


  // analogWrite(rightForward, 0);
  // analogWrite(leftForward, 0);
  // analogWrite(rightBackward, 100);
  // analogWrite(leftBackward, 100);
  // analogWrite(rightForward, 200);
  // analogWrite(leftForward, 200);
  // analogWrite(rightBackward, 200);
  // analogWrite(leftBackward, 100);
  // // Perform hand catch
  // handCatch();

  // // Perform hand drop
  // handDrop();

  // // Perform hand up
  // handUp();

  // // Perform hand down
  // handDown();

  // getDistance();
  ReadJoystic();
  // delay(400);


  // analogWrite(rightForward, 0);
  // analogWrite(leftForward, 0);
  // analogWrite(rightBackward, 70);
  // analogWrite(leftBackward, 70);
}

void handCatch() {
  // Left hand decrease, right hand increase with small delay
  for (int i = 30; i <= 70; i++) {
    leftHandServoPosition = i;
    rightHandServoPosition = 130 - i;
    leftHandServo.write(leftHandServoPosition);
    rightHandServo.write(rightHandServoPosition);
    delay(20);
  }
  delay(500);
}

void handDrop() {
  // Inverse of hand catch
  for (int i = 70; i >= 30; i--) {
    leftHandServoPosition = i;
    rightHandServoPosition = 130 - i;
    leftHandServo.write(leftHandServoPosition);
    rightHandServo.write(rightHandServoPosition);
    delay(20);
  }
  delay(500);
}

void handUp() {
  // Hand up motion with delay
  for (int i = 50; i >= 0; i--) {
    bendServoPosition = i;
    bendServo.write(bendServoPosition);
    delay(35);
  }
  delay(500);
}

void handDown() {
  // Inverse of hand up
  for (int i = 0; i <= 50; i++) {
    bendServoPosition = i;
    bendServo.write(bendServoPosition);
    delay(50);
  }
  delay(500);
}



void getDistance() {
  long duration;
  int distance;

  // Trigger the sensor by sending a 10 microsecond pulse
  digitalWrite(trigPin, LOW);
  delayMicroseconds(2);
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);

  // Read the duration of the echo pulse
  duration = pulseIn(echoPin, HIGH);

  // Calculate the distance in centimeters
  distance = duration * 0.034 / 2;

  // Print the distance to the serial monitor
  Serial.print("Distance: ");
  Serial.print(distance);
  Serial.println(" cm");

  // Add a delay before the next measurement
  delay(100);
}


void ReadJoystic() {
  // Read the analog values from the joystick
  int xValue = analogRead(xPin);
  int yValue = analogRead(yPin);

  // Read the digital value from the switch
  int swState = digitalRead(swPin);


  // Print the values to the serial monitor
  Serial.print("X: ");
  Serial.print(xValue);
  Serial.print("\tY: ");
  Serial.print(yValue);
  Serial.print("\tSwitch: ");
  Serial.println(swState);
  if (swState == 0) {
    ArmMode = !ArmMode;
    if (ArmMode) {
      leftHandServo.attach(leftHandPin);
      rightHandServo.attach(rightHandPin);
      bendServo.attach(bendPin);
    } else {
      // leftHandServo.detach();
      // rightHandServo.detach();
      // bendServo.detach();

  
    }
    delay(1000);
  }
  if (ArmMode) {

    if (yValue < 400) {
      int i = leftHandServoPosition;
      if (leftHandServoPosition <= 70) {
        i++;
        leftHandServoPosition = i;
        rightHandServoPosition = 130 - i;
        leftHandServo.write(leftHandServoPosition);
        rightHandServo.write(rightHandServoPosition);
      }
    }
    if (yValue > 600) {
      int i = leftHandServoPosition;
      if (leftHandServoPosition >= 30) {
        i--;
        leftHandServoPosition = i;
        rightHandServoPosition = 130 - i;
        leftHandServo.write(leftHandServoPosition);
        rightHandServo.write(rightHandServoPosition);
      }
    }
    if (xValue < 400) {
      // Hand up motion with delay
      int i = bendServoPosition;
      if (bendServoPosition >= 0) {
        i--;
        bendServoPosition = i;
        bendServo.write(bendServoPosition);
        delay(35);
      }
    }
    if (xValue > 600) {
      // Hand down motion with delay
      int i = bendServoPosition;
      if (bendServoPosition <= 50) {
        i++;
        bendServoPosition = i;
        bendServo.write(bendServoPosition);
        delay(60);
      }
    }
  }
  if (!ArmMode) {

    if (yValue < 450) {
      int x = map(yValue, 0, 450, MaxSpeed, 0);
      analogWrite(rightForward, 0);
      analogWrite(leftForward, x);
      analogWrite(rightBackward, 0);
      analogWrite(leftBackward, 0);

      delay(20);

      analogWrite(rightForward, 0);
      analogWrite(leftForward, 0);
      analogWrite(rightBackward, 0);
      analogWrite(leftBackward, 0);
    }
    if (yValue > 550) {
      int x = map(yValue, 550, 1000, MaxSpeed, 0);
      analogWrite(rightForward, x);
      analogWrite(leftForward, 0);
      analogWrite(rightBackward, 0);
      analogWrite(leftBackward, 0);

      delay(20);

      analogWrite(rightForward, 0);
      analogWrite(leftForward, 0);
      analogWrite(rightBackward, 0);
      analogWrite(leftBackward, 0);
    }
    if (xValue < 450) {  //0
      int x = map(xValue, 0, 450, MaxSpeed, 0);
      analogWrite(rightForward, x);
      analogWrite(leftForward, x);
      analogWrite(rightBackward, 0);
      analogWrite(leftBackward, 0);

      delay(10);

      analogWrite(rightForward, 0);
      analogWrite(leftForward, 0);
      analogWrite(rightBackward, 0);
      analogWrite(leftBackward, 0);
      delay(10);
    }
    if (xValue > 550) {  //1018

      int x = map(xValue, 0, 450, 0, MaxSpeed);
      analogWrite(rightForward, 0);
      analogWrite(leftForward, 0);
      digitalWrite(rightBackward, HIGH);
      digitalWrite(leftBackward, HIGH);

      delay(10);

      analogWrite(rightForward, 0);
      analogWrite(leftForward, 0);
      analogWrite(rightBackward, 0);
      analogWrite(leftBackward, 0);
    }
  }
}