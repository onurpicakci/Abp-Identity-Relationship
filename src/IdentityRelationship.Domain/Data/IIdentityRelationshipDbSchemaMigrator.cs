using System.Threading.Tasks;

namespace IdentityRelationship.Data;

public interface IIdentityRelationshipDbSchemaMigrator
{
    Task MigrateAsync();
}
