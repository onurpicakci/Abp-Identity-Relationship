using IdentityRelationship.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace IdentityRelationship.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(IdentityRelationshipEntityFrameworkCoreModule),
    typeof(IdentityRelationshipApplicationContractsModule)
    )]
public class IdentityRelationshipDbMigratorModule : AbpModule
{

}
