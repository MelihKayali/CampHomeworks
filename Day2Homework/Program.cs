using System;

namespace Day2Homework // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.id = 1;
            product.name = "Klavye";
            product.price = 130;
            product.description = "Işıklı blue switch mekanik klavye";

            Product product2 = new Product();
            product2.id = 2;
            product2.name = "Mouse";
            product2.price = 300;
            product2.description = "Işıklı ekonomik mouse";


            Product product3 = new Product();
            product3.id = 3;
            product3.name = "Kulaklık";
            product3.price = 310;
            product3.description = "Işıklı ekonomik kulaklık";

            Product[] products = new Product[] { product, product2, product3 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].name + " : " + products[i].price + " TL");
            }

            foreach (Product tempProduct in products)
            {
                Console.WriteLine(tempProduct.name + " in açıklaması :  " + tempProduct.description);
            }

            int z = 0;
            while (z <= products.Length)
            {
                Console.WriteLine(products[z].name);
                z++;
                break;
            }

        }

    }

    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string description { get; set; }
    }
}