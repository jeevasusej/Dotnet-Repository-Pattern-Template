# RepositoryPatternTemplate
Dotnet repository pattern template with unit of work.
This is the basic setup for the repository pattern to work with and to understand how to implement.

In this example three layers has been used.<br />

Api - To expose the data to the user<br />
BL - Service Layer - Handle all the business logic and deal with the repository for CRUD<br />
Persistence- To deal with the persistence - Encapsulate large/complex queries.<br />
