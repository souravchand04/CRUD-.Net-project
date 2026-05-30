# CrudApi

A simple ASP.NET Core Web API for managing items with full CRUD (Create, Read, Update, Delete) operations using an in-memory data store.

## Tech Stack

- **.NET 10.0** 
- **ASP.NET Core** minimal API with controllers
- **OpenAPI** via `Microsoft.AspNetCore.OpenApi`
- **In-memory repository** using `ConcurrentDictionary`

## Project Structure

```
crud-api/
├── Controllers/
│   └── ItemsController.cs   # CRUD endpoints
├── Models/
│   └── Item.cs              # Item entity
├── Services/
│   └── ItemRepository.cs    # In-memory data store
├── Program.cs               # App entry point & DI setup
└── appsettings.json         # Logging config
```

## API Endpoints

| Method | Route              | Description         |
|--------|--------------------|---------------------|
| GET    | `/api/items`       | Get all items       |
| GET    | `/api/items/{id}`  | Get item by ID      |
| POST   | `/api/items`       | Create a new item   |
| PUT    | `/api/items/{id}`  | Update an existing item |
| DELETE | `/api/items/{id}`  | Delete an item      |

## Models

```json
{
  "id": 1,
  "name": "string",
  "description": "string",
  "price": 0.00,
  "createdAt": "2026-05-30T00:00:00Z"
}
```

## Getting Started

```bash
# Restore dependencies
dotnet restore

# Run the API
dotnet run --project crud-api

# Navigate to Swagger UI (dev mode)
# https://localhost:{port}/openapi/v1.json
```

The API will launch with OpenAPI support in development mode.
