using System.Collections.Generic;
using MvvmHelpers;
using PlaygroundDemo.Models.NavigationMenu;

namespace PlaygroundDemo.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}