
---

# Library API

A **Library API** é uma aplicação RESTful desenvolvida com .NET para gerenciar livros em uma biblioteca. A API permite realizar operações de CRUD (Create, Read, Update, Delete) nos livros, utilizando as rotas definidas para cada operação.

## Funcionalidades

- **Cadastrar um livro**
- **Listar todos os livros**
- **Buscar um livro por ID**
- **Atualizar as informações de um livro**
- **Deletar um livro**

## Tecnologias Utilizadas

- .NET 9.0 
- C#
- ASP.NET Core
- Swagger (para documentação interativa da API, permitindo que o usuário teste os endpoints diretamente)

- Scalar (documentação da API no formato OpenAPI, podendo ser utilizado como alternativa ao Swagger)

## Endpoints

### 1. `GET /api/Library`

**Descrição**: Retorna todos os livros cadastrados na biblioteca.

**Exemplo de Resposta**:

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

**Descrição**: Retorna um livro específico pelo seu `id`.

**Exemplo de Resposta**:

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

**Descrição**: Cadastra um novo livro na biblioteca.

**Body da Requisição**:

```json
{
  "title": "O Senhor dos Anéis",
  "author": "J.R.R. Tolkien",
  "genre": "Fantasy",
  "price": 79.90,
  "quantityInStock": 10
}
```

**Exemplo de Resposta**:

```json
{
  "id": 5,
  "title": "O Senhor dos Anéis",
  "author": "J.R.R. Tolkien",
  "genre": "Fantasy",
  "price": 79.90,
  "quantityInStock": 10
}
```

### 4. `PUT /api/Library/{id}`

**Descrição**: Atualiza as informações de um livro específico. Apenas os campos enviados serão atualizados.

**Body da Requisição**:

```json
{
  "title": "O Hobbit",
  "author": "J.R.R. Tolkien",
  "genre": "Fantasy",
  "price": 49.90,
  "quantityInStock": 5
}
```

**Exemplo de Resposta**:

```json
{
  "id": 1,
  "title": "O Hobbit",
  "author": "J.R.R. Tolkien",
  "genre": "Fantasy",
  "price": 49.90,
  "quantityInStock": 5
}
```

### 5. `DELETE /api/Library/{id}`

**Descrição**: Deleta um livro específico pelo seu `id`.

**Exemplo de Resposta**: `204 No Content`

---

## Como Rodar o Projeto

### Requisitos

- .NET 6.0 ou superior
- IDE como Visual Studio ou Visual Studio Code

### Passos

1. Clone o repositório.

```bash
git clone https://github.com/seu-usuario/library-api.git
```

2. Navegue até o diretório do projeto.

```bash
cd library-api
```

3. Execute o projeto com o comando:

```bash
dotnet run
```

4. A API estará disponível em `https://localhost:5001` ou `https://localhost:44348` dependendo da configuração.

---

## Testando com o Swagger

A API já está configurada com o Swagger para facilitar os testes. Acesse `https://localhost:5001/swagger` ou `https://localhost:44348/swagger` para visualizar a documentação interativa e testar os endpoints diretamente.

---

## Considerações Finais

Este projeto é apenas um exemplo de uma API simples para gerenciamento de livros. Ele pode ser expandido com novas funcionalidades, como persistência de dados em banco de dados, autenticação e autorização, entre outros.

---
