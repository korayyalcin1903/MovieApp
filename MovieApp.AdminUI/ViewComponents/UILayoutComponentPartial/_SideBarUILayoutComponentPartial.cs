using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace MovieApp.AdminUI.ViewComponents.UILayoutComponentPartial
{
    public class _SideBarUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var token = HttpContext.Session.GetString("AuthToken");
            if (!string.IsNullOrEmpty(token))
            {
                var handler = new JwtSecurityTokenHandler();
                var jwtToken = handler.ReadJwtToken(token);

                var user = jwtToken.Claims.ToDictionary(x => x.Type, x => x.Value);
                ViewBag.User = user;
                Console.WriteLine(user["unique_name"]);
            }
            return View();
        }
    }
}
