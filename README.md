PharmaPal: Smart IoT Pill Dispenser
PharmaPal is an elder-friendly, automated pill dispensing system designed to improve medication management and adherence. This repository contains the source code for both the Visual Studio C# .NET application and the Arduino C++ code, which controls the hardware components.

Project Overview
PharmaPal integrates multiple hardware components such as an ESP32-S3 microcontroller, servo motors, LEDs, a buzzer, an optical sensor, and temperature and humidity sensors to create a smart and reliable system. Users can manage their medication schedules through a user-friendly .NET Windows Forms application that interacts with the IoT system.

Features
Automated Dispensing: Pills are dispensed based on predefined schedules or on-demand using the application interface.
Environmental Monitoring: Built-in sensors monitor temperature and humidity, ensuring optimal storage conditions for medications.
Visual and Audible Alerts: LEDs and a buzzer provide real-time notifications for successful or unsuccessful pill dispensing.
User-Friendly Application: The C# application allows users to manage schedules, monitor system status, and access medications instantly.
Components
Microcontroller: ESP32-S3 WROOM
Servo Motors: 4 units, used to drive a multi-compartment carousel system
Optical Sensor: Verifies successful pill dispensing
Temperature & Humidity Sensor: Ensures pills are stored in optimal conditions
LED Indicators: Red (power on), Green (successful dispensing), Yellow (error indication)
Buzzer: Provides audible confirmation of pill dispensing
Software Setup
.NET Application
The C# .NET application is built using Windows Forms and requires the .NET Framework to run. The application interface includes:

Login Form: User authentication before accessing system controls.
Main Dashboard: Displays environmental data (temperature, humidity, heat index) and allows instant access dispensing.
Schedule Wizard: Tool for configuring medication schedules using a 24-hour format.
Arduino Code (ESP32-S3)
The C++ code, written for the Arduino IDE, runs on the ESP32-S3 microcontroller. It manages the following:

Sensor data acquisition (temperature, humidity, and pill detection)
HTTP communication with the .NET application for real-time updates
Servo motor control for accurate pill dispensing
Getting Started
Prerequisites
Visual Studio with .NET Framework for the Windows Forms application.
Arduino IDE for programming the ESP32-S3 microcontroller.
