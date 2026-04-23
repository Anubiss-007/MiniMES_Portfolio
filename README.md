# 🏭 Mini MES Dashboard (Smart Factory Portfolio)

## 📌 Overview
This project is a web-based **Manufacturing Execution System (MES)** dashboard designed to monitor daily production data and track machine statuses. It was developed to demonstrate skills in **ASP.NET Core MVC (C#)**, **Web Application Development**, and **Smart Factory / EAP concepts**, specifically tailored for the PCB manufacturing industry.

## ✨ Key Features
* **📊 Production Dashboard:** Visualizes daily production metrics (Target vs. Actual) and calculates the overall Yield Rate automatically.
* **📈 Interactive Charts:** Utilizes Chart.js to compare production trends over time.
* **📡 Machine Status Monitor:** Simulates Equipment Application Programming (EAP) by tracking machine states (e.g., SMT Line, Wave Soldering) with color-coded status cards (Running/Idle/Down).
* **💾 Data Management:** Logs daily production data and defect quantities into a database.
* **📁 Export Data:** Ability to export production reports to CSV format.

## 🛠️ Tech Stack
* **Backend:** C#, ASP.NET Core MVC (.NET 10)
* **Frontend:** Razor Views (`.cshtml`), HTML5, Bootstrap 5, JavaScript, Chart.js
* **Database:** SQLite, Entity Framework Core (EF Core)
* **Architecture:** MVC (Model-View-Controller)

## 🚀 How to Run Locally
1. Ensure you have the [.NET SDK](https://dotnet.microsoft.com/) installed on your machine.
2. Clone this repository:
   ```bash
   git clone [https://github.com/Anubiss-007/MiniMES_Portfolio.git](https://github.com/Anubiss-007/MiniMES_Portfolio.git)
