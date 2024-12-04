# Clean Architecture with Web API CRUD Operations

## **What is Clean Architecture?**

Clean Architecture is a software design principle that organizes code to achieve:  

- **Separation of Concerns**: Divides the application into distinct layers, each with specific responsibilities.  
- **Scalability**: Simplifies adding new features without affecting existing ones.  
- **Testability**: Allows for isolated testing of application components.  
- **Maintainability**: Makes it easier to understand and modify the codebase over time.  

### **Core Principles**

1. **Independent of Frameworks**  
   The architecture does not depend on external libraries or frameworks, making it adaptable and portable.

2. **Testability**  
   Business rules and logic can be tested independently of other layers.  

3. **Separation of Concerns**  
   Divides the application into layers to ensure that changes in one layer do not impact others unnecessarily.  

4. **Dependency Rule**  
   Higher-level modules (business rules) do not depend on lower-level modules (infrastructure, frameworks). Instead, dependencies flow inward.  

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
![image](https://github.com/user-attachments/assets/0b6a536e-295e-4a45-9e9d-878e9d3b55c1)

---

### **Advantages of Clean Architecture**

- Reduces code coupling, making the system more modular.  
- Facilitates testing by isolating business rules from frameworks.  
- Enhances flexibility for switching or upgrading frameworks and tools.  
- Improves maintainability and scalability of the application.   

--- 
