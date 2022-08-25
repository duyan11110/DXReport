using Volo.Abp.Settings;

namespace Test.DXReport.Settings;

public class DXReportSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(DXReportSettings.MySetting1));
    }
}
