using System;
using System.Collections.Generic;

class Product
{
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public int ProductQuantity { get; set; }

    public Product(string name, decimal price, int quantity)
    {
        ProductName = name;
        ProductPrice = price;
        ProductQuantity = quantity;
    }
}

class Program
{
    static List<Product> inventory = new List<Product>();

    static void AddProduct()
    {
        Console.WriteLine("Enter product name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter product price:");
        decimal price = decimal.Parse(Console.ReadLine());

        int quantity;
        while (true)
        {
            Console.WriteLine("Enter product quantity:");
            string quantityInput = Console.ReadLine();
            if (!int.TryParse(quantityInput, out quantity) || quantity < 0)
            {
                Console.WriteLine("Invalid quantity. Please enter a non-negative whole number.");
                continue;
            }
            break;
        }

        Product newProduct = new Product(name, price, quantity);
        inventory.Add(newProduct);

        Console.WriteLine("Product added successfully!");
    }

    static void UpdateStock()
    {
        Console.WriteLine("Enter product name to update stock:");
        string name = Console.ReadLine();
        Product product = inventory.Find(p => p.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (product != null)
        {
            int newQuantity;
            while (true)
            {
                Console.WriteLine("Enter new quantity:");
                string quantityInput = Console.ReadLine();
                if (!int.TryParse(quantityInput, out newQuantity) || newQuantity < 0)
                {
                    Console.WriteLine("Invalid quantity. Please enter a non-negative whole number.");
                    continue;
                }
                break;
            }

            product.ProductQuantity = newQuantity;
            Console.WriteLine("Stock updated successfully!");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    static void ViewInventory()
    {
        Console.WriteLine("Current Inventory:");
        if (inventory.Count == 0)
        {
            Console.WriteLine("No products to view");
        }
        else
        {
            foreach (var product in inventory)
            {
                Console.WriteLine($"Name: {product.ProductName}, Price: {product.ProductPrice:C}, Quantity: {product.ProductQuantity}");
            }
        }
    }

    static void RemoveProduct()
    {
        Console.WriteLine("Enter product name to remove:");
        string name = Console.ReadLine();
        Product product = inventory.Find(p => p.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (product != null)
        {
            inventory.Remove(product);
            Console.WriteLine("Product removed successfully!");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Inventory Management System!");
        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Update Stock");
            Console.WriteLine("3. View Inventory");
            Console.WriteLine("4. Remove Product");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Choose an option:");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    UpdateStock();
                    break;
                case "3":
                    ViewInventory();
                    break;
                case "4":
                    RemoveProduct();
                    break;
                case "5":
                    Console.WriteLine("Exiting the system. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
