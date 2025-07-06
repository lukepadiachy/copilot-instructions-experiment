---
description: "Instructions for building a Pokemon data page using PokeApiNet."
applyTo: "**"
---

> **Note:** When used with the refactor-data-services prompt or global Blazor data services best practices, all Pokémon data access must be via services. Ignore any instructions below that prohibit service usage.

# Build a Pokemon Data Page with PokeApiNet

## 1. Setup & Package Installation (DO THIS FIRST)

**You must install the PokeApiNet NuGet package before creating any pages or writing any code that references it.**

1. Locate the `.csproj` file for the Blazor Web App (e.g., `src/CopilotWebApp/CopilotWebApp/CopilotWebApp.csproj`).
2. Open a terminal and change directory to the folder containing the `.csproj` file:
   ```sh
   cd src/CopilotWebApp/CopilotWebApp
   ```
3. Install the PokeApiNet NuGet package:
   ```sh
   dotnet add package PokeApiNet
   ```
4. Confirm the package is listed in the `.csproj` file after installation.
5. **Only proceed to the next steps after the package is successfully installed for the project.**

## 2. Implementation Steps
### a. Add a Blazor Page and Navigation Link
- Create a new Razor page/component in `Components/Pages` (e.g., `Pokemon.razor`).
- Add a navigation link to your new page in `Components/Layout/NavMenu.razor`:
  ```razor
  <div class="nav-item px-3">
      <NavLink class="nav-link" href="pokemon">
          <span class="bi bi-pokeball-nav-menu" aria-hidden="true"></span> Pokémon
      </NavLink>
  </div>
  ```
