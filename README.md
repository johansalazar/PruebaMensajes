# API para Gestión de Usuarios

Este proyecto es una API desarrollada en **ASP.NET Core** que permite recibir datos de un usuario, almacenarlos en memoria y simular el envío de un mensaje de bienvenida o confirmación.

## Características

- Recibir datos a través de una solicitud HTTP POST.
- Almacenar los datos en memoria.
- Simular el envío de un mensaje, registrándolo en los logs.
- Documentación integrada con **Swagger**.

## Requisitos previos

Asegúrate de tener instalados los siguientes componentes:

1. [.NET SDK 6.0 o superior](https://dotnet.microsoft.com/download/dotnet/6.0).
2. Un editor de texto o IDE como [Visual Studio](https://visualstudio.microsoft.com/) o [Visual Studio Code](https://code.visualstudio.com/).
3. Navegador web actualizado.

## Configuración y Ejecución

Sigue los siguientes pasos para ejecutar la API:

### 1. Clonar el repositorio

```bash
git clone <URL_DEL_REPOSITORIO>
cd <NOMBRE_DEL_PROYECTO>
```

### 2. Restaurar las dependencias

Ejecuta el siguiente comando para restaurar las dependencias necesarias del proyecto:

```bash
dotnet restore
```

### 3. Compilar el proyecto

Compila el proyecto para asegurarte de que todo esté correctamente configurado:

```bash
dotnet build
```

### 4. Ejecutar la API

Inicia la aplicación con el siguiente comando:

```bash
dotnet run
```

Esto iniciará la API y estará disponible en `https://localhost:<puerto>` (el puerto puede variar, normalmente es **5001** para HTTPS o **5000** para HTTP).

### 5. Acceder a Swagger

Una vez que la API esté en ejecución, puedes acceder a Swagger para interactuar con la API desde tu navegador:

- URL: `https://localhost:<puerto>/swagger`

Swagger proporcionará una interfaz visual para probar los endpoints de la API.

## Uso de la API

### Endpoint: Crear Usuario

- **URL**: `POST /api/Users`
- **Cuerpo de la solicitud (JSON):**

```json
{
  "name": "Juan Pérez",
  "phoneNumber": "1234567890"
}
```

- **Respuesta exitosa (JSON):**

```json
{
  "message": "Datos recibidos correctamente.",
  "user": {
    "name": "Juan Pérez",
    "phoneNumber": "1234567890"
  }
}
```

### Logs

Cuando se reciba y procese correctamente una solicitud, se registrará el siguiente mensaje en los logs:

```
Información: Mensaje de bienvenida enviado a Juan Pérez al número 1234567890.
```

## Tecnologías utilizadas

- **ASP.NET Core 6.0**
- **Swagger** para la documentación.

## Contacto

Si tienes alguna pregunta o sugerencia, no dudes en contactarme.

