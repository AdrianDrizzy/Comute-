using System;
using System.Collections.Generic;
using System.Text;
using Co_Mute.Localization;
using Volo.Abp.Application.Services;

namespace Co_Mute;

/* Inherit your application services from this class.
 */
public abstract class Co_MuteAppService : ApplicationService
{
    protected Co_MuteAppService()
    {
        LocalizationResource = typeof(Co_MuteResource);
    }
}
