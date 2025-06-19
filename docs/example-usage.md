Example using xunit

```csharp
public TestSuite {
    public TestSuite() {
        _dataverse = new DataverseBuilder()
            .WithMetadataFromFile(filePath1)
            .WithMetadataFromFile(filePath2)
            .WithMetadataEntity((configureEntity) => {
                configureEntity.LogicalName = logicalname;
                configureEntity.IsOrganizationOwned = false;
                configureEntity
                    .WithAttribute(name, type)
                // Other configuration
            })
            .WithDataFromFile(filePath3)
            .WithRecord((configureRecord) => {})
            .WithRegisteredPlugin((configurePlugin) => {
                configurePlugin.Type = PluginType;
                configurePlugin
                    .AddStep((configureStep) => {
                        configureStep.Message = "Update";
                        configureStep.PrimaryEntity = logicalname;
                        configureStep.FilteringAttributes = [someAttribute];
                        // Other configuration like images
                    });
            })
            .WithRegisteredCodeActivity((configureCodeActivity) => {
                // Configure it similar to plugin
            })
            .WithRegisteredCustomApi((configureCustomApi) => {
                configureCustomApi.Type = PluginType;
                configureCustomApi.Message = customApiName;
                configureCustomApi
                    .AddInputParameter(name, type, required)
                    .AddInputParameter(name, type, required)
                    .AddOutputParameter(name, type);
            })
            .Build();
    }

    [Fact]
    public void Test_For_Something() {
        Entity someEntity = new Entity(logicalname, id);
        someEntity[someAttribute] = someValue;

        _dataverse.Update(someEntity);

        Assert.Equal(_dataverse.Storage[logicalname][id][someAttribute], someOtherValueInfluencedByPlugin);
    }
}
```