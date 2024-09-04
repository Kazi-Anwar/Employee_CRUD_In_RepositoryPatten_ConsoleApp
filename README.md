# Employee CRUD Console App

This repository contains a C# console application that implements the Repository Pattern to manage employee records. The application uses the .NET Framework and stores data in an XML file. It provides a basic interface for creating, reading, updating, and deleting employee records.

## Features

- **CRUD Operations**: Create, Read, Update, and Delete employee records.
- **Repository Pattern**: Implements the repository pattern to separate data access logic from business logic.
- **XML Data Storage**: Stores employee data in an XML file for persistence.

## Getting Started

### Prerequisites

- **.NET Framework**: This application is built on the .NET Framework. Ensure you have the .NET Framework installed on your machine.
- **IDE**: Use an IDE like Visual Studio for development and running the console application.

### Installation

1. **Clone the Repository**

   ```sh
   git clone https://github.com/Kazi-Anwar/Employee_CRUD_In_RepositoryPatten_ConsoleApp.git
   ```

2. **Navigate to the Project Directory**

   ```sh
   cd Employee_CRUD_In_RepositoryPatten_ConsoleApp
   ```

3. **Open the Solution**

   Open the `.sln` file with your IDE (e.g., Visual Studio).

4. **Restore NuGet Packages**

   If you're using Visual Studio, it will typically restore the necessary NuGet packages automatically. Otherwise, run:

   ```sh
   dotnet restore
   ```

5. **Build the Project**

   Build the solution to ensure everything is set up correctly:

   ```sh
   dotnet build
   ```

6. **Run the Application**

   Start the console application:

   ```sh
   dotnet run
   ```

## Usage

Once the application is running, you can interact with it via the console interface. You can perform the following actions:

1. **Add an Employee**: Input employee details to add a new record.
2. **View Employees**: List all existing employee records.
3. **Update an Employee**: Modify details of an existing employee record.
4. **Delete an Employee**: Remove an employee record from the system.

## Repository Pattern

The repository pattern is used to abstract the data access layer from the business logic. This approach:

- **Improves Maintainability**: Changes in data access logic do not affect business logic.
- **Encourages Testability**: Allows for easier unit testing of business logic.

The repository pattern in this project is implemented as follows:

- **IRepository Interface**: Defines the basic CRUD operations.
- **EmployeeRepository**: Implements the `IRepository` interface and handles XML file operations.

## XML Data Storage

Employee data is stored in an XML file named `employees.xml`. The XML file is read and written to by the `EmployeeRepository` class. The structure of the XML file corresponds to the `Employee` class properties.

## Contributing

Contributions to this project are welcome. Please follow these steps to contribute:

1. **Fork the Repository**
2. **Create a New Branch**
3. **Make Your Changes**
4. **Commit Your Changes**
5. **Push to Your Fork**
6. **Open a Pull Request**

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Contact

For any questions or issues, please [contact me on GitHub](https://github.com/Kazi-Anwar).
