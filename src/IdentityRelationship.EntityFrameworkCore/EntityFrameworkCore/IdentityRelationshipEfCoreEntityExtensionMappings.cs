using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace IdentityRelationship.EntityFrameworkCore;

public static class IdentityRelationshipEfCoreEntityExtensionMappings
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        IdentityRelationshipGlobalFeatureConfigurator.Configure();
        IdentityRelationshipModuleExtensionConfigurator.Configure();

        OneTimeRunner.Run(() =>
        {
            ObjectExtensionManager.Instance
                .MapEfCoreProperty<IdentityUser, Guid>(
                    "DepartmentId",
                    (entityBuilder, propertyBuilder) => { propertyBuilder.HasMaxLength(128); }
                );
                
        });
    }
}
