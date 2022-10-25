using Co_Mute.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Co_Mute.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Co_MuteController : AbpControllerBase
{
    protected Co_MuteController()
    {
        LocalizationResource = typeof(Co_MuteResource);
    }
}