- For the nav icon, check `NavMenu.razor.css` for `.bi-pokeball-nav-menu`. If missing, add a CSS rule using the Poké Ball SVG below. Always use both the `bi` class and the custom icon class.

  Example CSS for Poké Ball icon:
  ```css
  .bi-pokeball-nav-menu {
      background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='16' height='16' fill='white' viewBox='0 0 16 16'%3E%3Ccircle cx='8' cy='8' r='7' stroke='black' stroke-width='2' fill='white'/%3E%3Crect x='1' y='7' width='14' height='2' fill='red' stroke='black' stroke-width='0.5'/%3E%3Ccircle cx='8' cy='8' r='2.5' fill='white' stroke='black' stroke-width='1'/%3E%3Ccircle cx='8' cy='8' r='1' fill='white' stroke='black' stroke-width='1'/%3E%3C/svg%3E");
  }

### b. Avoid Duplicating @using Directives
- When adding `@using` directives to `_Imports.razor`, check if they already exist. Only add if not present. Example standard imports:
  ```razor
  @using System.Net.Http
  @using System.Net.Http.Json
  @using Microsoft.AspNetCore.Components.Forms
  @using Microsoft.AspNetCore.Components.Routing
  @using Microsoft.AspNetCore.Components.Web
  @using static Microsoft.AspNetCore.Components.Web.RenderMode
  @using Microsoft.AspNetCore.Components.Web.Virtualization
  @using Microsoft.JSInterop
  @using YourAppNamespace
  @using YourAppNamespace.Components
  ```

### c. Fetch Pokémon Data in the Razor Page
- Do **not** create or register a service, class, or file for Pokémon data.
- Do **not** use dependency injection or DI registration for Pokémon data.
- Fetch Pokémon data directly in the Razor page/component using PokeApiNet:
  ```csharp
  var page = await client.GetNamedResourcePageAsync<PokeApiNet.Pokemon>(limit: 12, offset: 0);
  foreach (var entry in page.Results)
  {
      var poke = await client.GetResourceAsync<PokeApiNet.Pokemon>(entry.Name);
      pokes.Add(poke);
  }
  ```
- Only create **one** Razor page/component for the Pokémon feature.
- Do not use direct HTTP calls or any other library for Pokémon data.

### d. UI & Coding Conventions
- Use PascalCase for your own C# properties and class names (e.g., `PokemonList`, `PokemonCard`).
- Use the property names as defined in PokeApiNet (PascalCase, e.g., `poke.Id`, `poke.Name`, `poke.Types`, `poke.Abilities`).
- Component class and file names use PascalCase (e.g., `Pokemon.razor`).
- Route templates use kebab-case (e.g., `@page "/pokemon-gallery"`).
- Use `@foreach` for iterating collections in Razor markup.
- Use `@code` blocks for C# logic.
- Only add `@using Microsoft.AspNetCore.Components` if you need framework types not already in scope.
- Avoid unnecessary or duplicate `@using` directives in `_Imports.razor`.

#### Example Razor Markup:
```razor
@foreach (var poke in pokemonList)
{
    <img src="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/@(poke.Id).png" alt="@poke.Name" />
    <h3>@poke.Name</h3>
    @foreach (var type in poke.Types)
    {
        <span>@type.Type.Name</span>
    }
    @foreach (var ab in poke.Abilities)
    {
        <span>@ab.Ability.Name</span>
    }
}
```


## 3. Common Mistakes to Avoid
- Never use lowercase property names for PokeApiNet models (e.g., `poke.id`).
- Never use the `PokeApiNet.Models.Pokemon` namespace.
- Never use direct HTTP calls or any other library for Pokémon data.
- Never create or register a service for Pokémon data. Fetch data directly in the Razor page/component.
- Never create more than one Razor page/component for the Pokémon feature.
- Never install Python packages or use Python tools for .NET/Blazor projects.
- For nav menu icons, always use both the `bi` class and the custom icon class together (e.g., `<span class="bi bi-pokeball-nav-menu"></span>`).
- If you accidentally create extra files, classes, or services, remove them and keep only the single Razor page/component.

### Do NOT add or modify global stylesheets or imports:
- Do **not** create or edit any CSS files outside of the Pokémon Razor page. All styling for the Pokémon page must be done using `<style>` blocks inside the `Pokemon.razor` file.
- Do **not** add `@import` statements to any CSS file. Never add `@import url('pokemon.css');` or similar to `app.css` or any other stylesheet.

### Do NOT add unnecessary @using directives:
- Do **not** add `@using Microsoft.AspNetCore.Components` unless the page fails to build without it. Only add new `@using` directives if you encounter a build error that specifically requires it.

### All code and styles for the Pokémon page must be self-contained:
- Place all custom CSS for the Pokémon page inside a `<style>` block at the bottom of `Pokemon.razor`.
- Do not create or edit any other files for styling or imports.


## 4. Common Errors to Avoid (Historical Mistakes)

**If you see any of the following errors, you are making a common mistake. Always check the PokeApiNet NuGet package documentation or source for the correct property names and usage.**

- `'Pokemon' does not contain a definition for 'id'` (should be `Id`)
- `'Pokemon' does not contain a definition for 'name'` (should be `Name`)
- `'Pokemon' does not contain a definition for 'types'` (should be `Types`)
- `'Pokemon' does not contain a definition for 'abilities'` (should be `Abilities`)
- `The type or namespace name 'Models' does not exist in the namespace 'PokeApiNet'` (do not use `PokeApiNet.Models.Pokemon`)
- `Cannot resolve symbol 'pokemonService'` or similar (do not create or register a service for Pokémon data)
- `No overload for method 'GetResourceAsync' takes 0 arguments` (always provide the Pokémon name or ID)
- Any error about missing or lowercase property names—always use PascalCase as defined in the NuGet package.

If you encounter any of these, review your code and instructions above. These errors have been seen before and are explicitly forbidden by these instructions.


## 5. Build & Run

- Always use the .NET CLI to build and run the project, not VS Code tasks.
- **Step-by-step:**
  1. Check your current directory. You must be in the folder containing the `.csproj` file (e.g., `src/CopilotWebApp/CopilotWebApp`).
  2. If not, change directory:
     ```sh
     cd src/CopilotWebApp/CopilotWebApp
     ```
  3. Build the project using the command line:
     ```sh
     dotnet build
     ```
  4. After a successful build, check your directory again to ensure you are still in the correct folder.
  5. Run the project using the command line:
     ```sh
     dotnet run
     ```
  6. As soon as you see output like:
     ```
     Using launch settings from .../launchSettings.json...
     Building...
     ```
     the project has started successfully—no need to wait for further output or keep the terminal open indefinitely.

**Do not use VS Code tasks or background tasks for build/run. Always use the command line and confirm the directory before each step.**

## 6. Guidance & Resources
- [PokeApiNet Usage](https://github.com/jtwotimes/PokeApiNet#use)
- [Microsoft C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- [Blazor component guidelines](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-9.0#component-classes)
- [Blazor Navigation and Layout](https://learn.microsoft.com/en-us/aspnet/core/blazor/layouts?view=aspnetcore-9.0#navigation)
- [Bootstrap Icons: Emoji Smile](https://icons.getbootstrap.com/icons/emoji-smile/)

## 7. Tips
- Reference the Weather page for structure, but focus on improving the UI/UX for the Pokémon page.
- If you need to see how PokeApiNet works, use the GitHub MCP agent to fetch code samples or documentation from the repo.