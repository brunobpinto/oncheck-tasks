![OnCheckBanner](https://github.com/user-attachments/assets/ddeb3c4c-1008-41ac-a7bd-10bea3c01a23)

# OnCheck  
OnCheck is a web-based task management app built with **Blazor WebAssembly**, designed to help individuals and teams efficiently organize and track their daily tasks. It allows users to create, edit, delete, view with different filters and keep their tasks OnCheck!

## Video  
Watch the app in action in the video below:

https://github.com/user-attachments/assets/719aa34a-e82d-43ce-b86a-35656bb6939e

## Some Features  
- Full CRUD functionality for tasks (Create, Read, Update, Delete)  
- Task filters by difficulty (Easy, Medium, Hard) and status (Completed, Pending)  
- Real-time user search and live filtering  
- Personalized landing page and dynamic side menu
- Protected routes – only logged-in users can access main pages
- Accordion-style task detail display  
- Built-in user registration and login system (With database-validated credentials) 
<br><br>

## Technologies Used  

### Frontend  
- **Blazor WebAssembly** (.NET & C#)  
- **Bootstrap** for responsive layout  
- **Custom CSS** for a clean, modern design  

### Backend  
- **.NET Web API** for handling data requests  
- **Entity Framework Core** for database interactions  
- **Microsoft SQL Server** for persistent data storage  
<div>‎</div>

## Project Structure  

```
OnCheck/
├── OnCheck.Client/      # Blazor WebAssembly frontend  
├── OnCheck.API/         # .NET Web API backend  
└── OnCheck.Shared/      # Shared models between Client and API
```
> [!NOTE]  
> Each part is structured for separation of concerns and scalability. The **Shared** project ensures consistent data structures across the full stack.


<br>

## Getting Started  

### Software Requirements  
- [.NET 8.0 SDK](https://dotnet.microsoft.com/)  
- [Visual Studio Code](https://code.visualstudio.com/download)  
- [SQL Server Express](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [SQL Server Management Studio](https://learn.microsoft.com/en-us/ssms/download-sql-server-management-studio-ssms?redirectedfrom=MSDN)
- [Git and Github](https://git-scm.com/)

> [!WARNING]  
> The version 9.0 of .NET SDK presented problems during development. It is recommended to use 8.0 for this project to ensure it works properly.
<div>‎</div>

## Installation  

1. **Clone the repository**  
```bash
git clone https://github.com/brunobpinto/oncheck-tasks.git
```

2. **Navigate to the solution folder**  
```bash
cd oncheck-tasks
```

3. **Configure your connection string**  
Open `OnCheck.API/appsettings.json` and set the correct SQL Server connection string for your environment.

4. **Apply database migrations**  
```bash
cd OnCheck.API
dotnet ef database update
```

5. **Run the application**  
```bash
cd OnCheck.Client
dotnet run 
```
```bash
cd OnCheck.API
dotnet run 
```

> [!TIP]  
> If you're using VS Code, you can run both the API (Backend) aswell as the Client (Frontend) by opening a Integrated Terminal in each corresponding folder and running the apllication as show above.

<br>



## How It Works  

### User Authentication  
- Basic registration and login functionality stores sessions locally on the client.  
- This is implemented without encryption for simplicity and educational purposes.

### Task Management  
- Tasks are stored in a SQL Server database.  
- Users can add, edit, delete, and filter tasks via the Blazor UI.  
- Each task can be expanded for more detail using an accordion component.

### Filtering & Search  
- Filters and real-time search make it easy to find tasks by difficulty, status, or user.  
- The interface dynamically updates based on input, thanks to Blazor's reactivity.

### UI & Design  
- Bootstrap + custom CSS for responsive layout  
- Clean sidebar navigation with icons and color-coded filters  
- Minimalist interface for reduced visual strain
<div>‎</div>

## Acknowledgements
> I’d like to express how I'm grateful for the opportunity to participate in the selective process for an internship at ICAD Lab – PUC-Rio. Being part of this experience allowed me to learn and grow significantly while developing this project. I'm thankful for the challenges.
