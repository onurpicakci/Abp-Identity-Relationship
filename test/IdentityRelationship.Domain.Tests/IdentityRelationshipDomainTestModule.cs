using IdentityRelationship.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace IdentityRelationship;

[DependsOn(
    typeof(IdentityRelationshipEntityFrameworkCoreTestModule)
    )]
public class IdentityRelationshipDomainTestModule : AbpModule
{

}
