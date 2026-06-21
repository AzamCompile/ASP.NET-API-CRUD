# MyApi

Simple ASP.NET Core Web API project.

## Features

* ASP.NET Core 10
* REST API
* Controllers
* Models
* CRUD Ready

## Run

```bash
dotnet restore
dotnet run
```

## Endpoint

```http
GET /api/product
```

Response:

```json
[
  {
    "id": 1,
    "name": "Laptop",
    "price": 1000
  }
]
```
