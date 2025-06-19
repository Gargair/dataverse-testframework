# Folder Structure

```
/ (root)
│
├── src/                  # All production code
│   ├── Core/             # Core abstractions, interfaces, and base classes
│   ├── Plugins/          # Plugin test helpers and runners
│   ├── CodeActivities/   # Code activity test helpers and runners
│   ├── Mocks/            # Mocks, fakes, and test doubles for Dataverse
│   └── Runner/           # CLI or UI for running tests
│
├── tests/                # All test code (unit, integration, scenario)
│   ├── Core/
│   ├── Plugins/
│   ├── CodeActivities/
│   └── Mocks/
│
├── docs/                 # Documentation
│   └── architecture-and-structure.md
│
├── examples/             # Example test projects and sample plugins/code activities
│
├── .editorconfig         # Coding standards
├── .gitignore
├── README.md
└── package/project files (e.g., .csproj, package.json)
``` 