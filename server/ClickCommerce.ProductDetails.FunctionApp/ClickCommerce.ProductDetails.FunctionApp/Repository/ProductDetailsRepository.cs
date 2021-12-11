using ClickCommerce.ProductDetails.FunctionApp.Sittings;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClickCommerce.ProductDetails.FunctionApp.Repository
{
    public class ProductDetailsRepository : IProductDetailsRepository
    {
        private readonly FunctionSittings functionSittings;

        public ProductDetailsRepository(IOptionsSnapshot<FunctionSittings> optionsSnapshot)
        {
            functionSittings = optionsSnapshot.Value;
        }
    }
}
