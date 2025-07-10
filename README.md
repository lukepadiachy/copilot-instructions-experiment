# Pokémon Page Branch

![Pokemon page](https://i.imgur.com/fxT8sPb.png)

## What This Branch Demonstrates
This branch showcases how to use **task-specific instructions** and **prompt files** to guide GitHub Copilot in building a feature-rich Pokémon data page in a Blazor Web App. Each branch in this repo demonstrates a different Copilot customization technique.

## What Was Created (by Copilot, using the instructions and prompt)
- **Blazor Web App** in `src/CopilotWebApp/CopilotWebApp/`
- **PokeApiNet NuGet package** installed and referenced in `CopilotWebApp.csproj`
- **Pokémon Gallery Page**: `Components/Pages/PokemonGallery.razor` (displays Pokémon name, image, types, abilities, with creative card/grid layout and self-contained CSS)
- **Sidebar Navigation Link**: Added to `Components/Layout/NavMenu.razor` (with Poké Ball icon, placed inside `<nav class="nav flex-column">`)
- **Poké Ball Icon CSS**: Added to `NavMenu.razor.css` for sidebar
- **No unnecessary @using imports**: Instructions enforced not to add extra imports unless required for build
- **No global stylesheet changes**: All Pokémon page styles are self-contained
- **No extra services or files**: Data is fetched directly in the Razor page, following best practices

## How Copilot Was Guided
- **pokemon-page.instructions.md**: Strict, step-by-step rules for building the Pokémon page, including forbidden mistakes and required layout/structure
- **pokemon-page.prompt.md**: Task-specific prompt that launches Copilot into agent mode, referencing the instructions file and focusing only on the Pokémon page task

## What You See in the Codebase
- `PokemonGallery.razor` – The main Pokémon page, with creative UI, data fetching, and all styles in a `<style>` block
- `NavMenu.razor` – Sidebar navigation with Pokémon link and icon, correctly placed
- `NavMenu.razor.css` – Poké Ball icon CSS
- `CopilotWebApp.csproj` – PokeApiNet package reference
- No unnecessary imports or global CSS changes

## What Was Accomplished
- Demonstrated how Copilot can be tightly guided to build a feature using only allowed patterns and best practices
- Showcased the power of prompt files and instructions to prevent common mistakes (like misplaced nav links or extra imports)
- Ensured the codebase is clean, maintainable, and matches the requirements exactly

## Resources to Learn More
* [Customize Copilot in VS Code](https://code.visualstudio.com/docs/copilot/copilot-customization)
* [GitHub Docs – Adding Repo Instructions](https://docs.github.com/en/copilot/how-tos/custom-instructions/adding-repository-custom-instructions-for-github-copilot)
* [Sample Chat Mode File by Burke Holland](https://gist.github.com/burkeholland/a232b706994aa2f4b2ddd3d97b11f9a7)
* [PokeApiNet - A .Net wrapper for the Pokemon API](https://github.com/PokeAPI/pokeapinet)

