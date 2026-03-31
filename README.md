# C# CRUD API Starter

Um projeto base para demonstrar a criação de uma API RESTful em C# utilizando .NET. Este repositório serve como um guia inicial para entender operações CRUD (Create, Read, Update, Delete).

## Sobre o Projeto

Este projeto foi construído para ser um ponto de partida limpo e simples para desenvolvedores que querem entender como construir APIs do zero. Ele implementa um gerenciador simples de recursos demonstrando as melhores práticas na manipulação de requisições e roteamento no ASP.NET Core.

## Funcionalidades

* Create: Criação de novos registros.
* Read: Leitura de todos os registros ou de um registro específico por ID.
* Update: Atualização completa de registros existentes.
* Delete: Remoção de registros do sistema.
* Swagger/OpenAPI: Documentação interativa da API já configurada.

## Tecnologias Utilizadas

* Linguagem: C#
* Framework: .NET (ASP.NET Core Web API)
* Documentação: Swagger (Swashbuckle)

## Estrutura de Diretórios

Abaixo está a estrutura base deste projeto:

```text
├── Controllers/               # Define as rotas e os controladores da API
├── Models/                    # Modelos de dados (ex: Carro.cs)
├── Properties/                # Configurações de inicialização do projeto (launchSettings)
├── appsettings.json           # Configurações gerais da aplicação (strings de conexão, etc)
├── Carros.API.csproj          # Arquivo de configuração de dependências do projeto C#
├── Carros.API.sln             # Arquivo da Solução do projeto
└── Program.cs                 # Configuração de injeção de dependência e pipeline
