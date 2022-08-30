using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Logging;
using System.Threading.Tasks;

namespace NINDS_IRMB_APP.Auth
{
    public static class OpenIdConnectConfigureService
    { 
        public static IServiceCollection AddOpenIdConnectConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            IdentityModelEventSource.ShowPII = true;
            services.Configure<OidcOptions>(configuration.GetSection("Auth"));

            // Allow sign in via Lab Share
            services.AddAuthentication(options => {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme; 
                options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;

                //options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                //options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
            .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddOpenIdConnect(OpenIdConnectDefaults.AuthenticationScheme, options =>
            {
                options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.ClientId = configuration.GetValue<string>("Auth:ClientId");
                options.ClientSecret = configuration.GetValue<string>("Auth:ClientSecret");
                options.Authority = configuration.GetValue<string>("Auth:Authority");
                options.ResponseType = configuration.GetValue<string>("Auth:ResponseType");

                options.Scope.Add("openid");
                options.Scope.Add("profile");
                options.Scope.Add("email");
                options.Scope.Add("roles");

                //options.RequireHttpsMetadata = true;
                options.GetClaimsFromUserInfoEndpoint = true;
                options.SaveTokens = true;
                //options.UsePkce = true; 

                options.Events.OnAuthenticationFailed = (context) =>
                {
                    context.Response.Redirect("/Home/Error");
                    context.HandleResponse();
                    return Task.FromResult(0);
                };

                options.Events.OnAccessDenied = (context) =>
                {
                    context.Response.Redirect("/Account/AccessDenied");
                    context.HandleResponse();
                    return Task.FromResult(0);
                };

                options.Events.OnRedirectToIdentityProviderForSignOut = context =>
                {
                    context.ProtocolMessage.IssuerAddress = $"{configuration.GetValue<string>("Auth:Authority")}/";
                    return Task.CompletedTask;
                };

            });
            services.AddAuthorization();

            return services;
        }

    }

}
