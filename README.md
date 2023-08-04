## Descripcion del proyecto

Este proyecto es un simple crud de productos, categorias y usuarios realizado en ASP.NET Core 7.0 y usando SQLite como persistencia.

#### Pasos para ejecutar el proyecto

1. Se debe ejecutar el siguiente comando para compilar el proyecto

```
dotnet build
```

2. Ejecutar las migraciones: para esto no debe arrojar errores al momento de compilar, luego de generar la migracion ya se puede ejecutar proyecto con > dotnet run

```
dotnet ef migrations add LastMigration
dotnet run
```

4. Ingresar al siguiente link donde esta la documentacion con Swagger
   http://localhost:5260/swagger

---

## Tutorial paso a paso :computer:

#### 1. Crear la Estructura de carpetas

- Controllers
- Dtos
- Data / Interfaces
- Helpers
- Models
- Mapper
- Services
- Services / Interfaces

#### 2. Instalar los paquetes para EntityFramework

```
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
```

#### 3. Añadir el DbContext en Data / Interfaces / DataContext.cs

Se debe crear el constructor inyectando las options y tambien agregar cada entidad DbSet

#### 4. Agregar cadena de conexion DB

En el archivo appsettings.Development.json y luego dar de alta en archivo Program.cs para Dotnet 5 en el archivo Startup.cs se debe llamar la cadena de conexion

#### 5. Crear las migraciones

Para eso se debe instalar la herramienta, no debe haber ningun error al ejecutar la migracion para comprobar podemos usar el comando dotnet build

Comprobar errores

```
dotnet build
```

Instalar dotnet tools en caso de ya tenerla instalada solo se actualiza

```
dotnet tool update --global dotnet-ef
dotnet tool install --global dotnet-ef
```

Generar las migraciones

```
dotnet ef migrations add PrimeraMigracion
```

#### 6. Crear la base de datos apartir de la ultima migracion

```
dotnet ef database update
```

#### 7. Agregar lazy loading

Para la carga de base de datos, configurar el AddDbContext en archivo Program.cs

```
dotnet add package Microsoft.EntityFrameworkCore.Proxies
```
