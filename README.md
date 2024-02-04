# API Project Readme

## Overview

Welcome to the documentation for [Your API Name]! This API is built using C# and .NET Core, incorporating several design principles and patterns to ensure flexibility, maintainability, and extensibility. The key technologies and principles used in this project include Reflection, Dependency Inversion, Open-Closed Principle, and Abstract Factory Pattern.

## Table of Contents

- [Technologies Used](#technologies-used)
- [Design Principles](#design-principles)
    - [Reflection](#reflection)
    - [Dependency Inversion](#dependency-inversion)
    - [Open-Closed Principle](#open-closed-principle)
    - [Abstract Factory Pattern](#abstract-factory-pattern)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [License](#license)

## Technologies Used

- C#
- .NET Core

## Design Principles

### Reflection

Reflection is utilized in this API to dynamically inspect and interact with types at runtime. This allows for a more flexible and extensible design, as the application can adapt to changes in the structure of types.

### Dependency Inversion

Dependency Inversion is a key design principle employed in this project. It promotes decoupling between high-level modules and low-level modules, allowing for more flexibility in making changes. By depending on abstractions rather than concrete implementations, the code becomes more modular and easier to maintain.

### Open-Closed Principle

The Open-Closed Principle is followed to ensure that the code is open for extension but closed for modification. This means that new functionality can be added without altering existing code. The use of interfaces, abstract classes, and dependency injection facilitates the extension of the system.

### Abstract Factory Pattern

The Abstract Factory Pattern is applied to provide an interface for creating families of related or dependent objects without specifying their concrete classes. This pattern is particularly useful in scenarios where the system needs to support multiple databases without tightly coupling the code to specific implementations.

## Getting Started

To get started with the API, follow these steps:

1. Clone the repository: `git clone https://github.com/andreff98/wharehouse_pattern_dbs/`
2. Navigate to the project directory: `cd wharehouse_pattern_dbs`
3. Restore dependencies: `dotnet restore`
4. Build the project: `dotnet build`
5. Run the application: `dotnet run`

## Usage

Provide examples and documentation on how to use the API. Include information on endpoints, request and response formats, and any other relevant details.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
