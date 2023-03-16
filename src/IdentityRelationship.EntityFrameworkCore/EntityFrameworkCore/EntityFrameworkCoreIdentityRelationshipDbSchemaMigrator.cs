using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using IdentityRelationship.Data;
using Volo.Abp.DependencyInjection;

namespace IdentityRelationship.EntityFrameworkCore;

public class EntityFrameworkCoreIdentityRelationshipDbSchemaMigrator
    : IIdentityRelationshipDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreIdentityRelationshipDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the IdentityRelationshipDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<IdentityRelationshipDbContext>()
            .Database
            .MigrateAsync();
    }
}
