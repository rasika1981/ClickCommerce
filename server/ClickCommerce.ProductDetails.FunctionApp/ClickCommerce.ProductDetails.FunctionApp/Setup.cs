using ClickCommerce.ProductDetails.FunctionApp.Repository;
using ClickCommerce.ProductDetails.FunctionApp.Services;
using ClickCommerce.ProductDetails.FunctionApp.Sittings;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

[assembly: FunctionsStartup(typeof(ClickCommerce.ProductDetails.FunctionApp.Setup))]
namespace ClickCommerce.ProductDetails.FunctionApp
{
    public class Setup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddOptions<FunctionSittings>().Configure<IConfiguration>((settings, configuration) =>
            {
                configuration.Bind(settings);
                configuration.GetSection("ConnectionStrings").Bind(settings);
            });

            builder.Services.AddScoped<IProductDetailsService, ProductDetailsService>();
            builder.Services.AddScoped<IProductDetailsRepository, ProductDetailsRepository>();
        }
    }
}
