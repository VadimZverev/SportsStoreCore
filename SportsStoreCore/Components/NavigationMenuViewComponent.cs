using Microsoft.AspNetCore.Mvc;

namespace SportsStoreCore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public string Invoke()
        {
            return "Hello from the Nav View Component";
        }
    }
}
