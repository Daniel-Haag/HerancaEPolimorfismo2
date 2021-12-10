using ExercicioHerancaPolimorfismoDois.Entities;
using System;
using System.Collections.Generic;

namespace ExercicioHerancaPolimorfismoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products:");
            int numberOfProducts = int.Parse(Console.ReadLine());
            List<Product> productList = new List<Product>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.Write("Common, used or imported? (c/u/i)");
                string productType = Console.ReadLine();

                Console.WriteLine($"Product #{i+1} data:");
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Price:");
                double price = double.Parse(Console.ReadLine());

                if(productType == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY):");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    UsedProduct usedProduct = new UsedProduct(name, price, manufactureDate);
                    productList.Add(usedProduct);
                }

                if(productType == "i")
                {
                    Console.Write("Customs fee:");
                    double customsFee = double.Parse(Console.ReadLine());

                    ImportedProduct importedProduct = new ImportedProduct(name, price, customsFee);
                    productList.Add(importedProduct);
                }

                if(productType == "c")
                {
                    Product product = new Product(name, price);
                    productList.Add(product);
                }
            }

            Console.WriteLine("PRICE TAGS:");
            foreach (var item in productList)
            {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}
