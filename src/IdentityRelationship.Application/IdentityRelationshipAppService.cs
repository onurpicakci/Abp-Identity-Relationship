using System;
using System.Collections.Generic;
using System.Text;
using IdentityRelationship.Localization;
using Volo.Abp.Application.Services;

namespace IdentityRelationship;

/* Inherit your application services from this class.
 */
public abstract class IdentityRelationshipAppService : ApplicationService
{
    protected IdentityRelationshipAppService()
    {
        LocalizationResource = typeof(IdentityRelationshipResource);
    }
}
