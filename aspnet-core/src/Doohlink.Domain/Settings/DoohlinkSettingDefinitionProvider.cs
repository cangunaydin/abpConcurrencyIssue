using Volo.Abp.Settings;

namespace Doohlink.Settings;

public class DoohlinkSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(DoohlinkSettings.MySetting1));
    }
}
