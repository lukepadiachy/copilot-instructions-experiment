# .NET Blazor Web App Setup

## Project Requirement

Create a .NET Blazor Web App at the location specified in the prompt (for example, inside a `src/` directory as requested).

## Instructions

1. **Check for the latest .NET SDK.**
   - Run:
     ```sh
     dotnet --list-sdks
     ```
   - If not installed, download from: https://dotnet.microsoft.com/download/dotnet
   - **Note:** Use the latest installed SDK (e.g., .NET 9.0 or higher) for all commands below.

2. **Create the Blazor Web App in the required location using the latest SDK.**
   - From the workspace root, run:
     ```sh
     dotnet new blazor -o 
     ```
   - This creates a Blazor Web App with the default interactive server-side rendering (SSR) experience. See [Blazor Web App documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-9.0) for more options.

## Constraints

- Do **not** add extra files, folders, or solution files unless specifically requested.
- Do **not** create a `global.json` or any other configuration unless asked.
- The only required output is the Blazor Web App in the specified directory.
- The project must build and run successfully after creation.

## References

- [Blazor Web App documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-9.0)
- [Copilot Customization Docs](https://code.visualstudio.com/docs/copilot/copilot-customization)
- [Awesome Copilot](https://github.com/github/awesome-copilot)

---

> **Tip:** These instructions are always included for code generation in this workspace. Keep all actions focused on the requirements above.
