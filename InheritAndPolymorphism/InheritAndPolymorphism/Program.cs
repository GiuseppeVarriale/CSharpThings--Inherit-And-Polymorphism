using System;
using System.Collections.Generic;
using System.Globalization;
using InheritAndPolymorphism.Entities;

namespace InheritAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product # data: ");
                Console.Write("Common, used or imported(c / u / i) ? ");
                string type = Console.ReadLine();
                Console.Write($"Name: ");
                string name = Console.ReadLine();
                Console.Write($"Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                switch (type)
                {
                    case "c":
                        products.Add(new Product(name, price));
                        break;
                    case "u":
                        Console.Write("Manufactured date (DD/MM/YYYY) ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, manufactureDate));
                        break;

                    case "i":
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(name, price, customsFee));
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag()) ;
            }
        }
    }
}
/*
 * Enter the number of products: 3
Product #1 data:
Common, used or imported (c/u/i)? i
Name: Tablet
Price: 260.00
Customs fee: 20.00
Product #2 data:
Common, used or imported (c/u/i)? c
Name: Notebook
Price: 1100.00
Product #3 data:
Common, used or imported (c/u/i)? u
Name: Iphone
Price: 400.00
Manufacture date (DD/MM/YYYY): 15/03/2017
PRICE TAGS:
Tablet $ 280.00 (Customs fee: $ 20.00)
Notebook $ 1100.00
Iphone (used) $ 400.00 (Manufacture date: 15/03/2017)
*/
