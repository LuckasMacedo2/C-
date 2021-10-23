 # Português
Esse repositório contém o código de uma aplicação web utilizando o ASP .NET CORE. A aplicação é responsável por gerenciar um CRUD simples de um catalogo de jogos onde o usuário pode cadastrar, excluir, atualizar e obter a lista de jogos presentes no banco de dados.
Para executar a aplicação, é necessário instalar o pacote do Swagger a partir do gerenciador de pacotes do nuget. 
Por padrão o projeto está configurado para armazenar os dados no banco de dados, mas também pode ser utilizado para armazenar os dados em memória. Para utilizar uma das duas formas:
* Banco de dados: Acessar o arquivo appsettings.json e mudar o ConnectionStrings > Default para a string conexão com o banco de dados;
*	Armazenamento em memória: Acessar o arquivo Startup.cs, descomentar a linha 37 e comentar a linha 38
O arquivo TableJogos cria o banco de dados para o uso com a aplicação, além de criar três registros de exemplo.
Projeto desenvolvido como parte do bootcamp Avanade CodeAnywhere .NET da plataforma Digital Innovation One


# Inglês
This repository contains the code of a web application using ASP .NET CORE. The application is responsible for managing a simple CRUD of a games catalog where the user can register, delete, update and obtain the list of games present in the database.
To run the application, you need to install the Swagger package from nuget's package manager.
By default the project is configured to store data in the database, but it can also be used to store data in memory. To use one of two ways:
* Database: Access the appsettings.json file and change ConnectionStrings > Default to the database connection string;
* Memory Storage: Access the Startup.cs file, uncomment line 37 and comment out line 38
The TableJogos file creates the database for use with the application, in addition to creating three example records.
Project developed as part of the Avanade CodeAnywhere .NET bootcamp of the Digital Innovation One platform
