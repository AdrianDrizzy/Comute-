using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Co_Mute.Web;

[Dependency(ReplaceServices = true)]
public class Co_MuteBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Co_Mute";
}
