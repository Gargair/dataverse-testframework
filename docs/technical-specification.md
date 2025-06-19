# Technical Specification

- **Language**: .NET (C#) recommended for compatibility with Dataverse SDKs.
- **Target Framework**: .NET Framework 4.6.2. This is required because Dataverse plugins and code activities must be built against .NET Framework 4.6.2 for deployment and compatibility. Using this version for the test framework minimizes compatibility issues when instantiating and testing plugins and code activities.
- **Testing Framework**: xUnit, NUnit, or MSTest (configurable).
- **Mocking**: Moq or similar for mocking Dataverse services.
- **IOrganizationService Mimicry**: The framework must provide a robust, extensible mock or in-memory implementation of `IOrganizationService` to simulate Dataverse operations.
- **Metadata & Data Loading**: The framework must support loading entity metadata and test data from files (e.g., JSON, XML, YAML) or programmatically, to enable realistic test scenarios.
- **Extensibility**: All core components must be interface-driven and open for extension.
- **Continuous Integration**: GitHub Actions or Azure DevOps for automated builds and test runs.
- **Documentation**: All public APIs and architectural decisions must be documented in `/docs`. 