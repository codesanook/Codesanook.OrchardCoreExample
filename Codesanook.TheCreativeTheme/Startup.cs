using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace TheCreativeTheme
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection serviceCollection)
        {
            //serviceCollection.AddScoped<IResourceManifestProvider, Coresanook.TheCreativeTheme.ResourceManifest>();
        }
    }
}
