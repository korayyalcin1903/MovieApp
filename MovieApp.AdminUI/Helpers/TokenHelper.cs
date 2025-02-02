using System.Net.Http.Headers;

namespace MovieApp.AdminUI.Helpers
{
    public class TokenHelper
    {
        public static void AddAuthorizationHeader(HttpClient client, HttpContext httpContext)
        {
            var token = httpContext.Session.GetString("AuthToken");

            if (!string.IsNullOrEmpty(token))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }
    }
}
