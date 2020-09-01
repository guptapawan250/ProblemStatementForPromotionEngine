using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatementForPromotionEngine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.WriteLine("total number of order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                Product p = new Product(type);
                products.Add(p);
            }

            int totalPrice = GetTotalPrice(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

        private static int GetTotalPrice(List<Product> products)
        {
            int counterOfA = 0;
            int priceOfA = 50;
            int counterOfB = 0;
            int priceOfB = 30;
            int CounterOfC = 0;
            int priceOfC = 20;
            int CounterOfD = 0;
            int priceOfD = 15;
            foreach (Product pr in products)
            {
                if (pr.Id == "A" || pr.Id == "a")
                {
                    counterOfA = counterOfA + 1;
                }
                if (pr.Id == "B" || pr.Id == "b")
                {
                    counterOfB = counterOfB + 1;
                }
                if (pr.Id == "C" || pr.Id == "c")
                {
                    CounterOfC = CounterOfC + 1;
                }
                if (pr.Id == "D" || pr.Id == "d")
                {
                    CounterOfD = CounterOfD + 1;
                }
            }
            int totalPriceofA = (counterOfA / 3) * 130 + (counterOfA % 3 * priceOfA);
            int totalPriceofB = (counterOfB / 2) * 45 + (counterOfB % 2 * priceOfB);
            int totalPriceofC = (CounterOfC * priceOfC);
            int totalPriceofD = (CounterOfD * priceOfD);
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;

        }
    }
    public class Product
    {

        public string Id { get; set; }
        public decimal Price { get; set; }


        public Product(string id)
        {
            this.Id = id;
            switch (id)
            {
                case "A":
                    this.Price = 50m;

                    break;
                case "B":
                    this.Price = 30m;

                    break;
                case "C":
                    this.Price = 20m;

                    break;
                case "D":
                    this.Price = 2015m;
                    break;
            }
        }

    }
}
