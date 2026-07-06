**This website file will be used for Azure App Service running ASP.NET Windows**

Architecture: 

# HR Portal App - ASP.NET Web Application Structure

## Project Structure

```
/HRPortalApp
│
├── Controllers/
│   └── HomeController.cs
│
├── Views/
│   └── Home/
│       └── Index.cshtml
│
├── wwwroot/
│   └── styles.css
│
└── Models/
```

---

## Folder Descriptions

### Controllers/
Contains application logic and request handling.

- `HomeController.cs`
  - Handles page routing
  - Manages download requests
  - Generates Azure Blob SAS URLs (or redirects)

---

### Views/
Contains UI templates (Razor Views).

- `Views/Home/Index.cshtml`
  - Main HR Portal homepage
  - Displays:
    - Employee Handbook download button
    - Leave Policy download button
    - UI for HR portal navigation

---

### wwwroot/
Static web assets served directly by ASP.NET Core.

- `styles.css`
  - Styling for HR Portal UI
  - Controls layout, colors, buttons, and responsiveness

---

### Models/
Contains data models (currently empty in this lab).

Future use:
- Employee data models
- HR document metadata models
- Storage file representations

---

## Purpose of This Structure

This structure represents a **basic ASP.NET Core MVC web application** hosted on:

- Azure App Service (Windows)
- OR local IIS server (for development/testing)

It is designed to:

- Demonstrate Azure App Service hosting
- Integrate with Azure Storage (via SAS URLs)
- Simulate enterprise HR portal architecture
- Separate concerns (MVC pattern)

---

## Azure Integration Overview

| Component | Azure Service |
|----------|---------------|
| Controllers | App Service runtime logic |
| Views | UI hosted in App Service |
| wwwroot | Static assets served via App Service |
| Storage Access | Azure Blob Storage (SAS-based download) |

---

## Notes for Students

- Do NOT modify Controllers logic unless instructed
- Update SAS tokens in `HomeController.cs`
- Ensure Storage container names match configuration
- Deploy using Visual Studio or Azure App Service deployment

---
