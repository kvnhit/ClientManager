
# ClienteManager

ClienteManager é uma aplicação MVC desenvolvida em ASP.NET Core para gerenciar clientes. Este projeto inclui a criação de um banco de dados SQL Server, APIs para CRUD de clientes e Login. Foi implementado utilizando o padrão CQRS e distribuído em camadas (Core, Application, Infrastructure, API), além da aplicação MVC que consome a API.

# Nota do desenvolvedor aos revisores !!!
### 1 - Ao me deparar com o desafio, acabei confundindo o ponto em que informava para não usar Entity Framework. Estava dito: "3.1. Gerar scripts de tabelas – não usar entity framework.", o que me levou a pensar enganosamente que essa instrução se referia a não usar o Entity para geração do banco de daos através das Migrations. No mesmo dia entrei em contato para tirar a dúvida mas por ser um pouco tarde, acabei sendo respondido no dia seguinte, onde a recrutadora me informou que seria mais recomendado utilizar Dapper ou ADO.NET para as persistências. Sinto muito mesmo por isso, e gostaria de pedir que ainda assim verificassem o código. Mesmo que apenas para um feedback. 

### Custei um tempo considerável pois fiz do zero, o que acabou fazendo com que eu não tivesse tempo suficiente para validações, testes unitários e demais detalhes. De qualquer forma, muito obrigado.

## Instruções

- Executar o script de criação de banco de dados e tabela de clientes. 
- Após isso, inserir a string de conexão correta no arquivo appsettingjson.json e appsettingjson.Development.json dentro de ClientManager.API.
- Verificar pacotes do NuGet em caso de falha, caso seja necessário um 'Restore'.

## Funcionalidades

- **Autenticação**: Sistema de login com criação de cookies.
- **CRUD de Clientes**: Operações de criação, leitura, atualização e exclusão de clientes.
- **Interface Amigável**: Interface web desenvolvida em MVC Core.

## Pré-requisitos

Antes de começar, certifique-se de ter o seguinte instalado:

- [.NET Core SDK](https://dotnet.microsoft.com/download) 6.0 ou superior
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) com os pacotes de desenvolvimento ASP.NET e Web.



