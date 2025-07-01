# Xbox Joystick Tester & Diagnostics

This repository contains a minimal Windows Forms application for testing Xbox controllers.

## Building

1. Open `XboxJoystickTester.sln` with Visual Studio 2022 or newer on Windows.
2. Restore NuGet packages if needed.
3. Build the solution in **Release** mode.
4. Choose **Publish** to create a self-contained **single-file** build for
   `win-x64`. The output will be written to `publish/` as
   `XboxJoystickTester.exe`. Compress this folder into a `.zip` archive so that
   anyone can unzip it and run the executable without installing .NET.

## Features

- Real-time display of button states and analog stick positions.
- Trigger values shown as progress bars.
- Simple vibration test with adjustable intensity for each motor.

The code can be extended to add detailed diagnostics and PDF report generation.

## Continuous Integration

Pushes to branches starting with `Feature/` automatically trigger a GitHub Actions workflow that builds the project and uploads a `.zip` containing the published files to the repository Releases.
The workflow grants write access to the generated release using `permissions: write-all` so that the portable archive can be uploaded automatically.

## En Criollo
Te bajás el .zip desde Releases (El stable release) descomprimis y ejecutás el .exe (Ponele que el AV te lo corra igual). 
