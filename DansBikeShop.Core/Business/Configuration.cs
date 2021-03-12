using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DansBikeShop.Core.Business
{
    public static class Configuration
    {
        public static IServiceCollection ConfigureDataAccess(IServiceCollection services)
        {
            // TODO: Register business layer objects for dependency injection
            return services;
        }
    }
}
