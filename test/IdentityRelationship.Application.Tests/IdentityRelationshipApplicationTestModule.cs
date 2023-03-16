using Volo.Abp.Modularity;

namespace IdentityRelationship;

[DependsOn(
    typeof(IdentityRelationshipApplicationModule),
    typeof(IdentityRelationshipDomainTestModule)
    )]
public class IdentityRelationshipApplicationTestModule : AbpModule
{

}
