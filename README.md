![OnCheckBanner](https://github.com/user-attachments/assets/ddeb3c4c-1008-41ac-a7bd-10bea3c01a23)


OnCheck é uma aplicação web de lista de tarefas (To-Do List) desenvolvida com o objetivo de fornecer uma experiência eficiente, responsiva e amigável para organização de tarefas pessoais ou colaborativas.

## Tecnologias Utilizadas

### Frontend

- **Blazor WebAssembly** (C#)
- **Bootstrap** para layout responsivo
- **CSS customizado** com design moderno

### Backend

- **.NET Web API**
- **Entity Framework Core**
- **Microsoft SQL Server**

### Compartilhamento de modelos

- Projeto **Shared** com classes comuns (ex: `User`, `TaskItem`)

## Funcionalidades

### Usuário

- Cadastro e login de usuário
- Armazenamento local da sessão
- Autenticação simples sem criptografia (para fins de demonstração)

### Tarefas

- Criação, edição, exclusão e listagem de tarefas
- Filtros por dificuldade (Easy, Medium, Hard)
- Filtros por status (Concluídas, Pendentes)
- Pesquisa por nome de usuário em tempo real
- Accordion de detalhes por tarefa

### UI/UX

- Página inicial personalizada (home/landing)
- Menu lateral interativo com filtros e pesquisa
- Responsividade e acessibilidade visual

## Estrutura de Projeto

- `OnCheck.Client/` - Aplicativo Blazor WebAssembly
- `OnCheck.API/` - Web API com .NET
- `OnCheck.Shared/` - Modelos de dados compartilhados

## Como Executar Localmente

1. Clone o repositório

```bash
git clone https://github.com/seu-usuario/oncheck.git
```

2. Acesse a pasta da solução

```bash
cd OnCheck
```

3. Configure a connection string no `appsettings.json` do projeto API

4. Execute as migrations e atualize o banco:

```bash
dotnet ef database update --project OnCheck.API
```

5. Execute o projeto:

```bash
dotnet run --project OnCheck.Client
```

## Requisitos

- [.NET 7 SDK](https://dotnet.microsoft.com/)
- Visual Studio ou VS Code
- SQL Server LocalDB ou instância de banco compatível

