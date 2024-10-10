#include <WiFi.h>
#include <ESPAsyncWebServer.h>
#include <Preferences.h>
#include "time.h"
#include <ESP32Servo.h>
#include <ESPmDNS.h>
#include <esp_sntp.h>  // Use esp_sntp.h instead of sntp.h
#include <esp_task_wdt.h>
#include "DHT.h"

// WiFi credentials
const char *ssid = "BELL306";
const char *password = "5C321CC364CF";

// NTP servers
const char *ntpServer1 = "pool.ntp.org";
const char *ntpServer2 = "time.nist.gov";
const long gmtOffset_sec = -18000;
const int daylightOffset_sec = 3600;

// Initialize server and preferences
AsyncWebServer server(80);
Preferences preferences;

// Servo motor and pin settings
Servo motor1, motor2, motor3, motor4;

#define SENSOR1_PIN 10
#define TRANSISTOR1_PIN 4
#define MOTOR1_PIN 18
#define MOTOR2_PIN 15
#define MOTOR3_PIN 16
#define MOTOR4_PIN 17
#define OPTO_LED_PIN 14
#define GREEN_LED_PIN 35
#define YELLOW_LED_PIN 36
#define RED_LED_PIN 39
#define BUZZER_PIN 37

#define TURN_DURATION_MOTOR1 1000 // Adjust this value as needed for MOTOR1
#define TURN_DURATION_MOTOR2 1100 // Adjust this value as needed for MOTOR2
#define TURN_DURATION_MOTOR3 1200 // Adjust this value as needed for MOTOR3
#define TURN_DURATION_MOTOR4 939  // Adjust this value as needed for MOTOR4
#define WAIT_DURATION 2500

// DHT sensor settings
#define DHTPIN 1    // Digital pin connected to the DHT sensor
#define DHTTYPE DHT22   // DHT 22 (AM2302)
DHT dht(DHTPIN, DHTTYPE);

const char index_html[] PROGMEM = R"rawliteral(
<!DOCTYPE HTML><html>
<head>
  <title>PharmaPal Web Server</title>
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <style>
    .form-group {
      margin-bottom: 10px;
    }
    .form-group label {
      display: inline-block;
      width: 100px;
    }
    .form-group input, .form-group select {
      width: 100px;
    }
  </style>
