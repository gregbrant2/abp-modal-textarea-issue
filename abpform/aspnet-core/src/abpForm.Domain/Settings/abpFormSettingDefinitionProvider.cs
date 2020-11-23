using Volo.Abp.Settings;

namespace abpForm.Settings
{
    public class abpFormSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(abpFormSettings.MySetting1));
        }
    }
}
