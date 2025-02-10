# Car Rental Management System
Welcome to the Car Rental Management System repository. This application is designed to streamline the process of managing car rentals, offering a user-friendly interface and robust functionality.

## Table of Contents
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)


## Features
- Vehicle Management: Add, update, and remove vehicles from the inventory.
- Customer Management: Manage customer information efficiently.
- Rental Transactions: Handle rental bookings, returns, and track rental history.
- User Authentication: Secure login system with role-based access control.
- Reporting: Generate reports on rentals, returns, and vehicle availability.

## Prerequisites
Before you begin, ensure you have the following installed:

- Visual Studio 2022
- .NET Framework 4.8
- DevExpress Components

## Installation
- Clone the Repository:

git clone https://github.com/frauvate/rentacar.git
cd rentacar

- Open the Solution:

Launch Visual Studio.
Open the CarRentalManagementSystem.sln solution file.

- Restore NuGet Packages:

In Visual Studio, navigate to Tools > NuGet Package Manager > Manage NuGet Packages for Solution.
Restore any missing packages.

- Configure the Database:

Update the connection string in App.config to point to your SQL Server instance.
Run the provided SQL script located in the Setup directory to set up the database schema. 
At this step you also need to change the necessary parts in the code to your connection string.

- Build and Run:

Build the solution to ensure all dependencies are correctly configured.
Run the application.

## Usage
Upon launching the application:

- Login: Use the default administrator credentials provided in the setup documentation.
- Dashboard: Access an overview of system statistics.
- Vehicles: Manage the fleet by adding, editing, or removing vehicles.
- Customers: Maintain customer records.
- Rentals: Process new rentals and handle returns.
- Reports: Generate and view various reports.

## Project Structure
- CarRental: Contains the main application code.
-- Resources: Contains the assets used in app.
- Setup: Contains the setup file to install the app.

## Contributing
Contributions are wlcomed! To get started:

Fork the repository.
Create a new branch: git checkout -b feature-name.
Make your changes and commit them: git commit -m 'Add new feature'.
Push to the branch: git push origin feature-name.
Open a Pull Request.

Please ensure your code adheres to general coding standards and includes appropriate tests.

## License
This project is licensed under the GPL-3.0 License.

## Contact
For questions or support, please open an issue in this repository.
You can also contact via e-mail: esmaasyldrm@gmail.com 
