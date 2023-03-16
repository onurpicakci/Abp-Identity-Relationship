using Volo.Abp.Settings;

namespace IdentityRelationship.Settings;

public class IdentityRelationshipSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(IdentityRelationshipSettings.MySetting1));
    }
}
