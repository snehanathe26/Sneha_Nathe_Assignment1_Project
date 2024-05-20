using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Stock
    {
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public int id { get; set; }

        public Stock(int id, string name, double price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {id},name: {name},price: {price},quantity: {quantity}");
        }
    }
    public class Product
    {
        List<Stock> products;
        public Product()
        {
            products = new List<Stock>();
        }


        public void AddProduct(Stock product)
        {
            products.Add(product);
            Console.WriteLine("Item added Successfully");
        }


        public void DisplayProduct()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("The Stock is Empty");
            }
            else
            {
                for (int i = 0; i < products.Count; i++)
                {

                    products[i].Display();
                }
            }
        }

        public Stock FindProduct(int id)
        {
            foreach (Stock product in products)
            {
                if (product.id == id)
                {
                    Console.WriteLine("The product is available in stock");
                    return product;
                }
            }
            return null;

        }
        public void UpdateProduct(int id, string name, double price, int quantity)
        {
            Stock product = FindProduct(id);
            if (product != null)
            {
                product.name = name;
                product.id = id;
                product.price = price;
                product.quantity = quantity;
                Console.WriteLine("Updation is Successful");
            }
            else
            {
                Console.WriteLine("Item not found");
            }

        }

        public void DeleteProduct(int id)
        {
            Stock product = FindProduct(id);
            if (products != null)
            {
                products.Remove(product);
                Console.WriteLine("Item deleted Successfully");
            }
            else
            {
                Console.WriteLine("Item Not found");
            }
        }
    }

    public class material
    {
        static void Main(string[] args)
        {
            Product obj = new Product();
            Console.WriteLine("Assignment:Implementation of Inventary Management system");

            while (true)
            {
               
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Display products");
                Console.WriteLine("3. Find product");
                Console.WriteLine("4. Update product");
                Console.WriteLine("5. Delete Product");
                Console.WriteLine("6. let's Exit ");


                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Item id: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter the price: ");
                        double price = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter the Item Quantity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());

                        obj.AddProduct(new Stock(id, name, price, quantity));
                        break;

                    case 2:
                        obj.DisplayProduct();
                        break;

                    case 3:
                        Console.Write("Enter the id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Stock product = obj.FindProduct(id);
                        if (product != null)
                        {
                            product.Display();
                        }
                        else
                        {
                            Console.WriteLine("Item not found");
                        }
                        break;

                    case 4:
                        Console.Write("Enter product ID: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter New product Name: ");
                        name = Console.ReadLine();

                        Console.Write("Enter  new price of the product: ");
                        price = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter  product Quantity: ");
                        quantity = Convert.ToInt32(Console.ReadLine());

                        obj.UpdateProduct(id, name, price, quantity);
                        break;

                    case 5:
                        Console.Write("Enter product id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        obj.DeleteProduct(id);
                        break;

                    case 6:

                        return;

                    default:
                        Console.WriteLine("Invalid option, Please try again.");
                        break;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
                }

            }
        }
    }
}


    




       
    


