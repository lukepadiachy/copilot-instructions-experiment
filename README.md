# Part Two - Add Prompt File

## What This Branch Demonstrates
This branch is **part two** of the Copilot customization experiment, focusing on **Prompt Files**. Prompt files let you define reusable instructions for Copilot chat, making it easy to run complex or repetitive tasks with a single command.



## What Are Prompt Files?
Prompt files are markdown files (usually in `.github/prompts/`) that contain instructions for Copilot. They:
- Automate project setup, code generation, or other repetitive development tasks
- Provide step-by-step guidance for common workflows
- Are triggered by typing `/` in Copilot chat or by referencing their name

**Example:**
- `initialize-blazor-server-app.prompt.md` sets up a Blazor app in a specific folder with strict requirements, using the latest .NET SDK.


## How to Use Prompt Files in This Repo
1. **Trigger a Prompt File in Copilot Chat:**
   - Type `/initialize-blazor-server-app` in Copilot chat, or select it from the prompt list.
   - Copilot will follow the instructions in the prompt file to perform the task.
2. **Test With and Without the Prompt:**
   - Try running the same task manually in chat (without `/` or the prompt file) and compare results.
   - Notice how the prompt file enforces requirements and automates the workflow.


## Breakdown: Purpose of Each Section
- **Description:** What the prompt does and when to use it.
- **Mode:** How Copilot should behave (e.g., agent mode for automation).
- **Instructions:** Step-by-step actions Copilot should take.
- **References:** Links to official docs for further reading.



## Why Use Prompt Files?
- **Reusable Components:** Prompt files are building blocks for your workflow. Create prompts for any tech stack or task, such as initializing a Blazor app, scaffolding components, or running tests.
- **Consistency:** Ensures tasks are performed the same way every time, following your team's standards.
- **Speed:** Automates repetitive or complex workflows, saving time and reducing manual errors.
- **Customization:** Tailors Copilot to your project's needs, making it easy to adapt instructions for different stacks or scenarios.



## Try It Yourself
- Open Copilot chat in VS Code.
- Type `/` and select `/initialize-blazor-server-app` to watch Copilot set up the Blazor app as described in the prompt file.
- Try running the same setup manually in chat (without `/` or the prompt file) and compare the experience.
- Experiment with other prompt files or create your own in `.github/prompts/` for different tech stacks or tasks.


## Resources
- [Copilot Prompt Files Docs](https://code.visualstudio.com/docs/copilot/copilot-customization)
- [Blazor Web App documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-9.0)
- [GitHub Docs – Adding Repo Instructions](https://docs.github.com/en/copilot/how-tos/custom-instructions/adding-repository-custom-instructions-for-github-copilot)

---

> **Side Note:** Using the `tools:` section in prompts can sometimes be tedious or not work as intended. You may find better results by letting Copilot handle tasks without specifying tools directly. This project works best when you use prompt files without the `tools:` section, but feel free to experiment and see what works for your workflow.

> **Tip:** Prompt files are a powerful way to make Copilot work for you. Use them to automate, standardize, and simplify your development workflow. They are reusable and can be adapted for any project or stack.
