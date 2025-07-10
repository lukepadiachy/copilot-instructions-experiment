# Adding Task-Specific Instructions

## Branch: part-four/add-task-specific-instruction
This branch introduces a **task-specific instruction and prompt system** for Copilot, focused on building a Pokémon data page in a Blazor Web App using the PokeApiNet NuGet package.


## What Was Achieved in This Branch
- Created a dedicated instruction file (`pokemon-page.instructions.md`) that acts like a strict teacher for Copilot, making sure it doesn’t sneak in any forbidden code, rogue services, or random Python packages. Every step is spelled out, from installing the right NuGet package to building the page and running the app.
- Added a prompt file (`pokemon-page.prompt.md`) that launches Copilot into agent mode, laser-focused on the Pokémon page task. It’s like giving Copilot a quest with a map and a list of things NOT to do (seriously, don’t touch those global stylesheets!).
- The result: a Blazor page that fetches and displays Pokémon data, with a sidebar link and a Poké Ball icon, all following best practices and avoiding classic mistakes.


## Repo Instructions vs. Task-Specific Instructions
- **Repo-level Copilot Instructions**: The big boss. Sets the rules for the whole repo—coding style, commit messages, and general behavior. Think of it as the company handbook Copilot must always follow.
- **Task-specific Instructions** (`pokemon-page.instructions.md`): The micro-manager. Applies only to one feature or task. It’s much more detailed, with step-by-step rules, forbidden moves, and a list of things that will make Copilot’s teacher very disappointed if broken.
- **Prompt Files**: The mission briefing. Tells Copilot exactly what to do for a specific task, referencing the task instructions for context. It’s the difference between “be a good coder” and “build this Pokémon page, and don’t you dare use lowercase property names!”


## What Copilot Did Wrong (So You Don’t Have To)
- Accidentally tried to use `poke.id` instead of `poke.Id`? That’s a one-way ticket to Errorville.
- Thought about creating a `pokemonService` class? Nope! The instructions say fetch data directly in the Razor page, or face the wrath of the forbidden mistakes list.
- Added a global stylesheet or imported `pokemon.css`? The instructions will find you. All styles must live inside the Pokémon page itself.
- Used direct HTTP calls or another library for Pokémon data? That’s a classic blunder—only PokeApiNet is allowed.
- Registered a service for Pokémon data? The instructions specifically say: “Do not.”


## Why This Matters
This branch is a practical example of how to use Copilot’s advanced customization features to guide and automate complex coding tasks with precision (and a little bit of sass). By separating global repo rules from task-specific instructions, you get:
- Consistency across the repo
- Laser-focused guidance for tricky features
- Fewer mistakes, more best practices
- A happier Copilot (and developer!)


## Resources to Learn More
* [Customize Copilot in VS Code](https://code.visualstudio.com/docs/copilot/copilot-customization)
* [GitHub Docs – Adding Repo Instructions](https://docs.github.com/en/copilot/how-tos/custom-instructions/adding-repository-custom-instructions-for-github-copilot)
* [Sample Chat Mode File by Burke Holland](https://gist.github.com/burkeholland/a232b706994aa2f4b2ddd3d97b11f9a7)
* [PokeApiNet - A .Net wrapper for the Pokemon API](https://gist.github.com/burkeholland/a232b706994aa2f4b2ddd3d97b11f9a7)


> In summary: This branch shows how to keep Copilot on a tight leash for special tasks, making sure it builds exactly what you want, how you want it, and with fewer “oops” moments along the way.
