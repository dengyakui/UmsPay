using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace UmsPay
{
    public static class ServiceCollectionExtensions
    {
        public static void AddUmsPay(this IServiceCollection services)
        {
            services.AddUmsPay(null);
        }

        public static void AddUmsPay(this IServiceCollection services, Action<UmsPayOptions> configureOptions)
        {
            services.AddSingleton<UmsPayClient>();

            if (configureOptions != null)
            {
                services.Configure<UmsPayOptions>(configureOptions);
            }
        }

        public static void AddUmsPayHttpClient(this IServiceCollection services)
        {
            services.AddHttpClient(UmsPayOptions.DefaultClientName);
        }
    }
}
