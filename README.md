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



# API REST con Autenticaci�n y Autorizaci�n JWT en ASP.NET

Este proyecto es una API RESTful desarrollada con ASP.NET Core que implementa autenticaci�n y autorizaci�n utilizando JSON Web Tokens (JWT). Los datos se almacenan en memoria y se proporciona �nicamente endpoints GET.

## Caracter�sticas

- Autenticaci�n con JWT.
- Autorizaci�n basada en roles.
- Datos locales en memoria.
- Endpoints GET protegidos.

## Tecnolog�as Utilizadas

- ASP.NET Core
- JSON Web Tokens (JWT)
- Swagger

## Uso

### Autenticaci�n de Usuario

- **Endpoint:** `POST /api/Auth/SignIn`
- **Cuerpo de la solicitud:**

    ```json
    {
        "userName": "usuario",
        "password": "contrase�a"
    }
    ```

### Endpoints Protegidos

- **Authorization Header:** `Bearer {tu-jwt-token}`

- **Ejemplos:**
  - `GET /api/Countries`
  - `GET /api/Products`
  - `GET /api/Employees`