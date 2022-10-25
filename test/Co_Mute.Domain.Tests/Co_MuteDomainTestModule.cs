using Co_Mute.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Co_Mute;

[DependsOn(
    typeof(Co_MuteEntityFrameworkCoreTestModule)
    )]
public class Co_MuteDomainTestModule : AbpModule
{

}
