
---

# Library API

A **Library API** � uma aplica��o RESTful desenvolvida com .NET para gerenciar livros em uma biblioteca. A API permite realizar opera��es de CRUD (Create, Read, Update, Delete) nos livros, utilizando as rotas definidas para cada opera��o.

## Funcionalidades

- **Cadastrar um livro**
- **Listar todos os livros**
- **Buscar um livro por ID**
- **Atualizar as informa��es de um livro**
- **Deletar um livro**

## Tecnologias Utilizadas

- .NET 9.0 
- C#
- ASP.NET Core
- Swagger (para documenta��o interativa da API, permitindo que o usu�rio teste os endpoints diretamente)

- Scalar (documenta��o da API no formato OpenAPI, podendo ser utilizado como alternativa ao Swagger)

## Endpoints

### 1. `GET /api/Library`

**Descri��o**: Retorna todos os livros cadastrados na biblioteca.

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

**Descri��o**: Retorna um livro espec�fico pelo seu `id`.

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

**Descri��o**: Cadastra um novo livro na biblioteca.

**Body da Requisi��o**:

```json
{
  "title": "O Senhor dos An�is",
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
  "title": "O Senhor dos An�is",
  "author": "J.R.R. Tolkien",
  "genre": "Fantasy",
  "price": 79.90,
  "quantityInStock": 10
}
```

### 4. `PUT /api/Library/{id}`

**Descri��o**: Atualiza as informa��es de um livro espec�fico. Apenas os campos enviados ser�o atualizados.

**Body da Requisi��o**:

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

**Descri��o**: Deleta um livro espec�fico pelo seu `id`.

**Exemplo de Resposta**: `204 No Content`

---

## Como Rodar o Projeto

### Requisitos

- .NET 6.0 ou superior
- IDE como Visual Studio ou Visual Studio Code

### Passos

1. Clone o reposit�rio.

```bash
git clone https://github.com/seu-usuario/library-api.git
```

2. Navegue at� o diret�rio do projeto.

```bash
cd library-api
```

3. Execute o projeto com o comando:

```bash
dotnet run
```

4. A API estar� dispon�vel em `https://localhost:5001` ou `https://localhost:44348` dependendo da configura��o.

---

## Testando com o Swagger

A API j� est� configurada com o Swagger para facilitar os testes. Acesse `https://localhost:5001/swagger` ou `https://localhost:44348/swagger` para visualizar a documenta��o interativa e testar os endpoints diretamente.

---

## Considera��es Finais

Este projeto � apenas um exemplo de uma API simples para gerenciamento de livros. Ele pode ser expandido com novas funcionalidades, como persist�ncia de dados em banco de dados, autentica��o e autoriza��o, entre outros.

---
