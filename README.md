# Library Management System

A comprehensive web-based application designed to digitalize and streamline the core operations of a traditional library. Built with ASP.NET Core MVC, this system provides a robust administrative dashboard, tracks book inventory, manages student borrowing records, and handles staff information.

## Features

- **Admin Dashboard:** Real-time metrics overview of registered students, total books, librarians, and active borrowings.
- **Authentication:** Secure login portal to restrict access to library management features.
- **Books Management:** Full CRUD operations for the library catalog with dynamic availability tracking.
- **Borrowing Workflow:** Seamlessly issue books to students and process returns, automatically updating catalog availability.
- **Student & Staff Management:** Maintain records of registered students and librarians.
- **Modern UI:** Premium, responsive user interface featuring a dark mode aesthetic, glassmorphism elements, and micro-animations.

## Technology Stack

- **Backend:** C#, ASP.NET Core MVC (.NET 8)
- **Database:** SQLite (Portable, zero-configuration local database)
- **Data Access:** 
  - Entity Framework Core (for Books and Borrowings)
  - ADO.NET (for Students, Librarians, and Dashboard metrics)
- **Frontend:** HTML5, CSS3, Bootstrap 5, FontAwesome, Google Fonts (Inter)

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) must be installed on your machine.

### Installation & Running

1. **Clone the repository**
   ```bash
   git clone https://github.com/adarshlilhare/Library-management-system-.git
   cd Library-management-system-
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Run the application**
   ```bash
   dotnet run
   ```

4. **Access the Application**
   - Open your web browser and navigate to the URL provided in the terminal (typically `http://localhost:5000` or `http://localhost:5149`).
   - Use the default admin credentials to log in:
     - **Username:** `admin`
     - **Password:** `12345`

## Project Structure

The project strictly follows the MVC architectural pattern:
- `/Models` - Data structures, database context, and business logic.
- `/Views` - Razor Pages (`.cshtml`) containing HTML and UI logic.
- `/Controllers` - Request handlers bridging the Views and Models.
- `/wwwroot` - Static assets including custom CSS, JavaScript, and Bootstrap files.

## Developed By
Adarsh Lilhare (Application No: IN26014850)
*Advanced Software Engineering & Development Internship (ASEDI)*
