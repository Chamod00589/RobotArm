const int WaterPumpLED = 3;
const int WashingMotorLED = 4;
const int BuzzerPin = 5;

const int TimerPin = A0;       // Potentiometer 1 connected to analog pin A0
const int WaterLevelPin = A1;  // Potentiometer 2 connected to analog pin A1

const int buttonPin = 6;  // The digital pin where the button is connected
int buttonState = 0;      // Variable to store the button state (0 for not pressed, 1 for pressed)

void setup() {
  Serial.begin(9600);
  pinMode(WaterPumpLED, OUTPUT);
  pinMode(WashingMotorLED, OUTPUT);
  pinMode(BuzzerPin, OUTPUT);

  pinMode(buttonPin, INPUT);  // Set the button pin as an input


  Serial.println("Reset:0");
}


bool isManualMode = false;
bool isActiveWaterPump = false;
bool isActiveWashingMotor = false;
bool isWashingStart = false;
int TimerPercentage = 10;
bool isCompleteWashing = false;
int WaterLevelPercentage = 0;

void loop() {

  if (!isManualMode) {
    int Timer = analogRead(TimerPin);
    int WaterLevel = analogRead(WaterLevelPin);

    TimerPercentage = map(Timer, 0, 1023, 0, 10);
    WaterLevelPercentage = map(WaterLevel, 0, 1023, 1, 11);

    buttonState = digitalRead(buttonPin);
  }

  if (Serial.available()) {
    String RecievedMsg = Serial.readStringUntil('\n');
    if (RecievedMsg.length() > 0) {
      if (RecievedMsg.indexOf(':') != -1) {
        // colon exists in the string
        int separatorIndex = RecievedMsg.indexOf(':');
        String Key = RecievedMsg.substring(0, separatorIndex);
        String Value = RecievedMsg.substring(separatorIndex + 1);
        // if (SerialPrint == true) {
        // Serial.println(RecievedMsg);
        Serial.println("Key:" + Key);
        Serial.println("Value:" + Value);
        // }

        // SerialReciverdString = "";
        if (Key == "ManualMode") {
          isManualMode = true;

        } else if (Key == "AutoMode") {
          isManualMode = false;
        }

        if (isManualMode) {
          if (Key == "Timer") {
            TimerPercentage = Value.toInt();
          } else if (Key == "WaterLevevl") {
            WaterLevelPercentage = Value.toInt();
          } else if (Key == "Start") {
            buttonState = 1;
          }


          if (Key == "WaterPump") {
            if (Value == "0") {
              digitalWrite(WashingMotorLED, LOW);
              digitalWrite(WaterPumpLED, LOW);
            } else {
              digitalWrite(WashingMotorLED, LOW);
              digitalWrite(WaterPumpLED, HIGH);
            }

          } else if (Key == "WashingMotor") {
            if (Value == "0") {
              digitalWrite(WashingMotorLED, LOW);
              digitalWrite(WaterPumpLED, LOW);
            } else {
              digitalWrite(WashingMotorLED, HIGH);
              digitalWrite(WaterPumpLED, LOW);
            }
          }
        }
      }
    }
  }

  // if (!isManualMode) {

  if (!isCompleteWashing) {

    if (buttonState == HIGH) {
      isWashingStart = true;
      Serial.println("WashingMotorStart:0");
      digitalWrite(WashingMotorLED, LOW);
      digitalWrite(WaterPumpLED, HIGH);
    }

    if (!isWashingStart) {

      Serial.print("T:");
      Serial.println(TimerPercentage * 10);
    } else {
      Serial.print("W:");
      Serial.println(WaterLevelPercentage);

      if (WaterLevelPercentage == 11) {
        Serial.print("Washing:");
        Serial.println(22 - TimerPercentage);

        digitalWrite(WashingMotorLED, HIGH);
        digitalWrite(WaterPumpLED, LOW);
        for (int i = TimerPercentage; 0 <= i; i--) {


          Serial.print("T:");
          Serial.println(i * 10);
          delay(1000);
        }
        Serial.println("WashingComplete:0");
        isCompleteWashing = true;
        digitalWrite(WashingMotorLED, LOW);
        digitalWrite(WaterPumpLED, LOW);
      }
    }
  }
  // }
}
