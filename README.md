
# Part One - Add Copilot Instructions


![Description of image](https://i.imgur.com/5aGdG5h.png)


This branch demonstrates how to use repository-level Copilot instructions to guide code generation and workflow in your project.

## What Are Copilot Instructions?

`.github/copilot-instructions.md` is a markdown file in your repo that sets rules, preferences, and constraints for Copilot. It helps you:
- Control coding style and file structure
- Enforce workflow requirements
- Prevent unwanted files or actions

See: [Customize Copilot in VS Code](https://code.visualstudio.com/docs/copilot/copilot-customization)

## Experiment: How Instructions Affect Copilot

Follow these steps to see the difference Copilot instructions make:

1. **Try Without Instructions:**
   - Remove or rename `.github/copilot-instructions.md` (if present).
   - Ask Copilot to create a .NET Blazor server app at `src/CopilotWebApp/CopilotWebApp`.
   - Observe what files are generated and how Copilot responds.

2. **Try With Instructions:**
   - Restore or re-add `.github/copilot-instructions.md` with your custom rules.
   - Repeat the same prompt.
   - Compare the results—notice changes in file structure, constraints, and Copilot's adherence to your requirements.

### Goals of Our Copilot Instructions

Our instructions aimed to:
- **Enforce the app path:** Only create the Blazor app at the specified location.
- **Avoid extra files:** No solution/config files unless requested.
- **Ensure build/run success:** The app must build and run after creation.
- **Provide references:** Link to relevant docs and resources.
- **Set clear boundaries:** Define what Copilot should and shouldn't do.

This experiment shows how Copilot can be tailored to your team's standards and workflow.

## Lessons Learned

- **Path matters:** Copilot follows your specified path—if you forget, it may use a default location.
- **Strictness:** Overly strict instructions can cause build/run issues if necessary steps are skipped.
- **No extra files:** Copilot avoids adding files unless you ask for them.
- **Chat context:** Copilot uses your instructions for every code generation step—be clear and specific.

**Tip:** Always double-check your instructions and Copilot's output to ensure your requirements are met.

## Resources

- [GitHub Docs – Adding Repo Instructions](https://docs.github.com/en/copilot/how-tos/custom-instructions/adding-repository-custom-instructions-for-github-copilot)
