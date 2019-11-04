# Einzelschritte / Steps

## Branch start-new project

Erzeuge ein neues WebApi Projekt, und installiere die notwendigen Abhängigkeiten von NuGet. Zur Nachvollziehbarkeit werden die SDK Version und alle Paket Versionen fest gepinnt.

Create a new WebApi project and install the required dependencies from NuGet. To be reproducible the SDK version and the package versions are pinned.

Commandline:

```shell
dotnet new global --sdk-version 3.0.100
dotnet new webapi -n ApiVersioning
cd ApiVersioning
dotnet add package Microsoft.AspNetCore.Mvc.Versioning -v 4.0.0
```