</head>
<body>
  <h1>PharmaPal Web Server</h1>
  <p>Welcome to PharmaPal!</p>
  <button onclick="triggerInstantAccess()">Instant Access</button>
  <h2>Schedule Pills</h2>
  <form id="scheduleForm" action="/schedule" method="POST" onsubmit="return validateForm()">
    <div class="form-group">
      <label for="compartment0">Compartment:</label>
      <select id="compartment0" name="compartment0">
        <option value="" selected disabled>Select</option>
        <option value="15">Compartment 1</option>
        <option value="16">Compartment 2</option>
        <option value="17">Compartment 3</option>
      </select>
      <label for="hour0">Hour:</label>
      <input type="number" id="hour0" name="hour0" min="0" max="23">
      <label for="minute0">Minute:</label>
      <input type="number" id="minute0" name="minute0" min="0" max="59">
    </div>
    <div class="form-group">
      <label for="compartment1">Compartment:</label>
      <select id="compartment1" name="compartment1">
        <option value="" selected disabled>Select</option>
        <option value="15">Compartment 1</option>
        <option value="16">Compartment 2</option>
        <option value="17">Compartment 3</option>
      </select>
      <label for="hour1">Hour:</label>
      <input type="number" id="hour1" name="hour1" min="0" max="23">
      <label for="minute1">Minute:</label>
      <input type="number" id="minute1" name="minute1" min="0" max="59">
    </div>
    <div class="form-group">
      <label for="compartment2">Compartment:</label>
      <select id="compartment2" name="compartment2">
        <option value="" selected disabled>Select</option>
        <option value="15">Compartment 1</option>
        <option value="16">Compartment 2</option>
        <option value="17">Compartment 3</option>
      </select>
      <label for="hour2">Hour:</label>
      <input type="number" id="hour2" name="hour2" min="0" max="23">
      <label for="minute2">Minute:</label>
      <input type="number" id="minute2" name="minute2" min="0" max="59">
    </div>
    <div class="form-group">
      <label for="compartment3">Compartment:</label>
      <select id="compartment3" name="compartment3">
        <option value="" selected disabled>Select</option>
        <option value="15">Compartment 1</option>
        <option value="16">Compartment 2</option>
        <option value="17">Compartment 3</option>
      </select>
      <label for="hour3">Hour:</label>
      <input type="number" id="hour3" name="hour3" min="0" max="23">
      <label for="minute3">Minute:</label>
      <input type="number" id="minute3" name="minute3" min="0" max="59">
    </div>
    <div class="form-group">
      <label for="compartment4">Compartment:</label>
      <select id="compartment4" name="compartment4">
        <option value="" selected disabled>Select</option>
        <option value="15">Compartment 1</option>
        <option value="16">Compartment 2</option>
        <option value="17">Compartment 3</option>
      </select>
      <label for="hour4">Hour:</label>
      <input type="number" id="hour4" name="hour4" min="0" max="23">
      <label for="minute4">Minute:</label>
      <input type="number" id="minute4" name="minute4" min="0" max="59">
    </div>
    <div class="form-group">
      <label for="compartment5">Compartment:</label>
      <select id="compartment5" name="compartment5">
        <option value="" selected disabled>Select</option>
        <option value="15">Compartment 1</option>
        <option value="16">Compartment 2</option>
        <option value="17">Compartment 3</option>
      </select>
      <label for="hour5">Hour:</label>
      <input type="number" id="hour5" name="hour5" min="0" max="23">
      <label for="minute5">Minute:</label>
      <input type="number" id="minute5" name="minute5" min="0" max="59">
    </div>
    <div class="form-group">
      <label for="compartment6">Compartment:</label>
      <select id="compartment6" name="compartment6">
        <option value="" selected disabled>Select</option>
        <option value="15">Compartment 1</option>
        <option value="16">Compartment 2</option>
        <option value="17">Compartment 3</option>
      </select>
      <label for="hour6">Hour:</label>
      <input type="number" id="hour6" name="hour6" min="0" max="23">
      <label for="minute6">Minute:</label>
      <input type="number" id="minute6" name="minute6" min="0" max="59">
    </div>
    <div class="form-group">
      <label for="compartment7">Compartment:</label>
      <select id="compartment7" name="compartment7">
        <option value="" selected disabled>Select</option>
        <option value="15">Compartment 1</option>
        <option value="16">Compartment 2</option>
        <option value="17">Compartment 3</option>
      </select>
      <label for="hour7">Hour:</label>
      <input type="number" id="hour7" name="hour7" min="0" max="23">
      <label for="minute7">Minute:</label>
      <input type="number" id="minute7" name="minute7" min="0" max="59">
    </div>
    <div class="form-group">
      <label for="compartment8">Compartment:</label>
      <select id="compartment8" name="compartment8">
        <option value="" selected disabled>Select</option>
        <option value="15">Compartment 1</option>
        <option value="16">Compartment 2</option>
        <option value="17">Compartment 3</option>
      </select>
      <label for="hour8">Hour:</label>
      <input type="number" id="hour8" name="hour8" min="0" max="23">
      <label for="minute8">Minute:</label>
      <input type="number" id="minute8" name="minute8" min="0" max="59">
    </div>
    <div class="form-group">
      <label for="compartment9">Compartment:</label>
      <select id="compartment9" name="compartment9">
        <option value="" selected disabled>Select</option>
        <option value="15">Compartment 1</option>
        <option value="16">Compartment 2</option>
        <option value="17">Compartment 3</option>
      </select>
      <label for="hour9">Hour:</label>
      <input type="number" id="hour9" name="hour9" min="0" max="23">
      <label for="minute9">Minute:</label>
      <input type="number" id="minute9" name="minute9" min="0" max="59">
    </div>
    <div class="form-group">
      <label for="compartment10">Compartment:</label>
      <select id="compartment10" name="compartment10">
        <option value="" selected disabled>Select</option>
        <option value="15">Compartment 1</option>
        <option value="16">Compartment 2</option>
        <option value="17">Compartment 3</option>
      </select>
      <label for="hour10">Hour:</label>
      <input type="number" id="hour10" name="hour10" min="0" max="23">
      <label for="minute10">Minute:</label>
      <input type="number" id="minute10" name="minute10" min="0" max="59">
    </div>
    <div class="form-group">
      <label for="compartment11">Compartment:</label>
      <select id="compartment11" name="compartment11">
        <option value="" selected disabled>Select</option>
        <option value="15">Compartment 1</option>
        <option value="16">Compartment 2</option>
        <option value="17">Compartment 3</option>
      </select>
      <label for="hour11">Hour:</label>
      <input type="number" id="hour11" name="hour11" min="0" max="23">
      <label for="minute11">Minute:</label>
      <input type="number" id="minute11" name="minute11" min="0" max="59">
    </div>
    <button type="submit">Add Schedule</button>
  </form>
  <h2>Sensor Data</h2>
  <p>Click the button to get sensor data:</p>
  <button onclick="getSensorData()">Get Sensor Data</button>
  <p id="sensorData"></p>
  <script>
    function triggerInstantAccess() {
      fetch('/trigger')
      .then(response => response.text())
      .then(data => alert(data))
      .catch(error => console.error('Error:', error));
    }
    
    function validateForm() {
      const form = document.getElementById('scheduleForm');
      for (let i = 0; i < 12; i++) {
        const compartment = form['compartment' + i].value;
        const hour = form['hour' + i].value;
        const minute = form['minute' + i].value;
        if (compartment !== '' && hour !== '' && minute !== '') {
          return true;  // At least one valid entry
        }
      }
      alert('Please fill at least one schedule.');
      return false;  // No valid entries found
    }

    function getSensorData() {
      fetch('/sensor')
        .then(response => response.json())
        .then(data => {
          document.getElementById('sensorData').innerText =
            `Temperature: ${data.temperature} °C\nHumidity: ${data.humidity} %\nHeat Index: ${data.heatIndex} °C`;
        });
    }
  </script>
