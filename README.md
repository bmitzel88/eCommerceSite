# eCommerce Project

## Project Description

This is an ASP.NET Core MVC-based eCommerce application that allows users to browse products, manage orders, and complete purchases.

## Prerequisites

To run this project locally, ensure you have the following installed:

- **.NET Core SDK 6.0 or later**: [Download .NET Core](https://dotnet.microsoft.com/download/dotnet)
- **Visual Studio 2022**: [Download Visual Studio](https://visualstudio.microsoft.com/downloads/)
- **SQL Server or SQL Server Express**: [Download SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- **Node.js** (for managing front-end dependencies): [Download Node.js](https://nodejs.org/)

## Installation and Setup

1. **Clone the repository:**
    ```bash
    git clone https://github.com/yourusername/eCommerceSite.git
    ```

2. **Navigate to the project directory:**
    ```bash
    cd eCommerceSite
    ```

3. **Restore NuGet packages:**
    ```bash
    dotnet restore
    ```

4. **Set up the database:**
    - Update the connection string in `appsettings.json` to point to your SQL Server instance.
    - Apply migrations to create the database schema:
    ```bash
    dotnet ef database update
    ```

5. **Run the application:**
    ```bash
    dotnet run
    ```

6. **Access the application:**
    - Open your browser and navigate to `https://localhost:5001` (or the port specified in your launch settings).

## Usage

- **Admin Functions**: Add, edit, and remove products, manage orders, and handle user roles.
- **User Functions**: Browse products, add items to the cart, and complete purchases with a simple checkout process.
- **Authentication**: Register, login, and manage user accounts securely.

## Useful Resources

- [ASP.NET Core MVC Documentation](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-6.0)
- [Entity Framework Core Documentation](https://docs.microsoft.com/en-us/ef/core/)
- [CRUD Functionality in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/crud?view=aspnetcore-6.0)
- [Bootstrap Documentation](https://getbootstrap.com/docs/5.0/getting-started/introduction/)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
