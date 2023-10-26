using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Project.DataAccessLAyer.Concrete;
using Project.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Container.IdentityExtensions
{
    public static class IdentityExtended
    {
        public static IServiceCollection IdentityExtender(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<Context>()
                .AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider).
                AddEntityFrameworkStores<Context>();
            // Error Describer Will Be Added Later

            services.AddIdentityCore<AppUser>
                (options => options.SignIn.RequireConfirmedEmail = true).
                AddEntityFrameworkStores<Context>();
            // Login Requirements

            return services;
        }
    }
}
