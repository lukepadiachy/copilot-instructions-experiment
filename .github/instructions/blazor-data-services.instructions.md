---
description: "Best practices for Blazor data access and service usage."
applyTo: "**"
---


# Blazor Data Services Best Practices

## 🚨 Build & Run Verification is Mandatory

**After making any code changes, you MUST build and run the project using the .NET CLI to ensure the project works as expected.**

- This is a required step for every code or refactor task.
- Do not consider a task complete until the project builds and runs successfully.
- If the project does not build or run, you must fix all errors before finishing.
- Always use the .NET CLI (not VS Code tasks or background tasks) and confirm you are in the correct directory (the one containing the `.csproj` file).

**Example required steps:**

```sh
cd src/CopilotWebApp/CopilotWebApp
dotnet build
dotnet run
```


If you see any errors, you must resolve them before considering the task done.

**Note:** You may safely ignore any warning or error related to `<PageTitle>` not being recognized. This is a normal and expected behavior in Blazor projects and does not affect functionality.


- **Use Services for Data Access (All Pages):**  
  Move all data-fetching logic out of Razor pages/components and into injectable services for **every page/component** that loads data (not just Weather). This includes pages like Weather, Pokemon, or any other with inline data loading.  
  **Do not leave data-fetching logic inline in Razor files.**

  **Folder/Namespace Structure:**
  - Place all data models in a `Models` (or `Data`) folder/namespace.
  - Place all service interfaces in an `Interfaces` folder/namespace.
  - Place all service implementations in a `Services` folder/namespace.

  **Example:**
  ```csharp
  // Models/WeatherForecast.cs
  public class WeatherForecast { ... }

  // Interfaces/IWeatherService.cs
  public interface IWeatherService { Task<WeatherForecast[]> GetForecastAsync(); }

  // Services/WeatherService.cs
  public class WeatherService : IWeatherService { ... }
  ```

- **Register Services in DI (Cleanly):**  
  Register all services in `Program.cs` using clean `using` statements for namespaces, not inline type names. Example:
  ```csharp
  using YourAppNamespace.Interfaces;
  using YourAppNamespace.Services;
  // ...
  builder.Services.AddScoped<IWeatherService, WeatherService>();
  builder.Services.AddScoped<IPokemonService, PokemonService>();
  ```


- **Inject Services in Components (Best Practices):**
  - Place all `@using` directives and `@inject` statements at the very top of each Razor page/component, before any markup or `@page` directive. This keeps the file clean and readable.
  - Add a single `@using` directive for your interfaces/services namespace (e.g., `@using CopilotWebApp.Interfaces`) at the top of the Razor file or in `_Imports.razor` if used throughout the app.
  - Use the `@inject` directive or `[Inject]` attribute to access services in your Razor components, directly after `@using` directives.
  - **Do not use fully qualified names in `@inject`.**
    - **Correct:**
      ```razor
      @using CopilotWebApp.Interfaces
      @inject IPokemonService PokemonService
      ```
    - **Preferred naming:**
      ```razor
      @inject IPokemonService _pokemonService
      ```
  - Use PascalCase or _camelCase for injected service property names (e.g., `WeatherService`, `_weatherService`).
  - Avoid duplicate or unnecessary `@using` directives.

---


## Razor Page Refactor Checklist

When updating or refactoring a Razor page/component, always check off each item below:

```markdown
- [ ] All `@using` directives and `@inject` statements are at the very top of the file, before any `@page` or markup.
- [ ] Only a single `@page` directive per file, and it is at the top (after usings/injects).
- [ ] No duplicate page/component markup or large markup blocks within the same file.
- [ ] Old or duplicate code blocks are removed, especially after refactoring from inline data to service-based data.
- [ ] Only one `@code` block per file, placed at the bottom of the file.
- [ ] Markup is clean and UI elements are not repeated unless required for the design.
- [ ] No duplicate or conflicting logic, markup, or directives remain.
- [ ] After refactoring, the file is clear and maintainable—no duplicate pages, no repeated logic, and all usings/injects at the top.
- [ ] Project builds and runs successfully, and the Razor page works as expected.
```

---

- **Async Data Loading:**  
  Always use `async`/`await` for data loading. Use `OnInitializedAsync` for initial data fetch.

- **MVVM/Separation of Concerns:**  
  Keep UI logic in components and business/data logic in services.  
  Avoid direct HTTP or data access in Razor files.

- **Error Handling and Loading States:**  
  Show loading indicators and handle errors gracefully in the UI.

- **Consistent Naming and Structure:**  
  Use PascalCase for class and property names.  
  Place models, interfaces, and services in their respective folders/namespaces as above.

- **Testing:**  
  Make services testable by using interfaces and dependency injection.

- **Special Cases:**
  If a page/component must not use a service (e.g., due to a third-party library or explicit business rule), document the reason clearly in the code and instructions. Otherwise, all data-loading should use the service pattern.


- **References:**  
  - [Blazor DI and services](https://learn.microsoft.com/en-us/aspnet/core/blazor/fundamentals/dependency-injection)
  - [MVVM in Blazor](https://learn.microsoft.com/en-us/windows/uwp/data-binding/data-binding-and-mvvm#app-layers)
  - [Clean Architecture](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures#clean-architecture)
  - [Copilot Customization](https://code.visualstudio.com/docs/copilot/copilot-customization)
