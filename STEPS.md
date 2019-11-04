# Einzelschritte / Steps

## Branch start-new-project

Erzeuge ein neues WebApi Projekt, und installiere die notwendigen Abhängigkeiten von NuGet. Zur Nachvollziehbarkeit werden die SDK Version und alle Paket Versionen fest gepinnt.

Create a new WebApi project and install the required dependencies from NuGet. To be reproducible the SDK version and the package versions are pinned.

Commandline:

```shell
dotnet new global --sdk-version 3.0.100
dotnet new webapi -n ApiVersioning
cd ApiVersioning
dotnet add package Microsoft.AspNetCore.Mvc.Versioning -v 4.0.0
```

## Branch add-basic-versioning

Versionierungs-Funktionalität zum Startup hinzugefügt und dem Standard-Controller über ein Attribut die Version 1.0 zugewiesen.

Added versioning functionality to startup and used an attribute to assign version 1.0 to the default controller.
