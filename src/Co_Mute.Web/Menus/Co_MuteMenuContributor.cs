using System.Threading.Tasks;
using Co_Mute.Localization;
using Co_Mute.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Co_Mute.Web.Menus;

public class Co_MuteMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<Co_MuteResource>();

        context.Menu.Items.Add(
            new ApplicationMenuItem("Co-Mute",
                l["Home"],
                "~/",
                icon: "fas fa-home"
            )
        );
        context.Menu.AddItem(
    new ApplicationMenuItem(
        "Carpool",
        l["Car-pool Opportunity"],
        icon: "fa fa-automobile"
    ).AddItem(
        new ApplicationMenuItem(
            "Carpool.Carpools",
            l["Carpools"],
            url: "/Carpools"
        )
    )
);


        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
    }
}
