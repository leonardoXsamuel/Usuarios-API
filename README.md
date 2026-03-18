# Cadastro de Usuários API (.NET)

Uma API em .NET para cadastro e gerenciamento de usuários, incluindo informações de endereço, localização geográfica e empresa. Esta é uma aplicação inicial com documentação automática via Swagger.

---

## Funcionalidades

- Criar, listar, atualizar e deletar usuários.
- Cada usuário possui:
  - **Address** (endereço)
  - **Geo** (coordenadas geográficas)
  - **Company** (empresa)

---

## Tecnologias

- .NET 8 / .NET Core
- C#
- Swagger para documentação da API
- Visual Studio
- SQL Server

## Estrutura das Classes
User: informações principais do usuário (como: nome, email, username, telefone, Address, Comapany)
Address: rua, suite, cidade, CEP, Geo
Geo: latitude e longitude
Company: nome da empresa
---

## Como Rodar

1. Clone o repositório:
   ```bash
   git clone https://github.com/leonardoXsamuel/Usuarios-API.git

2. Abra o projeto no Visual Studio ou VS Code.
3. Restaure os pacotes:
    ```bash
   dotnet restore
  
4. Rode a aplicação:
   ```bash
   dotnet run

## Acesso à documentação:
http://localhost:5268/swagger
