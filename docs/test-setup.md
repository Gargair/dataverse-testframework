# Test Setup

To set up tests using the Dataverse Test Framework, use the fluent `DataverseBuilder` API to configure your test environment. This includes loading metadata, data, and registering plugins, code activities, and custom APIs. The builder produces a mock `IOrganizationService` for use in your tests.

See `docs/example-usage.md` for a sample test using the builder and mock service. 