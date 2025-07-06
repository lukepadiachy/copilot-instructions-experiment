---
description: "Refactor Weather and Pokemon pages to use data services instead of inline data loading."
mode: agent
---

# Refactor Blazor Data Loading to Services

Right now, the Weather and Pokemon pages have inline data loading, which makes it hard to maintain and extend.

**Task:**  
- Create new services for Weather and Pokemon data.
- Move all data-fetching logic from the pages into these services.
- Register and inject these services using Blazor's dependency injection.
- Update the pages to use the services instead of inline logic.

**Requirements:**  
- Follow best practices for Blazor data access and service structure.
- Use async methods and proper error handling.
- Ensure the UI remains responsive and loading states are handled.
> See [blazor-data-services.instructions.md](../instructions/blazor-data-services.instructions.md) for best practices.
