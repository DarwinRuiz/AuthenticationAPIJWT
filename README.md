# REST API with JWT Authentication and Authorization in ASP.NET

This project is a RESTful API developed with ASP.NET Core that implements authentication and authorization using JSON Web Tokens (JWT). The data is stored in memory, and only GET endpoints are provided.

## Features

- JWT authentication.
- Role-based authorization.
- In-memory local data.
- Protected GET endpoints.

## Technologies Used

- ASP.NET Core
- JSON Web Tokens (JWT)
- Swagger

## Usage

### User Authentication

- **Endpoint:** `POST /api/Auth/SignIn`
- **Request body:**

    ```json
    {
        "userName": "user",
        "password": "password"
    }
    ```

### Protected Endpoints

- **Authorization Header:** `Bearer {your-jwt-token}`

- **Examples:**
  - `GET /api/Countries`
  - `GET /api/Products`
  - `GET /api/Employees`



# API REST con Autenticación y Autorización JWT en ASP.NET

Este proyecto es una API RESTful desarrollada con ASP.NET Core que implementa autenticación y autorización utilizando JSON Web Tokens (JWT). Los datos se almacenan en memoria y se proporciona únicamente endpoints GET.

## Características

- Autenticación con JWT.
- Autorización basada en roles.
- Datos locales en memoria.
- Endpoints GET protegidos.

## Tecnologías Utilizadas

- ASP.NET Core
- JSON Web Tokens (JWT)
- Swagger

## Uso

### Autenticación de Usuario

- **Endpoint:** `POST /api/Auth/SignIn`
- **Cuerpo de la solicitud:**

    ```json
    {
        "userName": "usuario",
        "password": "contraseña"
    }
    ```

### Endpoints Protegidos

- **Authorization Header:** `Bearer {tu-jwt-token}`

- **Ejemplos:**
  - `GET /api/Countries`
  - `GET /api/Products`
  - `GET /api/Employees`