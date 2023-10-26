using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.DataAccessLAyer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Container.ContextExtensions
{
    public static class ContextExtended
    {
        public static IServiceCollection ContextExtender(this IServiceCollection services)
        {
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            IConfiguration configuration = serviceProvider.GetService<IConfiguration>();
            services.
                AddDbContextPool<Context>(options =>
                options.UseSqlServer
                (configuration.GetConnectionString("Connections"))
                .UseLazyLoadingProxies());

            return services;
        }
    }
}
