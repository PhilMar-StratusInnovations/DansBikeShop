Welcome to Dan's Bike Shop!

Dam is opening a new bike shop, and has asked his brother-in-law, a software developer, for an application to help manage his inventory.
This solution contains a subset of functionality needed by the application.  For simplicity, the different layers are contained within folders
in the DansBikeShop.Core project instead of contains in different projects.  This project was constructed using Visual Studio 2019.
 
Please implement the rest of the functionality outlined below:

- Concrete data access repository for bikes.  You can build code to call stored procedures, or to use an ORM.  For stored procedures, 
  you just need to write code that calls the stored procedure by name; you are NOT required to write the stored procedures.  Your repository 
  should derive from the IBikeRepository interface

 - Data Access dependency injection registration, inside the Configuration class.

- Business Layer bike inventory manager.  You should implement the IBikeInventoryManager interface. The methods in this object should use
  a dependency-injected bike repository.

- Business Layer dependency injection registration, inside the Configuration class.

- A lightweight REST API in a new project.  Note there is no template for this; you may write this in .NET Core or .NET Framework.  The included C# project, 
  that should be used by your API project, is targeting .NET Standard 2.1.

- Each interface also contains some advanced capabilities.  These are optional for this exercise, but please complete them if you can.

- The API project should call the business and data access configuration methods to ensure that the dependency injection registration 
  is performed.

- You may assume that no authorization is required for the API, however you may add authorization to demonstrate your capabilities.

- The solution should run in a Docker container.


Please note any improvements that you think should be made. If you would prefer a radically different architecture (such as CQRS), feel free
to implement the application in that architecture.