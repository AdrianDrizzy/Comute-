using Volo.Abp.Settings;

namespace Co_Mute.Settings;

public class Co_MuteSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(Co_MuteSettings.MySetting1));
    }
}
