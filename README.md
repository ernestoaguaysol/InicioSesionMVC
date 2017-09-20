# Inicio de Sesión MVC

## Inicio de sesión con MVC .NET completo con Entity Framework

### Preparación del entorno

1. En la configuracion inicial del proyecto MVC en el apartado **Change Authentication** cambiar la confuración por   
** Individual User Accounts **.
2. Crear una base de datos local con **SQL Server Management Studio (SSMS)** con autentificacion de windows para probar.

> **Nota Importante:** no olvidar de compilar la solución. 

### Editando cadena de conexión

1. En **web.config** cambiar la cadena de conexión que se asemeja a la siguiente:
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

Notar que los cambios fueron en **Data Source=** `DISPOSITIVO\SQLEXPRESS` (nombre de la instancia de la DB), y en **Initial Catalog=** `InicioSesionDB` (Nombre de la base de datos creada).

### Configurar password más permisivo

1. En **App_Start** en la clase **IdentityConfig.cs** cambiar los siguientes valores:
```c#
// Configure validation logic for passwords
            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = true,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = true,
            };
```

por 

```c#
// Configure validation logic for passwords
            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false,
            };
```

En este caso solo se cambian los valores `true` por `false`, se deja que la contraseña tenga al menos 6 caracteres, pero se puede configurar a gusto de uno.

