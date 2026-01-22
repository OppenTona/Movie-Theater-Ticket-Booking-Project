# 🎬 Movie Theater Ticket Booking System

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-blue.svg)](https://dotnet.microsoft.com/download/dotnet-framework/net48)
[![Platform](https://img.shields.io/badge/Platform-Windows-lightgrey.svg)](https://www.microsoft.com/)

A comprehensive movie theater ticket booking application built with C# Windows Forms and SQL Server. This project demonstrates a complete cinema seat reservation system with interactive seat selection and real-time pricing.

## 📋 Table of Contents

- [Features](#features)
- [Screenshots](#screenshots)
- [Technology Stack](#technology-stack)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Database Setup](#database-setup)
- [Configuration](#configuration)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## ✨ Features

### 🎫 Seat Management
- **Interactive Seat Map**: Visual seat selection with 6x6 grid layout (A-F rows, 1-6 columns)
- **Real-time Availability**: Live seat status updates from database
- **Color-coded Status**: Different colors for available, selected, and booked seats
- **Multiple Selection**: Select multiple seats in one transaction

### 💰 Dynamic Pricing
- **Tiered Pricing System**: 
  - Row A seats: 25,000 VND each
  - Row B seats: 30,000 VND each
  - Other rows: Variable pricing
- **Real-time Calculation**: Total price updates instantly with seat selection
- **Visual Feedback**: Selected seats highlighted in blue

### 🎭 Movie Selection
- **Movie Dropdown**: Select from available movies in database
- **Dynamic Loading**: Movies loaded from SQL Server database
- **Session Management**: Link bookings to specific movie sessions

### 💾 Database Integration
- **SQL Server Backend**: Robust data persistence
- **Real-time Updates**: Immediate seat status synchronization
- **Data Integrity**: Transactional booking system

## 📸 Screenshots

> **Note**: Video demonstration available as `Video_Review_The_Project.mp4` in the repository

## 🛠️ Technology Stack

- **Frontend**: Windows Forms (.NET Framework 4.8)
- **Backend**: C# 
- **Database**: Microsoft SQL Server
- **IDE**: Visual Studio 2013+
- **Architecture**: Desktop Application

## 📋 Prerequisites

Before running this application, ensure you have:

- **Windows OS** (Windows 7 or later)
- **.NET Framework 4.8** or later
- **Microsoft SQL Server** (Express/Standard/Enterprise)
- **Visual Studio 2013** or later (for development)
- **SQL Server Management Studio** (recommended)

## 🚀 Installation

### 1. Clone the Repository
```bash
git clone https://github.com/OppenTona/Movie-Theater-Ticket-Booking-Project.git
cd Movie-Theater-Ticket-Booking-Project
```

### 2. Open the Solution
- Navigate to `WindowsFormsApplication1/` folder
- Open `WindowsFormsApplication1.sln` in Visual Studio

### 3. Restore Dependencies
- Build the solution to restore NuGet packages
- Ensure all references are properly loaded

## 🗄️ Database Setup

### 1. Create Database
```sql
CREATE DATABASE QLXemPhim;
USE QLXemPhim;
```

### 2. Create Tables
```sql
-- Movie information table
CREATE TABLE info (
    Ten NVARCHAR(255) PRIMARY KEY,  -- Movie name
    A1 BIT, A2 BIT, A3 BIT, A4 BIT, A5 BIT, A6 BIT,  -- Row A seats
    B1 BIT, B2 BIT, B3 BIT, B4 BIT, B5 BIT, B6 BIT,  -- Row B seats
    C1 BIT, C2 BIT, C3 BIT, C4 BIT, C5 BIT, C6 BIT,  -- Row C seats
    D1 BIT, D2 BIT, D3 BIT, D4 BIT, D5 BIT, D6 BIT,  -- Row D seats
    E1 BIT, E2 BIT, E3 BIT, E4 BIT, E5 BIT, E6 BIT,  -- Row E seats
    F1 BIT, F2 BIT, F3 BIT, F4 BIT, F5 BIT, F6 BIT   -- Row F seats
);
```

### 3. Insert Sample Data
```sql
-- Add sample movies
INSERT INTO info (Ten) VALUES 
    ('Avengers: Endgame'),
    ('Spider-Man: No Way Home'),
    ('The Batman'),
    ('Top Gun: Maverick');
```

## ⚙️ Configuration

### Update Connection String
In `Form1.cs`, update the connection string to match your SQL Server setup:

```csharp
SqlConnection conn = new SqlConnection(@"Server=YOUR_SERVER_NAME; Database=QLXemPhim; Trusted_Connection=true");
```

**Common Connection String Formats:**
- **Local SQL Express**: `Server=.\\SQLEXPRESS; Database=QLXemPhim; Trusted_Connection=true`
- **Named Instance**: `Server=YOUR_PC_NAME\\INSTANCE_NAME; Database=QLXemPhim; Trusted_Connection=true`
- **SQL Authentication**: `Server=SERVER_NAME; Database=QLXemPhim; User Id=username; Password=password`

## 🎮 Usage

### 1. Launch Application
- Run the application from Visual Studio (F5) or execute the built .exe file

### 2. Select Movie
- Choose a movie from the dropdown menu
- The application loads the current seat availability for that movie

### 3. Book Seats
- Click on available seats (colored seats) to select them
- Selected seats turn blue and add to the total price
- Click selected seats again to deselect them

### 4. Complete Booking
- Review the total price in the "Đơn Giá" (Price) field
- Click "Thanh Toán" (Payment) to complete the booking
- Seat status updates in the database immediately

### 5. Seat Status Legend
- **Pink/Purple**: Available seats (Row A - 25,000 VND)
- **Light Blue**: Available seats (Row B - 30,000 VND)
- **Blue**: Selected seats
- **Gray/Disabled**: Already booked seats

## 📁 Project Structure

```
Movie-Theater-Ticket-Booking-Project/
├── README.md
├── Video_Review_The_Project.mp4           # Project demonstration
└── WindowsFormsApplication1/
    ├── WindowsFormsApplication1.sln       # Visual Studio solution
    ├── WindowsFormsApplication1.v12.suo   # Solution user options
    └── WindowsFormsApplication1/
        ├── Form1.cs                       # Main form logic
        ├── Form1.Designer.cs              # Form UI design
        ├── Form1.resx                     # Form resources
        ├── Program.cs                     # Application entry point
        ├── App.config                     # Application configuration
        ├── WindowsFormsApplication1.csproj # Project file
        └── Properties/
            ├── AssemblyInfo.cs            # Assembly information
            ├── Resources.resx             # Application resources
            └── Resources.Designer.cs      # Generated resources code
```

## 🔧 Key Components

### Form1.cs - Main Application Logic
- **Database Connection**: Manages SQL Server connectivity
- **Seat Management**: Handles seat selection and pricing logic
- **Event Handlers**: Processes user interactions with seats
- **Price Calculation**: Real-time price updates based on selections

### Database Schema
- **info table**: Stores movie information and seat availability
- **Seat columns**: A1-F6 representing the 6x6 seat grid
- **Boolean values**: 1 = booked, NULL = available

## 🎯 Core Features Implementation

### Seat Selection Algorithm
```csharp
// Price calculation based on seat row
if (row.BackColor == Color.FromArgb(255, 192, 255)) // Row A
{
    price += 25000; // Add Row A price
}
else if (row.BackColor == Color.FromArgb(192, 192, 255)) // Row B
{
    price += 30000; // Add Row B price
}
```

### Database Update System
```csharp
// Update seat status in database
SqlCommand cmd = new SqlCommand(
    "UPDATE info SET " + seatName + "= '1' WHERE Ten = '" + movieName + "'", 
    connection
);
```

## 🚀 Future Enhancements

- [ ] **User Authentication**: Login system for customers and staff
- [ ] **Payment Gateway**: Integration with online payment systems
- [ ] **Ticket Printing**: Generate physical/digital tickets
- [ ] **Movie Scheduling**: Advanced showtime management
- [ ] **Reporting**: Sales and occupancy analytics
- [ ] **Multi-theater Support**: Manage multiple cinema locations
- [ ] **Mobile App**: Companion mobile application
- [ ] **Web Interface**: Browser-based booking system

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request. For major changes:

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 Development Notes

- **Development Time**: Created in 30 minutes as a midterm project
- **Academic Score**: Achieved 9/10 points
- **Learning Objective**: Demonstrates Windows Forms, database integration, and event-driven programming
- **Code Style**: Academic project with room for production-level improvements

## 🐛 Known Issues

- Connection string is hardcoded (should be in configuration file)
- Limited error handling for database connectivity
- UI could be more responsive and modern
- No input validation for edge cases

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 📞 Contact

**Tona Nguyen** - [@OppenTona](https://github.com/OppenTona)

Project Link: [https://github.com/OppenTona/Movie-Theater-Ticket-Booking-Project](https://github.com/OppenTona/Movie-Theater-Ticket-Booking-Project)

---

### 🙏 Acknowledgments

- Built as part of academic coursework
- Demonstrates practical application of database-driven desktop applications
- Special thanks to instructors for guidance and evaluation

**⭐ If you find this project helpful, please consider giving it a star!**
