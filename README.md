# DemoStore

Simple e-commerce backend project built with ASP.NET Web API.

## Architecture

The project uses layered architecture:

- DemoStore.Api – Web API layer (controllers, configuration)
- DemoStore.Application – business logic layer (services, DTO)
- DemoStore.Domain – core domain models and interfaces
- DemoStore.Infrastructure – database access (EF Core, repositories)

## Tech Stack

- ASP.NET Web API
- Entity Framework Core
- MSSQL (Docker)
- Clean / Layered Architecture

## Project Goal

To build a simple online store backend with:

- Products
- Categories
- Cart
- Orders
- Authentication

This project is created for learning backend development and interview preparation.