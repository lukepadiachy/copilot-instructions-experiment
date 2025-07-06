# Copilot Instructions Experiment

## Overview

This repository is a step-by-step experiment in customizing GitHub Copilot using repository-level instructions, prompt files, and chat modes. Each branch in this repo represents a different stage or experiment in customizing Copilot, building on the previous steps. The **main** branch is the starting point and provides the foundational context for all experiments.

## Branch Guide & Purpose

- **main**: The starting point. Introduces the concept of customizing Copilot with repo-level instructions, prompt files, and chat modes. Use this branch to understand the basics and the motivation for the experiments.

- **part-one/add-copilot-instructions**: Demonstrates adding a `.github/copilot-instructions.md` file to set workspace-wide Copilot behavior and preferences.

- **part-two/add-copilot-prompts**: Adds reusable prompt files (e.g., for code review, security checks) that can be invoked in Copilot Chat, showing how to create and use task-specific prompts.

- **part-three/add-pokemon-blazor-project**: Introduces a .NET Blazor project as a practical playground for Copilot customization, enabling real-world testing of instructions and prompts.

- **part-four/add-task-specific-instruction**: Refines Copilot instructions to be more task-specific, showing how to guide Copilot for particular coding tasks or workflows.

- **part-five/add-pokemons-page**: Implements a new Pokémons page in the Blazor app, using Copilot prompts and instructions to build a visually appealing gallery with PokeApiNet.

- **part-six/add-service-refactor-instruction**: Focuses on best practices for Blazor data services, refactoring prompts and instructions to encourage clean architecture and separation of concerns.

- **part-seven/add-service-refactor**: Implements the refactored services and updates Blazor components to use them, demonstrating Copilot's ability to assist with larger-scale refactoring guided by custom instructions.

## How to Use This Repo

1. **Start on `main`** to understand the overall approach and why customizing Copilot is valuable.
2. **Checkout each `part-*` branch in order** to see how Copilot customization evolves step by step:
   - Review the Copilot instructions, prompt files, and code changes in each branch.
   - Try using Copilot Chat with the provided prompts and instructions.
   - Observe how Copilot's suggestions and behavior change as the instructions become more specific and the project grows.

## What You'll Learn

- How to set up repo-level Copilot instructions for consistent coding style and workflow.
- How to create and use prompt files for repeatable, task-specific Copilot chat commands.
- How to guide Copilot for real-world .NET/Blazor development, including UI, data fetching, and refactoring.
- How Copilot responds to increasingly specific and complex instructions.

## Resources to Learn More

- [Customize Copilot in VS Code](https://code.visualstudio.com/docs/copilot/copilot-customization)
- [GitHub Docs – Adding Repo Instructions](https://docs.github.com/en/copilot/how-tos/custom-instructions/adding-repository-custom-instructions-for-github-copilot)
- [Sample Chat Mode File by Burke Holland](https://gist.github.com/burkeholland/a232b706994aa2f4b2ddd3d97b11f9a7)
- [PokeApiNet - A .Net wrapper for the Pokemon API](https://gist.github.com/burkeholland/a232b706994aa2f4b2ddd3d97b11f9a7)

---

**This project is a living experiment. Each branch is a snapshot of Copilot customization at a different stage, with practical examples and lessons learned.**
