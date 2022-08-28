using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Module1.Web.Menus;

public class Module1MenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(Module1Menus.Prefix, displayName: "Module1", "~/Module1", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
