using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Owin;
namespace WebApplication6
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                LoginPath = new PathString("/Account/Index"),
                SlidingExpiration = true
            });
            app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            {
                ClientId = "821123405081-esm31hil4b96af615ii1sl6632fc51fg.apps.googleusercontent.com",
                ClientSecret = "GPW2J8Sje69yGzv49yjV6nrk",
                CallbackPath = new PathString("/GoogleLoginCallback")
            });
        }
    }
}