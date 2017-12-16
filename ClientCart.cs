using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ClientCart
    {
        public List<string> Products { get; set; }
        public List<string> TypesProducts { get; set; }

        public int NumberProducts { get; set; }
        public int NumberDrinks { get; set; }
        public int NumberCandys { get; set; }
        public double PriceAllProducts { get; set; }

        public void SaveTypeProducts(string typeproduct)
        {
            if (TypesProducts.Contains(typeproduct))
            {
                Console.WriteLine("This type of product is already in the cart!");
            }
            else
            {
                TypesProducts.Add(typeproduct);
            }

            CheckTypeProducts(typeproduct);
        }

        private void CheckTypeProducts(string typeproduct)
        {
            if (typeproduct == "candys")
            {
                GetCandysCount();
            }
            else if (typeproduct == "drink")
            {
                GetDrinksCount();
            }
        }

        private void GetCandysCount()
        {
            NumberCandys += 1;
        }

        private void GetDrinksCount()
        {
            NumberDrinks += 1;
        }

        public double SumProductsPrice(double priceproduct)
        {
            return PriceAllProducts += priceproduct;
        }

        public int GetProductsCount()
        {
            return NumberProducts = Products.Count;
        }

        public void AddProduct(string product)
        {
            Products.Add(product);
        }
    }
}
