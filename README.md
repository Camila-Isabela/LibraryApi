
---

# Library API

The **Library API** is a RESTful application built with .NET to manage books in a library. The API allows CRUD operations (Create, Read, Update, Delete) on books through defined endpoints.

## Features

- **Add a new book**
- **List all books**
- **Retrieve a book by ID**
- **Update a book's information**
- **Delete a book**

## Technologies Used

- .NET 9.0  
- C#  
- ASP.NET Core  
- Swagger (for interactive API documentation; users can test endpoints directly)  
- Scalar (OpenAPI documentation; an alternative to Swagger – user can choose which to use)

## Endpoints

### 1. `GET /api/Library`

**Description**: Returns all books in the library.

**Sample Response**:

```json
[
  {
    "id": 1,
    "title": "1984",
    "author": "George Orwell",
    "genre": "Dystopian",
    "price": 25.50,
    "quantityInStock": 15
  },
  {
    "id": 2,
    "title": "To Kill a Mockingbird",
    "author": "Harper Lee",
    "genre": "Fiction",
    "price": 20.00,
    "quantityInStock": 8
  }
]
```

### 2. `GET /api/Library/{id}`

**Description**: Returns a specific book by its `id`.

**Sample Response**:

```json
{
  "id": 1,
  "title": "1984",
  "author": "George Orwell",
  "genre": "Dystopian",
  "price": 25.50,
  "quantityInStock": 15
}
```

### 3. `POST /api/Library`

**Description**: Adds a new book to the library.

**Request Body**:

```json
{
  "title": "The Lord of the Rings",
  "author": "J.R.R. Tolkien",
  "genre": "Fantasy",
  "price": 79.90,
  "quantityInStock": 10
}
```

**Sample Response**:

```json
{
  "id": 5,
  "title": "The Lord of the Rings",
  "author": "J.R.R. Tolkien",
  "genre": "Fantasy",
  "price": 79.90,
  "quantityInStock": 10
}
```

### 4. `PUT /api/Library/{id}`

**Description**: Updates an existing book based on the `id` provided in the URL. Only fields sent in the request body will be updated.

**Request Body**:

```json
{
  "title": "The Hobbit",
  "author": "J.R.R. Tolkien",
  "genre": "Fantasy",
  "price": 49.90,
  "quantityInStock": 5
}
```

**Sample Response**:

```json
{
  "id": 1,
  "title": "The Hobbit",
  "author": "J.R.R. Tolkien",
  "genre": "Fantasy",
  "price": 49.90,
  "quantityInStock": 5
}
```

### 5. `DELETE /api/Library/{id}`

**Description**: Deletes a book by its `id`.

**Sample Response**: `204 No Content`

---

## How to Run the Project

### Requirements

- .NET 6.0 or higher  
- IDE like Visual Studio or Visual Studio Code

### Steps

1. Clone the repository:

```bash
git clone https://github.com/your-username/library-api.git
```

2. Navigate to the project folder:

```bash
cd library-api
```

3. Run the project:

```bash
dotnet run
```

4. The API will be available at https://localhost:5001 or another port depending on your configuration.

---

## Testing with Swagger or Scalar

The API comes configured with both **Swagger** and **Scalar** to make testing easy and flexible.  
You can access the interactive documentation through:

- Swagger: `https://localhost:5001/swagger/index.html`  
- Scalar: `https://localhost:5001/scalar/v1`

Feel free to use the one you prefer.

---

## Final Considerations

This project is just an example of a simple API for book management. It can be expanded with new features such as data persistence to a database, authentication and authorization, among others.

---
