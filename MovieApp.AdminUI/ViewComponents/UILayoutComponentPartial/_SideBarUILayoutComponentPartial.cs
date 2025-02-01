using Microsoft.AspNetCore.Mvc;

namespace MovieApp.AdminUI.ViewComponents.UILayoutComponentPartial
{
    public class _SideBarUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
