using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(WeightWatcher.Areas.Identity.IdentityHostingStartup))]
namespace WeightWatcher.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => { });
        }
    }
}