using ClickCommerce.ProductDetails.FunctionApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClickCommerce.ProductDetails.FunctionApp.Services
{
    public class ProductDetailsService : IProductDetailsService
    {
        private readonly IProductDetailsRepository productDetailsRepository;

        public ProductDetailsService(IProductDetailsRepository productDetailsRepository)
        {
            this.productDetailsRepository = productDetailsRepository;
        }
    }
}
