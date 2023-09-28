# VoiceRecorder

The Voice Recorder Application is a simple Windows application that allows users to record audio and save it as a WAV file.
This README provides an overview of the code and functionality of the application. 

**Introduction**
The Voice Recorder App is a Windows desktop application built using C# and the NAudio library. It provides a straightforward
interface for recording audio, monitoringthe recording progress, and saving the recorded audio as a WAV file. 

**Prerequisites**
Before you can use or modify the Voice Recorder Application, ensure you have the following prerequisites:

- Windows operating system
- Visual Studio or another C# development environment installed
- NAudio library

**Getting Started**
1. Clone or download the source code of the Voice Recorder Application.
2. Open the project in your preferred C# development environment (e.g., Visual Studio).
3. Ensure that you have the NAudio library referenced in your project. If not, you can install it using NuGet Package Manager.
4. Build the project to ensure there are no compilation errors.

**Application Features**
Record Audio: You can start recording audio by clicking the "Record" button. The application captures audio from the default recording device and displays the recording progress in a progress bar.

Stop Recording: To stop the recording, click the "Stop" button. The recorded audio is saved as a WAV file in the application's directory with a timestamped filename.

Monitoring Progress: The application includes a progress bar that displays the recording progress as a percentage.

**Code Structure**
App.xaml.cs: This file contains the code for the application's main logic. It handles the initialization of the recording process, updates the recording progress, and manages the recording and saving of audio.
MainWindow.xaml.cs: This file contains the code for the application's main window. It handles user interactions, such as clicking the "Record" and "Stop" buttons.

**Usage**
1. Launch the Voice Recorder Application.
2. Click the "Record" button to start recording audio.
3. Monitor the recording progress in the progress bar.
4. Click the "Stop" button to stop recording.
5. A message box will appear, indicating that the recording is finished, and it will display the filename where the audio was saved.
6. Locate the saved audio file in the application's directory.

**License**
This Voice Recorder Application is provided under the MIT License. You are free to use, modify, and distribute the code as per the terms of the license. Please refer to the LICENSE file for more details.

Enjoy using the Voice Recorder Application! If you have any questions or encounter any issues, feel free to reach out to the developers.
