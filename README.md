
# CQRS using MediatR
This is a code example of how to use CQRS design pattern using MediatR which itself is a design pattern of Mediator. Below is a UML diagram illustrating the detailed design for CQRS usage via C#. It looks like a bit complicated of the diagram, however showcasing a concrete use case clearly and logically, which may require you to take a little bit time to get familiar with how to employ CQRS pattern in practical projects.

![UML](https://lh3.googleusercontent.com/pw/AP1GczOKAZ45HaEHccsvLghODJbdaUzPUfkPRN8pAEjFZIQNrGa2sEl2lIHAtdLhhMFbacI6QIioNjnJlG8NcxFvAyICCPyl3XS9DfVWr69uBSQN4GeDXqgmF_WO7tQRd3g8Gz5D3CgU_u7Hm1Vv8cyChiE=w1074-h956-s-no-gm?authuser=0)

Among the project assemblies, the ones of Infrastructure, Components, Api are what you should put emphasis on exploring and studing.

## Api
Serving as the primary interface for the application, the API is built using .NET and is responsible for routing incoming requests. This involves directing requests to their respective handlers within the "Components" section. Additionally, the "Api" domain encompasses the creation of Data Transfer Objects (DTOs) that bridge the gap between the API and the components, along with filters like action and authorization filters, if needed.

## Components
At the heart of the application's business logic, the "Components" domain handles all CRUD (Create, Read, Update, Delete) operations. This domain is subdivided into queries (for read operations) and commands (for write operations), adhering to the principles of Command Query Responsibility Segregation (CQRS).


## Infrastructure
The "Infrastructure" section addresses cross-cutting concerns and setup tasks. This includes implementing authentication, Cross-Origin Resource Sharing (CORS), middleware, and more. Notably, the infrastructure layer incorporates the concepts of CQRS, employing a mediator, command, query, and event bus pattern to facilitate communication and interaction between components.

## CQRS
CQRS stands for Command Query Responsibility Segregation. It is a pattern used in software architecture that separates the responsibilities for handling read operations (queries) from write operations (commands). The central idea behind
CQRS is that the operations you use to update data (commands) are often very different from those used to read data (queries). As a result, separating them can lead to better performance, scalability, and flexibility in how the system is designed.

In CQRS, instead of using the same data model for both reading and writing which is common in traditional CRUD-based approaches, you create separate models or even different storage mechanisms for reads and writes.

## MediatR
MediatR is a popular open-source .NET library that implements the Mediator Pattern. It provides a simple, lightweight framework for managing communication between components in an application while avoiding tight coupling between them. MediatR decouples the components of an application by promoting the use of messages (commands, queries, events, etc.) that are handled by a mediator, instead of direct communication between components.

In simple terms, MediatR allows you to send a message (such as a command or query) through a central "mediator" that forwards the message to the appropriate handler. This is often used to implement features like CQRS or other messaging patterns, but it can be applied to a wide variety of scenarios in both simple and complex applications.
