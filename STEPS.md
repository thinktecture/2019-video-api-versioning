# Einzelschritte / Steps

## Branch start-new-project

Deutsch:

Erzeuge ein neues WebApi Projekt, und installiere die notwendigen Abhängigkeiten von NuGet. Zur Nachvollziehbarkeit werden die SDK Version und alle Paket Versionen fest gepinnt.

English:

Create a new WebApi project and install the required dependencies from NuGet. To be reproducible the SDK version and the package versions are pinned.

Commandline:

```shell
dotnet new global --sdk-version 3.0.100
dotnet new webapi -n ApiVersioning
cd ApiVersioning
dotnet add package Microsoft.AspNetCore.Mvc.Versioning -v 4.0.0
```

## Branch add-basic-versioning

Deutsch:

1. Versionierungs-Funktionalität zum Startup hinzugefügt und dem Standard-Controller über ein Attribut die Version 1.0 zugewiesen.
2. Zwei neue Beispiel-Controller hinzugefügt mit einem versionierten Endpunkt. 
3. Neuer Controller mit zwei unterschiedlichen Versionen des gleichen Endpunkts hinzugefügt.

English:

1. Added versioning functionality to startup and used an attribute to assign version 1.0 to the default controller.
2. Added two new Sample controllers with versioned endpoints.
3. Added a new controller with two different versions of the same endpoint.

## Branch configure-api-versioning

Deutsch:

1. ReportApiVersions anschalten, um Informationen zur Version auszugeben. 
2. Versionsauswahl ändern auf Media Type.

English:

1. Enable reporting of api versions.
2. Change version selection to media type selector.
 
