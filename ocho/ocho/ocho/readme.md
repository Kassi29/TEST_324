# Pregunta 8
## Crear un Web Service en Visual Studio de Persona

### Paso 1: Crear la base de datos y la tabla

```sql
CREATE DATABASE ocho
USE ocho

CREATE TABLE Persona (
    IdPersona INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    Direccion NVARCHAR(255),
    Telefono NVARCHAR(15),
    Tipo NVARCHAR(15)
);
```

### Paso 2: Crear un proyecto ASP.NET Core en Visual Studio

### Paso 3: Instalar dependencias mediante NuGet

```
PM> Scaffold-DbContext "Server=localhost;Database=ocho;Integrated Security=true;TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```

### Paso 4: Editar appsettings.json

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  

  "ConnectionStrings": {
    "conexion": "Server=localhost;Database=ocho;Integrated Security=true;TrustServerCertificate=true;"
  }
}

```

### Paso 5: Configurar la conexión a la base de datos en Program.cs

```csharp
builder.Services.AddDbContext<OchoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("conexion")));
```

### Paso 6: Comentar la configuración de la conexión en OchoContext.cs

```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    /*warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    => optionsBuilder.UseSqlServer("Server=localhost;Database=ocho;Integrated Security=true;TrustServerCertificate=true;");*/
}
```

### Paso 7: Añadir el controlador usando Entity Framework

Esto generará las vistas y el controlador automáticamente con las funciones:

- Create.cshtml
- Delete.cshtml
- Details.cshtml
- Edit.cshtml
- Index.cshtml

### Paso 8: Ejecutar el proyecto

Dirígete a [http://localhost:5205/](http://localhost:5205/) para acceder al web service.


