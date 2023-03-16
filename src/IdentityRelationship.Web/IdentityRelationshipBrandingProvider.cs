using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace IdentityRelationship.Web;

[Dependency(ReplaceServices = true)]
public class IdentityRelationshipBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "IdentityRelationship";
}
