using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Co_Mute;

public class Co_MuteWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<Co_MuteWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