</body>
</html>
)rawliteral";

struct Schedule {
  int hour;
  int minute;
  int servoPin;
};

std::vector<Schedule> schedules;

void resetWatchdog() {
  esp_task_wdt_reset();
}

void saveSchedules() {
  preferences.begin("schedules", false);
  preferences.clear();
  preferences.putUInt("count", schedules.size());
  for (size_t i = 0; i < schedules.size(); i++) {
    preferences.putInt(("hour" + String(i)).c_str(), schedules[i].hour);
    preferences.putInt(("minute" + String(i)).c_str(), schedules[i].minute);
    preferences.putInt(("servoPin" + String(i)).c_str(), schedules[i].servoPin);
  }
  preferences.end();
}

void loadSchedules() {
  preferences.begin("schedules", true);
  int count = preferences.getUInt("count", 0);
  schedules.clear();
  for (int i = 0; i < count; i++) {
    int hour = preferences.getInt(("hour" + String(i)).c_str());
    int minute = preferences.getInt(("minute" + String(i)).c_str());
    int servoPin = preferences.getInt(("servoPin" + String(i)).c_str());
    schedules.push_back({hour, minute, servoPin});
  }
  preferences.end();
}

void printLocalTime() {
  struct tm timeinfo;
  if (!getLocalTime(&timeinfo)) {
    Serial.println("No time available (yet)");
    return;
  }
  Serial.println(&timeinfo, "%A, %B %d %Y %H:%M:%S");
}

void timeavailable(struct timeval *t) {
  Serial.println("Got time adjustment from NTP!");
  printLocalTime();
}

void performFullTurn(Servo &servo, int duration) {
  servo.write(180);
  unsigned long startTime = millis();
  while (millis() - startTime < duration) {
    delay(10);
    resetWatchdog();
  }
  servo.write(90);
}

