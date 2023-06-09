﻿using System;
using System.ComponentModel.DataAnnotations;
using IdentityRelationship.Users;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace IdentityRelationship;

public static class IdentityRelationshipModuleExtensionConfigurator
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        OneTimeRunner.Run(() =>
        {
            ConfigureExistingProperties();
            ConfigureExtraProperties();
        });
    }

    private static void ConfigureExistingProperties()
    {
        /* You can change max lengths for properties of the
         * entities defined in the modules used by your application.
         *
         * Example: Change user and role name max lengths

           IdentityUserConsts.MaxNameLength = 99;
           IdentityRoleConsts.MaxNameLength = 99;

         * Notice: It is not suggested to change property lengths
         * unless you really need it. Go with the standard values wherever possible.
         *
         * If you are using EF Core, you will need to run the add-migration command after your changes.
         */
    }

    private static void ConfigureExtraProperties()
    {
        OneTimeRunner.Run(() =>
        {
            /* You can configure extra properties for the
             * entities defined in the modules used by your application.
             *
             * This class can be used to define these extra properties
             * with a high level, easy to use API.
             *
             * Example: Add a new property to the user entity of the identity module
            */
            ObjectExtensionManager.Instance.Modules()
                .ConfigureIdentity(identity =>
                {
                    identity.ConfigureUser(user =>
                    {
                        user.AddOrUpdateProperty<string>( //property type: string
                            "IdentificationNumber", //property name
                            property =>
                            {
                                //validation rules
                                property.Attributes.Add(new RequiredAttribute());
                                property.Attributes.Add(new StringLengthAttribute(11) { MinimumLength = 11 });

                                property.Configuration
                                    [IdentityModuleExtensionConsts.ConfigurationNames.AllowUserToEdit] = true;

                                //...other configurations for this property
                            }
                        );
                        
                        user.AddOrUpdateProperty<Guid>(
                            "DepartmentId",
                            property =>
                            {
                                property.UI.Lookup.Url = "/api/app/department";
                                property.UI.Lookup.DisplayPropertyName = "name";
                            }
                        );
                    });
                });

            /*
            * See the documentation for more:
          * https://docs.abp.io/en/abp/latest/Module-Entity-Extensions
          */
        });
    }
}
