# How to Run

## Prerequisites
- **.NET 6 SDK**
- **SQL Server**
- **Configured Migrations**
- **EntityFramwork Core**

---

## 1. Running the .NET 6 API
1. Navigate to the backend project folder:
   ```sh
   cd LeadsApi
   ```
2. Restore dependencies:
   ```sh
   dotnet restore
   ```
3. Build the project:
   ```sh
   dotnet build
   ```
4. Apply migrations to update the database:
   ```sh
   dotnet ef database update
   ```
5. Run the API:
   ```sh
   dotnet run
   ```
6. Access Swagger to test the endpoints:
   ```
   http://localhost:5056/swagger
   ```
   *(The port may vary depending on the project configuration.)*

---

## Additional Configuration
- Adjust URLs and connection strings in `appsettings.json` if necessary.
- For production builds, use `dotnet publish`.

If you have any questions, check the official .NET 6 and Entity Framework documentation!