void blinkGreenAndBuzzer() {
  Serial.println("Starting blinking Green LED and sounding Buzzer");
  digitalWrite(OPTO_LED_PIN, HIGH);
  unsigned long startTime = millis();
  while (millis() - startTime < 4000) {
    digitalWrite(GREEN_LED_PIN, HIGH);
    digitalWrite(BUZZER_PIN, HIGH);
    delay(500);
    resetWatchdog();
    digitalWrite(GREEN_LED_PIN, LOW);
    digitalWrite(BUZZER_PIN, LOW);
    delay(500);
    resetWatchdog();
  }
  digitalWrite(OPTO_LED_PIN, LOW);
  Serial.println("Finished blinking Green LED and sounding Buzzer");
}

void blinkYellow() {
  Serial.println("Starting blinking Yellow LED");
  digitalWrite(OPTO_LED_PIN, HIGH);
  unsigned long startTime = millis();
  while (millis() - startTime < 4000) {
    digitalWrite(YELLOW_LED_PIN, HIGH);
    delay(500);
    resetWatchdog();
    digitalWrite(YELLOW_LED_PIN, LOW);
    delay(500);
    resetWatchdog();
  }
  digitalWrite(OPTO_LED_PIN, LOW);
  Serial.println("Finished blinking Yellow LED");
}

bool checkSensor(int sensorPin, int transistorPin) {
  Serial.println("Checking sensor...");
  digitalWrite(transistorPin, HIGH);
  bool sensorDetected = digitalRead(sensorPin) == HIGH;
  digitalWrite(transistorPin, LOW);
  Serial.print("Sensor detected: ");
  Serial.println(sensorDetected ? "Yes" : "No");
  return sensorDetected;
}

void checkSchedules() {
  struct tm timeinfo;
  if (!getLocalTime(&timeinfo)) {
    return;
  }

  for (auto it = schedules.begin(); it != schedules.end(); ++it) {
    if (timeinfo.tm_hour == it->hour && timeinfo.tm_min == it->minute) {
      Servo *servo;
      int duration;
      switch (it->servoPin) {
        case MOTOR2_PIN: 
          servo = &motor2; 
          duration = TURN_DURATION_MOTOR2; 
          break;
        case MOTOR3_PIN: 
          servo = &motor3; 
          duration = TURN_DURATION_MOTOR3; 
          break;
        case MOTOR4_PIN: 
          servo = &motor4; 
          duration = TURN_DURATION_MOTOR4; 
          break;
        default: 
          continue; // Invalid motor pin, skip this schedule
      }
      for (int i = 0; i < 3; i++) {
        performFullTurn(*servo, duration);

        unsigned long startTime = millis();
        while (millis() - startTime < WAIT_DURATION) {
          if (checkSensor(SENSOR1_PIN, TRANSISTOR1_PIN)) {
            Serial.println("Sensor detected something. Stopping further turns.");
            blinkGreenAndBuzzer();
            schedules.erase(it);
            saveSchedules();
            return;
          }
          delay(10);
          resetWatchdog();
        }
      }

      blinkYellow();
      schedules.erase(it);
      saveSchedules();
      return;
    }
  }
}

void instantAccess() {
  Serial.println("Starting instant access...");
  for (int i = 0; i < 3; i++) {
    performFullTurn(motor1, TURN_DURATION_MOTOR1);

    unsigned long startTime = millis();
    while (millis() - startTime < WAIT_DURATION) {
      if (checkSensor(SENSOR1_PIN, TRANSISTOR1_PIN)) {
        Serial.println("Sensor detected something. Stopping further turns.");
        blinkGreenAndBuzzer();
        return;
      }
      delay(10);
      resetWatchdog();
    }
  }

  blinkYellow();
  Serial.println("Instant access complete.");
}

