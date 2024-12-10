using Microsoft.AspNetCore.Mvc;

namespace ZooShop.Components
{
    public class MainMenuComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
