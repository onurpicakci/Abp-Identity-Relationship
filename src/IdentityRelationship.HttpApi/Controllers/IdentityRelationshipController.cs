using IdentityRelationship.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace IdentityRelationship.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class IdentityRelationshipController : AbpControllerBase
{
    protected IdentityRelationshipController()
    {
        LocalizationResource = typeof(IdentityRelationshipResource);
    }
}
