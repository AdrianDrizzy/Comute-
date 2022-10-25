using Volo.Abp.Modularity;

namespace Co_Mute;

[DependsOn(
    typeof(Co_MuteApplicationModule),
    typeof(Co_MuteDomainTestModule)
    )]
public class Co_MuteApplicationTestModule : AbpModule
{

}
