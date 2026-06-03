# .NET Persistindo Dados com Entity Framework Core

Projeto de estudo desenvolvido em C#/.NET com foco em persistência de dados, acesso a banco, Entity Framework Core, ADO.NET, migrations e organização de código.

O objetivo deste repositório é registrar minha evolução no uso de banco de dados com .NET, praticando diferentes formas de manipular dados, estruturar entidades, executar consultas e trabalhar com persistência em aplicações back-end.

## Objetivo do projeto

Este projeto foi criado para praticar conceitos fundamentais de persistência de dados em aplicações .NET.

Durante o desenvolvimento, foram explorados recursos como conexão com banco de dados, criação de entidades, execução de comandos SQL, uso de migrations, manipulação de registros e refatoração de código para melhorar a organização da aplicação.

## Conceitos praticados

* Persistência de dados com C#
* Acesso a banco utilizando ADO.NET
* Uso do Entity Framework Core
* Criação e configuração de entidades
* Mapeamento de dados
* Consultas ao banco de dados
* Inserção, atualização e remoção de registros
* Uso de migrations
* Versionamento da estrutura do banco
* Refatoração de código
* Organização de responsabilidades
* Prática com SQL Server

## Tecnologias utilizadas

* C#
* .NET
* Entity Framework Core
* ADO.NET
* SQL Server
* Migrations
* Git / GitHub

## Estrutura do projeto

```text
Models/              Entidades utilizadas no projeto
Data/                Configurações de contexto e acesso ao banco
Migrations/          Histórico de alterações estruturais do banco
Program.cs           Ponto de entrada da aplicação
appsettings.json     Configurações da aplicação e conexão com banco
```

> A estrutura pode variar conforme a evolução do projeto e os exercícios implementados.

## Funcionalidades estudadas

* Criação de conexão com banco de dados
* Execução de comandos SQL
* Cadastro de registros
* Consulta de dados
* Atualização de informações
* Remoção de registros
* Criação de entidades
* Configuração do contexto do Entity Framework
* Aplicação de migrations
* Refatoração de trechos de código para melhorar legibilidade e manutenção

## Como executar o projeto

### Pré-requisitos

Antes de executar o projeto, é necessário ter instalado:

* Visual Studio 2022 ou Visual Studio Code
* .NET SDK
* SQL Server
* SQL Server Management Studio ou Azure Data Studio
* Git

### Passos para execução

Clone o repositório:

```bash
git clone https://github.com/GabrielAlvesGG/.NET-persistindo-dados-com-Entity-FrameWork-Core.git
```

Acesse a pasta do projeto:

```bash
cd .NET-persistindo-dados-com-Entity-FrameWork-Core
```

Restaure as dependências:

```bash
dotnet restore
```

Configure a string de conexão no arquivo `appsettings.json`, de acordo com seu ambiente local.

Caso o projeto utilize migrations, execute:

```bash
dotnet ef database update
```

Execute o projeto:

```bash
dotnet run
```

## Exemplo de configuração de conexão

Exemplo de string de conexão para ambiente local:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=EstudoEfCoreDb;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

A string de conexão deve ser ajustada conforme o nome do servidor, banco de dados e forma de autenticação utilizada no ambiente local.

## Objetivo técnico

Este repositório demonstra prática com fundamentos importantes para desenvolvimento back-end em .NET, principalmente no relacionamento entre aplicação e banco de dados.

O foco não é apresentar um produto final, mas sim documentar estudos e práticas envolvendo persistência, manipulação de dados, SQL Server, Entity Framework Core e organização de código.

## Aprendizados principais

* Entendimento da diferença entre ADO.NET e Entity Framework Core
* Prática com comandos diretos no banco de dados
* Uso de ORM para facilitar operações de persistência
* Criação e aplicação de migrations
* Organização de entidades e contexto de banco
* Melhor entendimento sobre como aplicações .NET se comunicam com bancos relacionais
* Importância da refatoração para deixar o código mais claro e sustentável

## Melhorias futuras

* Organizar melhor a estrutura de pastas
* Adicionar exemplos mais completos de CRUD
* Documentar melhor o modelo de dados
* Criar testes para operações principais
* Separar responsabilidades em camadas
* Adicionar exemplos comparando ADO.NET e Entity Framework Core
* Melhorar tratamento de erros
* Criar uma API simples consumindo a camada de persistência

## Observação

Este projeto faz parte da minha evolução como desenvolvedor .NET, reforçando minha base em banco de dados, persistência, Entity Framework Core, ADO.NET e SQL Server.
