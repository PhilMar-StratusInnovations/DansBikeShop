Welcome to Dan's Bike Shop!

Dam is opening a new bike shop, and has asked his brother-in-law, a software developer, for an application to help manage his inventory.
This solution contains a subset of functionality needed by the application.  For simplicity, the different layers are contained within folders
in the DansBikeShop.Core project instead of contains in different projects.  This project was constructed using Visual Studio 2019.
 
 The requirements are as follows:

- Various client application types will need to access the management functionality remotely, so the functionality needs
  to be exposed in a way that supports this via a REST API, following OpenAPI standard.  Please generate documentation via Swagger or 
  provide brief documentation  

- Initial functionality is to perform CRUD-type operations for bikes to a data store.  

- Dependency injection to support unit tests.

- Update this file with anything necessary for another developer to work on the project.

- Bonus points for allowing for searching with various criteria.

- Bonus points for persistent data store implementation.

- Bonus points for a UI client for the above functionality

- Bonus points for Authorization

- The solution should run in a Docker container.

Please submit a pull reques with your changes.  Also feel free to note any improvements that you think should be made. 
If you would prefer a radically different architecture (such as CQRS), feel free to implement the application in that architecture.