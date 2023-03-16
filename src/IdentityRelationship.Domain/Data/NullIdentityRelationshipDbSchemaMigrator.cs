using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace IdentityRelationship.Data;

/* This is used if database provider does't define
 * IIdentityRelationshipDbSchemaMigrator implementation.
 */
public class NullIdentityRelationshipDbSchemaMigrator : IIdentityRelationshipDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
