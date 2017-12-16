using System;
using System.Collections.Generic;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            double MyWallet = 30;
            Client client = new Client("Slawomir", "Kowalski", "81-198", MyWallet);

            ClientCart clientCart = new ClientCart();

            clientCart.Products = new List<string>();
            clientCart.TypesProducts = new List<string>();

            Shop shop = new Shop(100);

            shop.NewClient();
            clientCart.AddProduct("cola");
            clientCart.SaveTypeProducts("drink");
            clientCart.SumProductsPrice(5.6);

            clientCart.AddProduct("sprite");
            clientCart.SaveTypeProducts("drink");
            clientCart.SumProductsPrice(3.5);

            clientCart.AddProduct("candy");
            clientCart.SaveTypeProducts("candys");
            clientCart.SumProductsPrice(1.4);

            Order order = new Order();

            Console.WriteLine(order.GiveOrder() +
               "\nThe number of products in the cart: " + clientCart.GetProductsCount() +
               "\nOrder placed by: " + client.FirstName + " " + client.LastName
               + "\nNumber of drinks in the cart: " + clientCart.NumberDrinks
               + "\nThe number of sweets in the cart: " + clientCart.NumberCandys
               + "\nPrice of all products: " + clientCart.PriceAllProducts);

            Console.WriteLine("It's in my wallet: " + (client.MyWallet - clientCart.PriceAllProducts) + " PLN");

            Console.ReadKey();
        }
    }
}
