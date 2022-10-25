using Co_Mute.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Co_Mute.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class Co_MutePageModel : AbpPageModel
{
    protected Co_MutePageModel()
    {
        LocalizationResourceType = typeof(Co_MuteResource);
    }
}
