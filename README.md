##### this is a simple project just for learning some common web tech and arch 
##### It serves as a learning exercise for web application development, focusing on building a clean architecture design.
---

# Portfolio Management Web App

## Overview
This project is a simple portfolio management web application built using ASP.NET Core framework with C#. It serves as a learning exercise for web application development, focusing on building a clean architecture design.

The solution is structured into four inner projects:

1. **Web Presentation**
   - This project utilizes Razor Pages or a small MVC setup for presentation purposes. It handles user interface interactions and rendering of views.

2. **Infrastructure**
   - This class library implements a generic repository pattern for persisting data. It encapsulates data access logic, such as CRUD operations, and interacts with the database.

3. **App Core**
   - This class library contains business rules and domain logic. It defines generic interfaces for the generic repositories and unit of work, providing a structured approach to managing application logic.

4. **Web API**
   - This project serves as an alternative presentation layer, offering an API for different presentation methods. It allows for integration with external systems or client applications.

## Project Structure
- **Web Presentation**
  - Contains the user interface components, including Razor Pages or MVC controllers and views.
- **Infrastructure**
  - Implements data access logic using a generic repository pattern. It interacts with the database and provides data persistence functionalities.
- **App Core**
  - Defines business rules and domain logic. It includes generic interfaces for repositories and unit of work, promoting separation of concerns and modularity.
- **Web API**
  - Provides a RESTful API for accessing application data and functionalities. It offers a way for external systems or client applications to interact with the portfolio management system.

## Database Tables
The application uses the following tables in the database:
- **Owner**: Stores information about portfolio owners.
- **Project**: Contains details of projects managed within the portfolio.
- **Address**: Stores addresses associated with portfolio owners .

## Future Plans and feature 
In the future, we plan to:
- Implement a React project to consume the API, providing a modern and interactive user interface.
- Enhance the functionality of the application with additional features such as user authentication, project status tracking, and reporting capabilities.

## Getting Started
1. **Clone the Repository**
   ```bash
   git clone git@github.com:HasanKhadd0ur/CleanArchWebApp.git
   ```

2. **Set Up Database**
   - Modify the connection string in `appsettings.json` of the Web Presentation project to point to your database.
   - Run Entity Framework migrations to create or update the database schema.
   - there are a simple  seed data in the (DB Initiate folder )  
   ```bash
   dotnet ef database update
   ```

3. **Build and Run**
   - Build the solution using Visual Studio or the .NET CLI.
   ```bash
   dotnet build
   ```
   - Run the application.
   ```bash
   dotnet run --project <path_to_web_presentation_project>
   ```

4. **Access the Application**
   - Open a web browser and navigate to the URL where the application is hosted (typically `https://localhost:5001`).

## Contributing
Contributions are welcome! If you find any issues or have suggestions for improvements, feel free to open an issue or submit a pull request.

## License
This project is licensed under the [MIT License](LICENSE).

---
