# Robot Arm Simulator

A simple C# console application to simulate a 2-link planar robot arm using forward kinematics.

## Features
- User enters link lengths and joint angles.
- Computes end-effector (tip) position (X, Y).
- Useful for robotics and mechanical engineering education.

## Usage

1. Open a terminal in the project folder.
2. Build and run:
   ```sh
   dotnet new console -o robot-arm-simulator
   (Copy the files into the folder, overwrite Program.cs)
   dotnet run --project robot-arm-simulator
   ```
3. Enter the link lengths and joint angles as prompted.

## Example

```
=== Robot Arm Simulator ===
1. bağlantı (L1) uzunluğunu girin (ör. 10): 10
2. bağlantı (L2) uzunluğunu girin (ör. 7): 7

Eklem açılarını derece cinsinden girin (Çıkmak için boş bırak):
Theta 1 (omuz): 30
Theta 2 (dirsek): 45
Uç efektör pozisyonu: X = 13.00, Y = 10.34
```
