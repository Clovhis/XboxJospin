# Xbox Joystick Tester & Diagnostics

This repository contains a minimal Windows Forms application for testing Xbox controllers.

## Building

1. Open `XboxJoystickTester.sln` with Visual Studio 2022 or newer on Windows.
2. Restore NuGet packages if needed.
3. Build the solution in **Release** mode.
4. Run or publish to produce an executable `.exe`.

## Features

- Real-time display of button states and analog stick positions.
- Trigger values shown as progress bars.
- Simple vibration test with adjustable intensity for each motor.

The code can be extended to add detailed diagnostics and PDF report generation.

## Continuous Integration

Pushes to branches starting with `Feature/` automatically trigger a GitHub Actions workflow that builds the project and publishes a `.exe` to the repository Releases.
The workflow grants write access to the generated release using `permissions: write-all` so that the built executable can be uploaded automatically.
