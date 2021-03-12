using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DansBikeShop.Core.Data
{
    public static class Configuration
    {
        public static IServiceCollection ConfigureDataAccess(IServiceCollection services)
        {
            // TODO: Register data acess objects for dependency injection
            return services;
        }
    }
}
