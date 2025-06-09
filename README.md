# Projeto MVC de Aluno
* Este projeto é uma aplicação ASP.NET Core MVC desenvolvida para gerenciar focada no CRUD (Criar, Ler, Atualizar, Deletar) de informações de alunos. Ele utiliza o Entity Framework Core para persistência de dados e foi rapidamente construído com as funcionalidades de scaffolding do ASP.NET Core para o modelo Aluno.


## Funcionalidades
* Listagem de Alunos: Visualize uma lista de todos os alunos cadastrados.
![image](https://github.com/user-attachments/assets/9e7c7746-c4ce-41f4-9a4d-956c168c7c1c)

* Detalhes do Aluno: Acesse informações detalhadas de um aluno específico.
![image](https://github.com/user-attachments/assets/036dc35b-6746-401d-8015-b023f9332456)

* Adicionar Novo Aluno: Crie novos registros de alunos.
![image](https://github.com/user-attachments/assets/7d86fe0b-36b4-4643-91c7-4074fb90e245)

* Editar Aluno: Modifique as informações de alunos existentes.
![image](https://github.com/user-attachments/assets/036f7181-f17d-4404-ac2b-b2a7eebbf5c3)

* Excluir Aluno: Remova registros de alunos do sistema.
![image](https://github.com/user-attachments/assets/a7523225-8f32-4d20-880c-879e6adef721)

## Rotas Personalizadas: 
 Implementa rotas amigáveis para URLs mais limpas (por exemplo, /meus-alunos/novo em vez de /Alunos/Create).

## Autorização: 
 Implementação de autorização básica, exigindo que os usuários estejam autenticados para acessar as funcionalidades de gerenciamento de alunos.

## Tecnologias Utilizadas
* ASP.NET Core MVC: Estrutura para construção de aplicações web.
* Entity Framework Core: ORM (Object-Relational Mapper) para acesso a dados.
* Bootstrap: Para uma interface de usuário responsiva e moderna.
* C#: Linguagem de programação.
* SQL Server (ou outro banco de dados configurado): Banco de dados para armazenar os dados dos alunos.

## Primeiros Passos
 Siga estas etapas para colocar seu projeto em funcionamento.

## Pré-requisitos
* .NET SDK (Versão compatível com ASP.NET Core 8.0 ou posterior, conforme o scaffolding moderno).
* Visual Studio (Recomendado para desenvolvimento) ou outra IDE de sua preferência.
* Um servidor de banco de dados (ex: SQL Server LocalDB, SQL Server, SQLite, PostgreSQL, etc.).

## Instalação
 Clone o repositório:
 * git clone <url-do-seu-repositorio>
 * cd AppFuncional

Restaure os pacotes NuGet:
 * dotnet restore

Atualize o Banco de Dados (Migrações):
 Este projeto utiliza as Migrações do Entity Framework Core para gerenciar o esquema do banco de dados.
 * dotnet ef migrations add InitialCreate
 *  dotnet ef database update

 Execute a aplicação:
 * dotnet run
  A aplicação geralmente será iniciada em https://localhost:5001 ou http://localhost:5000 (verifique a saída do console para a URL exata).

## Estrutura do Projeto
* Controllers/AlunosController.cs: Lida com as requisições HTTP relacionadas ao gerenciamento de alunos.
* Models/Aluno.cs: Define a entidade Aluno com suas propriedades.
* Data/ApplicationDbContext.cs: O DbContext do Entity Framework Core para interação com o banco de dados.
* Views/Alunos/: Contém as views Razor para exibir as páginas relacionadas aos alunos (Index, Details, Create, Edit, Delete).

## Rotas Personalizadas
 O AlunosController utiliza rotas personalizadas para uma estrutura de URL mais amigável:
 * Listar todos os alunos: /meus-alunos
 * Detalhes do aluno: /meus-alunos/detalhes/{id}
 * Criar novo aluno: /meus-alunos/novo
 * Editar aluno: /meus-alunos/editar/{id}
 * Excluir aluno: /meus-alunos/excluir/{id}

## Autorização
 O atributo [Authorize] é aplicado ao AlunosController, o que significa que apenas usuários autenticados podem acessar qualquer uma das funcionalidades de gerenciamento de alunos. Você precisará configurar o ASP.NET Core Identity ou outro mecanismo de autenticação para que os usuários possam fazer login.
