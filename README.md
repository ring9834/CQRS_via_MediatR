
# CQRS using MediatR
This is a code example of how to use CQRS design pattern using MediatR which itself is a design pattern of Mediator. Below is a UML diagram illustrating the detailed design for CQRS usage via C#. It looks like a bit complicated of the diagram, however showcasing a concrete use case clearly and logically, which may require you to take a little bit time to get familiar with how to employ CQRS pattern in practical projects.

![UML](https://photos.fife.usercontent.google.com/pw/AP1GczPkWqVWwBh9hOwCz9h5TaSrQrM7wzoOA9LoKLDZSD4LdliXltuuOO0=w1074-h956-s-no-gm?authuser=0)

Among the project assemblies, the ones of Infrastructure, Components, Api are what you should put emphasis on exploring and studing.

## Api
Serving as the primary interface for the application, the API is built using .NET and is responsible for routing incoming requests. This involves directing requests to their respective handlers within the "Components" section. Additionally, the "Api" domain encompasses the creation of Data Transfer Objects (DTOs) that bridge the gap between the API and the components, along with filters like action and authorization filters, if needed.

## Components
At the heart of the application's business logic, the "Components" domain handles all CRUD (Create, Read, Update, Delete) operations. This domain is subdivided into queries (for read operations) and commands (for write operations), adhering to the principles of Command Query Responsibility Segregation (CQRS).


## Infrastructure
The "Infrastructure" section addresses cross-cutting concerns and setup tasks. This includes implementing authentication, Cross-Origin Resource Sharing (CORS), middleware, and more. Notably, the infrastructure layer incorporates the concepts of CQRS, employing a mediator, command, query, and event bus pattern to facilitate communication and interaction between components.

