# SpendFlow Backend

This repository contains the backend implementation of the SpendFlow application using ASP.NET Core Web API and Clean Architecture principles.

## Solution Structure

SpendFlow.be
├── SpendFlow.API
├── SpendFlow.Application
├── SpendFlow.Infrastructure
├── SpendFlow.Domain

## Project Setup

### Create Solution

mkdir SpendFlow.be
cd SpendFlow.be
dotnet new sln -n SpendFlow.Service

### Create Projects

dotnet new webapi -n SpendFlow.API
dotnet new classlib -n SpendFlow.Application
dotnet new classlib -n SpendFlow.Infrastructure
dotnet new classlib -n SpendFlow.Domain

### Add Projects to Solution

dotnet sln add SpendFlow.API
dotnet sln add SpendFlow.Application
dotnet sln add SpendFlow.Infrastructure
dotnet sln add SpendFlow.Domain

### Add Project References

dotnet add SpendFlow.API reference SpendFlow.Application
dotnet add SpendFlow.API reference SpendFlow.Infrastructure
dotnet add SpendFlow.Application reference SpendFlow.Domain
dotnet add SpendFlow.Infrastructure reference SpendFlow.Domain

## Architecture

This solution follows Clean Architecture principles:

- Domain: Core entities and interfaces
- Application: Business logic and service layer
- Infrastructure: Data access and repository implementations
- API: Controllers and HTTP endpoints

## Dependency Injection

Each layer manages its own dependency registration using extension methods.

### Infrastructure Layer

services.AddScoped<IExpenseRepository, ExpenseRepository>();
services.AddScoped<IUnitOfWork, UnitOfWork>();

### Application Layer

services.AddScoped<IExpenseService, ExpenseService>();

### API Layer Configuration

services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

services.AddInfrastructureServices();
services.AddApplicationServices();

Program.cs:

builder.Services.ConfigureServices(builder.Configuration);

## Adding New Services

To add a new service:

1. Create interface in Application layer
2. Create service implementation
3. Register in DI

Example:

services.AddScoped<IYourService, YourService>();

Always register dependencies in the correct layer.

## Database

Entity Framework Core is used for data access.

services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

## Swagger Setup

Install Swagger package:

dotnet add SpendFlow.API package Swashbuckle.AspNetCore

Configure Swagger:

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

Enable Swagger:

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

## Run the Application

cd SpendFlow.API
dotnet run

## API Endpoints

Swagger UI:

https://localhost:<port>/swagger

Health Check:

GET /api/expense/health

## Features

- Clean architecture implementation
- Dependency Injection across layers
- Repository and Unit of Work pattern
- Expense management APIs
- Swagger integration
- Health check endpoint

## Future Enhancements

- Frontend
- Validation
- Authentication (JWT)
- Logging
- Global exception handling
- Unit testing
