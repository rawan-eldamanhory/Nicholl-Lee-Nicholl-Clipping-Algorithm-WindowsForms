# Nicholl–Lee–Nicholl Line Clipping Algorithm

This project is a Windows Forms application that demonstrates the **Nicholl–Lee–Nicholl (NLL) line clipping algorithm**, a classic computer graphics technique used to clip a line against a rectangular clipping window.

## 📌 Features
- Draws a rectangular clipping window
- Draws an input line
- Calculates and displays the clipped line segment
- Uses GDI+ for rendering
- Implemented fully in C# without external libraries

## 🧠 Algorithm Overview
The Nicholl–Lee–Nicholl algorithm is an efficient line clipping algorithm that reduces the number of intersection calculations by classifying the line endpoints relative to the clipping window.

This implementation handles different intersection cases:
- Left–Top
- Right–Top
- Left–Bottom
- Right–Bottom
- Left–Right
- Bottom–Top

## 🛠️ Technologies Used
- C#
- .NET Framework
- Windows Forms
- GDI+ (System.Drawing)

## ▶️ How to Run
1. Open `WindowsFormsApp1.sln` in Visual Studio
2. Build the solution
3. Run the project

## 📷 Output
- Black rectangle: clipping window
- Black line: original line
- Red line: clipped result

## 🎓 Purpose
This project was developed as part of a **college computer graphics assignment** to demonstrate understanding of line clipping algorithms.

## 📄 License
This project is for educational purposes.
