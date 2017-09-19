# Inicio de Sesión MVC

## Inicio de sesión con MVC .NET completo con Entity Framework

### Preparación del entorno

1. En la configuracion inicial del proyecto MVC en el apartado **Change Authentication** cambiar la confuración por   
** Individual User Accounts **.
2. Crear una base de datos local con **SQL Server Management Studio (SSMS)** con autentificacion de windows para probar.

> **Nota Importante:** no olvidar de compilar la solución. 

### Editando cadena de conexión

1. Cambiar la cadena de conexión que se asemeja a la siguiente:
```xml
  <connectionStrings>
    <add name="DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-InicioSesionMVC-20170919081721.mdf;Initial Catalog=aspnet-InicioSesionMVC-20170919081721;Integrated Security=True"
      providerName="System.Data.SqlClient" />
  </connectionStrings>
```

por la siguinte cadena de conexión:

```xml
  <connectionStrings>
    <add name="DefaultConnection" connectionString="Data Source=DISPOSITIVO\SQLEXPRESS;Initial Catalog=InicioSesionDB;Integrated Security=True"
      providerName="System.Data.SqlClient" />
  </connectionStrings>
```

notar que los cambios fueron en el **Data Source=** `DISPOSITIVO\SQLEXPRESS` (nombre de la instancia de la DB), y en **Initial Catalog=** `InicioSesionDB` (Nombre de la base de datos creada).
