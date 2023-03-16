using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace IdentityRelationship;

public class IdentityRelationshipWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<IdentityRelationshipWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
