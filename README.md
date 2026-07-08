# Pharmacy Management System

A desktop-based Pharmacy Management System built with **C#** and **.NET Framework 4.8** using Windows Forms. This application helps pharmacies manage their daily operations including medicine inventory, orders, and administrative tasks.

## 🚀 Features

- **Medicine Management** – Add, update, and track medicines in inventory
- **Order Management** – Create and manage customer orders
- **Admin Dashboard** – Centralized control panel for administrators
- **User-friendly Interface** – Built with Windows Forms for easy navigation
- **Role-based Access** – Separate dashboards and functionalities for different user roles

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET Framework 4.8
- **UI:** Windows Forms (WinForms)
- **Database:** SQL Server / LocalDB (assumed from typical .NET WinForms apps)
- **IDE:** Visual Studio

## 📁 Project Structure

| File | Description |
|------|-------------|
| `AdminDashboard.cs` | Main admin control panel |
| `AddMedicine.cs` | Form to add new medicines to inventory |
| `AddOrder.cs` | Form to create new orders |
| `*.Designer.cs` | Auto-generated UI layout files |
| `*.resx` | Resource files for UI components |

## ⚙️ Installation & Setup

1. **Clone the repository:**
   ```bash
   git clone https://github.com/kmaliha59/PharmacyManagenmentSystem-master.git
   ```

2. **Open in Visual Studio:**
   - Open the `.sln` solution file in Visual Studio 2019 or later.

3. **Restore NuGet Packages:**
   - Go to `Tools` → `NuGet Package Manager` → `Manage NuGet Packages for Solution` and restore any missing packages.

4. **Configure Database:**
   - Update the connection string in `App.config` (if applicable) to point to your SQL Server instance.
   - Run the database script (if provided) to create required tables.

5. **Build & Run:**
   - Press `F5` or click `Start` to run the application.

## 📝 License

This project is open-source. Please check the repository for license details.

## 👨‍💻 Author

-Built by: Maliha Khan
