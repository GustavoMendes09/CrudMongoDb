using MicrosservicesMongo.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosservicesMongo.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            var existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {

            new Product()
            {
                Id = "602d2149e773f2a3990b47f5",
                Name = "Samsung",
                Description = "fdshiuhfdsiuohfdiushif",
                Image = "product-1.png",
                Price = "950.00M",
                Category = "Smart phone"
            },
            new Product()
            {
                Id = "602d2149e773f2a3990b47c6",
                Name = "Iphone",
                Description = "fdshiuhfdsiuohfdiushif",
                Image = "product-2.png",
                Price = "610.00M",
                Category = "Smart phone"
            },
            new Product()
            {
                Id = "602d2149e773f2a3990b47c6",
                Name = "Xiaomi 1",
                Description = "fdshiuhfdsiuohfdiushif",
                Image = "product-3.png",
                Price = "230.00M",
                Category = "Smart phone"
            },
            };
        }

    }
}
