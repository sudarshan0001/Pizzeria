using Pizzeria.Services.Implementations;
using Pizzeria.Services.Interfaces;
using Pizzeria.WebUI.Helpers;
using Pizzeria.WebUI.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.WebUI.Configuration
{
    public class ConfigureDependencies
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            services.AddTransient<IUserAccessor, UserAccessor>();
            services.AddTransient<ICatalogService, CatalogService>();
            services.AddTransient<ICartService, CartService>();
            services.AddTransient<IFileHelper, FileHelper>();
        }
    }
}
