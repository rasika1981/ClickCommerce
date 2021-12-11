using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ClickCommerce.ProductDetails.FunctionApp.Services;

namespace ClickCommerce.ProductDetails.FunctionApp
{
    public class ProductDetails
    {
        private readonly IProductDetailsService productDetailsService;

        public ProductDetails(IProductDetailsService productDetailsService)
        {
            this.productDetailsService = productDetailsService;
        }

        [FunctionName("ProductDetails")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req)
        {
            string id = req.Query["id"];

            string responseMessage = "Success";

            return new OkObjectResult(responseMessage);
        }
    }
}
