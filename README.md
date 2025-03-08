# TodoApplication

This is a simple **Todo List** web application built using **ASP.NET Core** (MVC pattern) for the backend and **HTML**, **CSS**, and **JavaScript** for the frontend. The application allows users to **Create**, **Read**, **Update**, and **Delete** Todo items. It uses in-memory storage for simplicity, so all data is lost when the application stops.

## Features

- **Create** a new Todo item.
- **View** all Todo items in a list.
- **Edit** a Todo item to update its status.
- **Delete** a Todo item.
- Shows the **status** of the Todo item (Completed or Not Completed) with color-coded chips.

## Prerequisites

Before running the application, make sure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download/dotnet) (version 9)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) (with C# extensions)
- [Git](https://git-scm.com/) for version control

## Getting Started
```
git clone https://github.com/Ranul00/in-memory-todo.git
```

### 2. Navigate to the Project Directory
```
cd in-memory-todo/TodoApplication
```

### 3. Restore Dependencies

Run the following command to restore the project dependencies:
```
dotnet restore
```

### 4. Build the Project

Build the application to ensure everything is set up correctly:
```
dotnet build
```

### 5. Run the Application

Run the application using the following command:
```
dotnet run
```
After the application starts, it will be available at `http://localhost:5000`

### 6. Access the Application

- Open a web browser and navigate to `http://localhost:5000`.
- You should see the Todo List application where you can perform all the CRUD operations (Create, Read, Update, Delete) on Todo items.

## Application Structure

- **Controllers**: Contains the logic to handle user requests and responses (CRUD operations for Todo items).
- **Models**: Contains the data models, including the `TodoItem` class.
- **Views**: Contains Razor views for displaying data (List view, Create, Edit, etc.).
- **Services**: The service layer to manage business logic (CRUD operations on the Todo list).

## Acknowledgments

- This project uses the **ASP.NET Core MVC** framework for the backend.
- **CSS** and **HTML** were used to create the views.
