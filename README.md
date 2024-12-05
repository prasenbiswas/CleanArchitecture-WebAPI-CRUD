# Clean Architecture with Web API CRUD Operations

## **What is Clean Architecture?**

Clean Architecture is a software design principle that organizes code to achieve:  

- **Separation of Concerns**: Divides the application into distinct layers, each with specific responsibilities.  
- **Scalability**: Simplifies adding new features without affecting existing ones.  
- **Testability**: Allows for isolated testing of application components.  
- **Maintainability**: Makes it easier to understand and modify the codebase over time.  

--- 
![image](https://github.com/user-attachments/assets/0b6a536e-295e-4a45-9e9d-878e9d3b55c1)
---

### **Clean Architecture Layers**

1. **Domain Layer**  
   - Contains the core business logic and domain entities.  
   - Independent of external libraries or frameworks.  

2. **Application Layer**  
   - Contains use cases, business rules, and validation logic.  
   - Implements the CQRS pattern using **MediatR**.  

3. **Infrastructure Layer**  
   - Handles database access, external APIs, and third-party integrations.  
   - Contains Entity Framework DbContext and migrations.    
---

### **Advantages of Clean Architecture**

- Reduces code coupling, making the system more modular.  
- Facilitates testing by isolating business rules from frameworks.  
- Enhances flexibility for switching or upgrading frameworks and tools.  
- Improves maintainability and scalability of the application.   
---

# .NET Core 8 Web API - CRUD Operations

This project demonstrates how to build a Web API in .NET Core 8 with support for Create, Read, Update, and Delete (CRUD) operations. It is designed as a reference for building RESTful APIs using the latest .NET Core features and best practices.

## Features

- **Entity Framework Core** for database interaction.
- **Dependency Injection** to manage services and repositories.
- **RESTful Endpoints** for CRUD operations.

## Endpoints Overview

1. **Create**: Adds a new record to the database.  
   `POST /api/[controller]`

2. **Read**: Retrieves data from the database.  
   - Get all: `GET /api/[controller]`  
   - Get by ID: `GET /api/[controller]/{id}`

3. **Update**: Modifies an existing record.  
   `PUT /api/[controller]/{id}`

4. **Delete**: Removes a record from the database.  
   `DELETE /api/[controller]/{id}`

--- 

## Getting Started

Follow these steps to set up and run the project locally:

## Prerequisites

- **Visual Studio** (2022 or later)
- **.NET Core 8 SDK**
- **SQL Server** (or the specified database provider)
- **Entity Framework Core Tools**

## Getting Started

1. **Clone the Repository**  
   Clone the repository to your local machine using the following command:  
   ```bash
   git clone https://github.com/prasenbiswas/CleanArchitecture-WebAPI-CRUD.git
   cd CleanArchitecture-WebAPI-CRUD
   ```

2. **Update Connection String**  
   - Navigate to the `appsettings.json` file in the Web API project.  
   - Update the `ConnectionStrings` section with your database details. Example:  
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;Trusted_Connection=True;MultipleActiveResultSets=true"
     }
     ```
   - Replace `YOUR_SERVER_NAME` and `YOUR_DATABASE_NAME` with your actual database server name and database name.

3. **Open in Visual Studio**  
   Open the `.sln` file in Visual Studio.

4. **Apply Migrations**  
   - Open the **Package Manager Console** from the **Tools > NuGet Package Manager > Package Manager Console** menu.
   - In the **Default project** dropdown, select the **Infrastructure** layer (the layer containing the `DbContext` and migrations).
   - Run the following command to apply the database migrations:  
     ```powershell
     Update-Database
     ```

5. **Run the Project**  
   - Press `F5` or click the **Run** button in Visual Studio.
   - The API will be hosted locally (e.g., `https://localhost:5001`).

6. **Test the API**  
   Use Swagger UI or your preferred API testing tool (e.g., Postman) to explore the endpoints.
