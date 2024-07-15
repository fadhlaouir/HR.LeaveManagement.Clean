# Leave Management System

## Overview

This project is a Leave Management System built using .NET 7, following SOLID principles and Clean Architecture. It aims to provide a robust, scalable, and maintainable solution for managing employee leaves.

## Features

- User authentication and authorization
- Employee management
- Leave request management
- Approval workflow for leave requests
- Comprehensive data validation
- Role-based access control
- RESTful API endpoints
- Unit and integration testing

## Table of Contents

- [Getting Started](#getting-started)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Architecture](#architecture)
- [Technologies Used](#technologies-used)
- [Contributing](#contributing)
- [License](#license)

## Getting Started

To get a local copy of the project up and running, follow these steps.

### Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)

### Installation

1. **Clone the repository:**

    ```bash
    git clone https://github.com/your-username/leave-management-system.git
    cd leave-management-system
    ```

2. **Restore dependencies:**

    ```bash
    dotnet restore
    ```

3. **Apply database migrations:**

    ```bash
    dotnet ef database update
    ```

4. **Build the project:**

    ```bash
    dotnet build
    ```

5. **Run the application:**

    ```bash
    dotnet run
    ```

## Usage

- Access the API documentation at `http://localhost:5000/swagger`
- Use Postman or any other API client to interact with the endpoints
- Create, update, delete, and manage employees and leave requests

## Architecture

This project follows the Clean Architecture principles, ensuring a clear separation of concerns and promoting maintainability.

- **Domain Layer:** Contains the core business logic and domain entities
- **Application Layer:** Contains application-specific logic, use cases, and services
- **Infrastructure Layer:** Contains data access logic, external service integrations, and other infrastructure-related concerns
- **Presentation Layer:** Contains the API controllers and presentation logic

## Technologies Used

- **.NET 7:** Framework for building the application
- **Entity Framework Core:** ORM for database interactions
- **SQL Server:** Database management system
- **ASP.NET Core:** Framework for building web APIs
- **XUnit:** Testing framework for unit and integration tests

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create a new branch (`git checkout -b feature/your-feature`)
3. Commit your changes (`git commit -m 'Add some feature'`)
4. Push to the branch (`git push origin feature/your-feature`)
5. Open a pull request
