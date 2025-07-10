# Part Three - Added Blazor Server App

![Blazor Sample App](https://i.imgur.com/oveKQpG.png)

## Achievements in This Branch

This branch successfully demonstrates the initialization and build of a modern .NET Blazor Web App using the latest .NET SDK (net9.0), following strict Copilot customization instructions. All requirements from the prompt and repo instructions were met:

- **Blazor Web App Created:**
  - The app was generated at `src/CopilotWebApp/CopilotWebApp` using the latest SDK, with no extra files or solution artifacts added.
  - The project builds and runs successfully out-of-the-box.

- **Copilot Customization Features:**
  - The repo includes `.github/copilot-instructions.md` and `initialize-blazor-server-app.prompt.md` prompt file to guide Copilot's behavior for code generation and chat.
  - All code and project structure strictly follow the provided instructions, ensuring reproducibility and clarity for future contributors.

- **Blazor App Features:**
  - Interactive server-side rendering (SSR) is enabled.
  - Core pages (Home, Counter, Weather, Error) and layouts are present, styled with Bootstrap and custom CSS.
  - Navigation and routing are set up for a smooth user experience.
  - The Weather page demonstrates streaming rendering and async data loading.

- **Successes & Impact:**
  - **Builds Properly:** The app compiles and runs with no errors, validating the process and instructions. (on my machine)
  - **Instruction-Driven Development:** The project is a working example of how Copilot can be customized and directed for precise, reliable code generation in .NET environments.
  - **Reference Implementation:** Serves as a template for initializing Blazor projects with Copilot, and for enforcing repo-specific coding standards.

## Side Note

It's okay to remove the auto-generated solution (.sln) file in the root directory for now. I'm still experimenting and will have one main solution file in the directory soon that will reference multiple projects. For now, you can safely delete the automatically generated .sln file if present.

## Resources to Learn More
* [Customize Copilot in VS Code](https://code.visualstudio.com/docs/copilot/copilot-customization)
* [GitHub Docs – Adding Repo Instructions](https://docs.github.com/en/copilot/how-tos/custom-instructions/adding-repository-custom-instructions-for-github-copilot)
* [Blazor Web App documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-9.0)
