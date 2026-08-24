List<Product> products = new List<Product>();
List<Transaction> transactions = new List<Transaction>();

while (true)
{
    Console.Clear();

    Console.WriteLine("================================");
    Console.WriteLine("     MINI INVENTORY SYSTEM");
    Console.WriteLine("================================");
    Console.WriteLine("1. Add Product");
    Console.WriteLine("2. View Products");
    Console.WriteLine("3. Search Products");
    Console.WriteLine("4. Update Product");
    Console.WriteLine("5. Delete Product");
    Console.WriteLine("6. Purchase");
    Console.WriteLine("7. Sale");
    Console.WriteLine("8. Stock Report");
    Console.WriteLine("9. Transaction History");
    Console.WriteLine("0. Exit");
    Console.WriteLine("================================");

    Console.Write("Enter your choice: ");
    string? choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Clear();

        Console.WriteLine("===== ADD PRODUCT =====");

        Console.Write("Product ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Product Name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Price: ");
        decimal price = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Product product = new Product();

        product.Id = id;
        product.Name = name;
        product.Price = price;
        product.Quantity = quantity;

        products.Add(product);

        Console.WriteLine("\nProduct added successfully!");
    }
    else if (choice == "2")
    {
        Console.Clear();

        Console.WriteLine("===== PRODUCT LIST =====");

        if (products.Count == 0)
        {
            Console.WriteLine("No products found.");
        }
        else
        {
            foreach (Product product in products)
            {
                Console.WriteLine(
                    $"ID: {product.Id} | " +
                    $"Name: {product.Name} | " +
                    $"Price: {product.Price} | " +
                    $"Quantity: {product.Quantity}"
                );
            }

        }

        
    }
    else if (choice == "3")
    {
        Console.Clear();

        Console.WriteLine("===== SEARCH PRODUCT =====");

        Console.Write("Enter Product ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Product? product = products.FirstOrDefault(p => p.Id == id);

        if (product != null)
        {
            Console.WriteLine($"ID       : {product.Id}");
            Console.WriteLine($"Name     : {product.Name}");
            Console.WriteLine($"Price    : {product.Price}");
            Console.WriteLine($"Quantity : {product.Quantity}");
        }
        else
        {
            Console.WriteLine("Product not found!");
        }
    }
    else if (choice == "4")
    {
        Console.Clear();

        Console.WriteLine("===== UPDATE PRODUCT =====");

        Console.Write("Enter Product ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Product? product = products.FirstOrDefault(p => p.Id == id);

        if (product != null)
        {
            Console.Write("New Name: ");
            product.Name = Console.ReadLine() ?? "";

            Console.Write("New Price: ");
            product.Price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("New Quantity: ");
            product.Quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nProduct updated successfully!");
        }
        else
        {
            Console.WriteLine("Product not found!");
        }
    }

    else if (choice == "5")
    {
        Console.Clear();

        Console.WriteLine("===== DELETE PRODUCT =====");

        Console.Write("Enter Product ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Product? product = products.FirstOrDefault(p => p.Id == id);

        if (product != null)
        {
            products.Remove(product);

            Console.WriteLine("\nProduct deleted successfully!");
        }
        else
        {
            Console.WriteLine("Product not found!");
        }
    }

    else if (choice == "6")
    {
        Console.Clear();

        Console.WriteLine("===== PURCHASE =====");

        Console.Write("Enter Product ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Product? product = products.FirstOrDefault(p => p.Id == id);

        if (product != null)
        {
            Console.Write("Purchase Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            if (quantity > 0)
            {
                product.Quantity += quantity;

                Transaction transaction = new Transaction
                {
                    ProductId = product.Id,
                    ProductName = product.Name,
                    Type = "PURCHASE",
                    Quantity = quantity,
                    Date = DateTime.Now
                };

                transactions.Add(transaction);

                Console.WriteLine("\nPurchase completed successfully!");
                Console.WriteLine($"Current Stock: {product.Quantity}");
            }
            else
            {
                Console.WriteLine("Quantity must be greater than 0.");
            }
        }
        else
        {
            Console.WriteLine("Product not found!");
        }
    }

    else if (choice == "7")
    {
        Console.Clear();

        Console.WriteLine("===== SALE =====");

        Console.Write("Enter Product ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Product? product = products.FirstOrDefault(p => p.Id == id);

        if (product != null)
        {
            Console.Write("Sale Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            if (quantity <= 0)
            {
                Console.WriteLine("Quantity must be greater than 0.");
            }
            else if (quantity > product.Quantity)
            {
                Console.WriteLine("Insufficient stock!");
            }
            else
            {
                product.Quantity -= quantity;

                Transaction transaction = new Transaction
                {
                    ProductId = product.Id,
                    ProductName = product.Name,
                    Type = "SALE",
                    Quantity = quantity,
                    Date = DateTime.Now
                };
                transactions.Add(transaction);

                Console.WriteLine("\nSale completed successfully!");
                Console.WriteLine($"Remaining Stock: {product.Quantity}");
            }
        }
        else
        {
            Console.WriteLine("Product not found!");
        }
    }
    else if (choice == "8")
    {
        Console.Clear();

        Console.WriteLine("==============================================");
        Console.WriteLine("              STOCK REPORT");
        Console.WriteLine("==============================================");

        Console.WriteLine(
            $"{"ID",-8}" +
            $"{"Product",-20}" +
            $"{"Price",-12}" +
            $"{"Stock",-10}"
        );

        Console.WriteLine("----------------------------------------------");

        foreach (Product product in products)
        {
            Console.WriteLine(
                $"{product.Id,-8}" +
                $"{product.Name,-20}" +
                $"{product.Price,-12}" +
                $"{product.Quantity,-10}"
            );
        }

        Console.WriteLine("----------------------------------------------");

        int totalStock = products.Sum(p => p.Quantity);

        decimal totalStockValue =
            products.Sum(p => p.Price * p.Quantity);

        Console.WriteLine($"Total Products : {products.Count}");
        Console.WriteLine($"Total Stock    : {totalStock}");
        Console.WriteLine($"Stock Value    : {totalStockValue}");
    }

    else if (choice == "9")
    {
        Console.Clear();

        Console.WriteLine("===== TRANSACTION HISTORY =====");

        if (transactions.Count == 0)
        {
            Console.WriteLine("No transactions found.");
        }
        else
        {
            foreach (Transaction transaction in transactions)
            {
                Console.WriteLine(
                    $"Product ID: {transaction.ProductId} | " +
                    $"Product: {transaction.ProductName} | " +
                    $"Type: {transaction.Type} | " +
                    $"Quantity: {transaction.Quantity} | " +
                    $"Date: {transaction.Date}"
                );
            }
        }
    }

    else if (choice == "0")
    {
        Console.WriteLine("Goodbye!");
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice!");
    }

    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}