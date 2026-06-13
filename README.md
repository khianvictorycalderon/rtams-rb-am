# Role-Based Account Management
*A full-stack project template*

#### Tech Stacks:
- **Vite React (Typescript)**
- **Tailwind CSS**
- **ASP.NET Core Web API**
- **MS SQL Server**

---

## Prerequisites
- NodeJS
- .NET Core
- MS SQL Server

---

## Setup:
1. Clone this project by running `git clone https://github.com/khianvictorycalderon/rtams-rb-am.git`
2. Create a separate terminal for both frontend and backend folder:
    - *Terminal 1*: `cd backend`
    - *Terminal 2*: `cd frontend`

### Inside `backend` folder:
1. Create an `.env` file that contains:
  ```env
  ConnectionStrings__DefaultConnection=Data Source=Your-Source\\SQLEXPRESS;Initial Catalog=rtams_rb_am_db;Integrated Security=True;TrustServerCertificate=True;
  Cors__AllowedOrigins__0=http://localhost:3000
  Session__DurationHours=6
  ```
  *Note: Change the env credentials depending on your SQL Server database configuration*
2. Run this if you haven't installed entity framework yet:
    ```cmd
    dotnet tool install --global dotnet-ef --version 8.0.0
    ```
    *NOTE: Latest version is unstable with the current setup so I use 8.0.0*
3. Run the following command for database migration:
    ```
    dotnet ef database update
    ```
4. Run `dotnet watch run` to run your backend.

### Inside `frontend` folder:
1.  Create an `.env` file that contains:
    ```env
    VITE_API_URL=https://your-backend.com
    ```
    **NOTE**:
      - *Change `VITE_API_URL` into the actual backend host without trailing slash.*
2. Run `npm install` to install necessary packages.
3. Run `npm run dev` to test your development frontend.

---

## Backend Dependencies & Configuration
The following is a list of installed dependencies and configuration settings used in this project.
You don’t need to install anything manually, as all dependencies are already managed through `project-name.csproj`.
This section is provided for reference only, to give you insight into how the project was set up.

## Backend Dependencies:
*(Note: Some dependencies are intentionally using old versions for stable releases)*
- `dotnet add package BCrypt.Net-Next --version 4.0.3`
- `dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0`
- `dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.0`
- `dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.0`
    
## Frontend Dependencies & Configuration
The following is a list of installed dependencies and configuration settings used in this project.
You don’t need to install anything manually, as all dependencies are already managed through `package.json` (both frontend and backend).
This section is provided for reference only, to give you insight into how the project was set up.

## Frontend Dependencies
- `npm install tailwindcss @tailwindcss/vite axios react-router-dom`

## Frontend Configuration
- Update `vite.config.ts`:
  ```ts
  import tailwindcss from '@tailwindcss/vite'

  export default defineConfig({
    plugins: [
      tailwindcss(),
    ],
  })
  ```