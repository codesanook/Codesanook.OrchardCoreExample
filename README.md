# Codesanook.OrchardCoreExample
Custom theme for OrchardCore and deploy to Azure App Service With GitHub hook

- Create a Nuget.config with the following content
```
<?xml version="1.0" encoding="utf-8"?>
<configuration>
    <packageSources>
        <add key="Orchard Core Preview Feed" value="https://www.myget.org/F/orchardcore-preview/api/v3/index.json" />
    </packageSources>
</configuration>
```
- Restart Visual Studio to enable the configuration 

- Reference OrchardCore.Application.Cms.Targets to the main project by adding the following code to  .csproj
```
  <ItemGroup>
    <PackageReference Include="OrchardCore.Application.Cms.Targets" Version="1.0.0-rc1-11492" />
  </ItemGroup>

```
- Build the solution
- Add `services.AddOrchardCms();` to Startup.ConfigureServices method
- Add  `app.UseOrchardCore();` to Startup.Configure method

- Create new theme project as .NET Core class library
- Add the following code to the .csproj
```
    <AddRazorSupportForMvc>true</AddRazorSupportForMvc>
```
- Add the following dependencies
```
  <ItemGroup>
    <PackageReference Include="OrchardCore.Theme.Targets" Version="1.0.0-rc1-11492" />
    <PackageReference Include="OrchardCore.DisplayManagement" Version="1.0.0-rc1-11492" />
    <PackageReference Include="OrchardCore.ResourceManagement.Abstractions" Version="1.0.0-rc1-11492" />
  </ItemGroup>
```
TODO will be back to Node.js

- Set Startup class to dervice from OrchardCore.Modules.StartupBase

- Add support ResourceManifest to Starup.ConfigureServices
```
public override void ConfigureServices(IServiceCollection serviceCollection)
{
	serviceCollection.AddScoped<IResourceManifestProvider, Coresanook.TheCreativeTheme.ResourceManifest>();
}
```
- Back to the main project and reference a theme project

- In the theme project, use OrchardCore TheAgencyTheme project as a templaet 
- Copy Recipes, Views, Assets.json, Manifest.cs to the project
- Create wwwroot folder and copy all content of downloaded The CreativeTheme to inside wwwroot
- Rename index.html to Layout.lquid and move to Views folder 
    

