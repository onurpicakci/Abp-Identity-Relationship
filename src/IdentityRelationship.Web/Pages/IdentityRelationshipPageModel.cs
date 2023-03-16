using IdentityRelationship.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace IdentityRelationship.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class IdentityRelationshipPageModel : AbpPageModel
{
    protected IdentityRelationshipPageModel()
    {
        LocalizationResourceType = typeof(IdentityRelationshipResource);
    }
}