void setup() {
  Serial.begin(115200);

  // Initialize the Task Watchdog Timer with the correct configuration
  esp_task_wdt_config_t wdt_config = {
    .timeout_ms = 60000,  // Set timeout to 60 seconds
    .idle_core_mask = 0,  // Apply to all cores
    .trigger_panic = true
  };
  esp_task_wdt_init(&wdt_config);

  esp_task_wdt_add(NULL);  // Add current task to watchdog

  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
    resetWatchdog();
  }
  Serial.println(" CONNECTED");

  pinMode(SENSOR1_PIN, INPUT);
  pinMode(TRANSISTOR1_PIN, OUTPUT);
  pinMode(OPTO_LED_PIN, OUTPUT);
  pinMode(GREEN_LED_PIN, OUTPUT);
  pinMode(YELLOW_LED_PIN, OUTPUT);
  pinMode(RED_LED_PIN, OUTPUT);
  pinMode(BUZZER_PIN, OUTPUT);

  digitalWrite(GREEN_LED_PIN, LOW);
  digitalWrite(YELLOW_LED_PIN, LOW);
  digitalWrite(RED_LED_PIN, HIGH);  // Always on
  digitalWrite(BUZZER_PIN, LOW);
  digitalWrite(OPTO_LED_PIN, LOW);
  digitalWrite(TRANSISTOR1_PIN, LOW);

  motor1.attach(MOTOR1_PIN);
  motor2.attach(MOTOR2_PIN);
  motor3.attach(MOTOR3_PIN);
  motor4.attach(MOTOR4_PIN);

  loadSchedules();
  dht.begin();

  if (!MDNS.begin("pharmapal")) {
    Serial.println("Error setting up MDNS responder!");
    while (1) {
      delay(1000);
      resetWatchdog();
    }
  }
  Serial.println("mDNS responder started");

  sntp_set_time_sync_notification_cb(timeavailable);
  configTime(gmtOffset_sec, daylightOffset_sec, ntpServer1, ntpServer2);

  server.on("/", HTTP_GET, [](AsyncWebServerRequest *request){
    Serial.println("Root endpoint hit");
    request->send_P(200, "text/html", index_html);
  });

  server.on("/schedule", HTTP_POST, [](AsyncWebServerRequest *request){
    preferences.begin("schedules", false);
    preferences.clear();  // Clear previous schedules
    schedules.clear();

    for (int i = 0; i < 12; i++) {
      String compartmentParam = "compartment" + String(i);
      String hourParam = "hour" + String(i);
      String minuteParam = "minute" + String(i);

      if (request->hasParam(compartmentParam, true) && 
          request->hasParam(hourParam, true) && 
          request->hasParam(minuteParam, true)) {
        
        int compartment = request->getParam(compartmentParam, true)->value().toInt();
        int hour = request->getParam(hourParam, true)->value().toInt();
        int minute = request->getParam(minuteParam, true)->value().toInt();

        schedules.push_back({hour, minute, compartment});
        preferences.putInt(("hour" + String(i)).c_str(), hour);
        preferences.putInt(("minute" + String(i)).c_str(), minute);
        preferences.putInt(("compartment" + String(i)).c_str(), compartment);
      }
    }

    preferences.putUInt("count", schedules.size());
    preferences.end();

    request->send(200, "text/plain", "Schedules updated");
  });

  server.on("/trigger", HTTP_GET, [](AsyncWebServerRequest *request){
    Serial.println("/trigger endpoint hit");
    instantAccess();
    request->send(200, "text/plain", "Instant Access Executed");
  });

  server.on("/sensor", HTTP_GET, [](AsyncWebServerRequest *request){
    float humidity = dht.readHumidity();
    float temperature = dht.readTemperature();
    float heatIndex = dht.computeHeatIndex(temperature, humidity, false);

    if (isnan(humidity) || isnan(temperature)) {
      request->send(500, "text/plain", "Failed to read from DHT sensor!");
      return;
    }

    String json = "{\"temperature\":" + String(temperature) + ",\"humidity\":" + String(humidity) + ",\"heatIndex\":" + String(heatIndex) + "}";
    request->send(200, "application/json", json);
  });

  server.begin();
  Serial.println("HTTP server started");
}

void loop() {
  resetWatchdog();
  delay(4000);  // Minimal delay to prevent watchdog timeout
  printLocalTime();
  checkSchedules();
}
