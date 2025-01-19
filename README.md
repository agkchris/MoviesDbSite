# MoviesDb Project

A web application built with ASP.NET Core MVC that allows users to manage a movie database. Users can register, login, and perform CRUD operations on movie entries.

## Prerequisites

- .NET 9.0 SDK
- Visual Studio 2022 or newer (recommended) or VS Code
- SQLite
- IIS (for deployment)

The application will be available at `https://localhost:5001` or `http://localhost:5000`

## Project Structure

- `Controllers/`: Contains MVC controllers
  - `MoviesController.cs`: Handles movie CRUD operations
  - `AccountController.cs`: Handles user authentication
- `Models/`: Contains data models and view models
- `Views/`: Contains Razor views
- `Data/`: Contains database context and migrations

## IIS Deployment Guide

### Prerequisites for IIS

1. Install the .NET 9.0 Hosting Bundle
2. Install the Web Deploy tool
3. Enable IIS features in Windows:
   - Internet Information Services
   - Web Management Tools
   - IIS Management Console
   - World Wide Web Services

### Deployment Steps

1. **Publish the Application**

   Using Visual Studio:
   - Right-click on the project in Solution Explorer
   - Select "Publish"
   - Choose "IIS, FTP, etc."
   - Configure your publish profile
   
   Using command line:
   ```bash
   dotnet publish -c Release -o ./publish
   ```

2. **Configure IIS**

   a. Create Application Pool:
   
   b. Create Website:
   
3. **Configure Application Settings**

   a. Update appsettings.json in the published folder:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Data Source=C:\\[path-to-your-db]\\MoviesDb.db"
     }
   }
   ```

   b. Set folder permissions:
   - Navigate to your publication folder
   - Right-click → Properties → Security
   - Add IIS_IUSRS and IUSR with Modify permissions
   - Add your Application Pool identity with Modify permissions

4. **Configure SSL (if using HTTPS)**
   - In IIS Manager, select your site
   - Click "Bindings"
   - Add HTTPS binding
   - Select your SSL certificate

### Common Issues and Solutions

1. **500.19 Error**
   - Check if the Application Pool is running
   - Verify .NET Hosting Bundle is installed
   - Check folder permissions

2. **Database Connection Issues**
   - Verify connection string in appsettings.json
   - Check if SQLite database file exists and has proper permissions
   - Ensure Application Pool identity has access to the database file

3. **404 Not Found**
   - Check if the site's physical path is correct
   - Verify URL rewrite module is installed
   - Check if web.config is present and correct


## API Documentation

The API documentation is available at `/swagger` when running in development mode. It includes:

- All available endpoints
- Request/response schemas
- Authentication requirements
- Example requests
