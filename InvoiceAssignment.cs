﻿using System;
using System.Collections.Generic;

namespace InvoiceAssignment
{
    class InvoiceAssignment
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Welcome to Invoice Console App ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("(Team Debug)");

            // **************** CREATING PRODUCT CLASS ARRAY ***************

            Product[] products = new Product[6];
            products[0] = new Product("Iphone", 5000);
            products[1] = new Product("Samsung", 4000);
            products[2] = new Product("Oneplus", 4000);
            products[3] = new Product("Xiaomi", 3000);
            products[4] = new Product("Oppo", 3000);
            products[5] = new Product("Nokia", 4000);

            Console.ResetColor();

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Product Name: {products[i].productName} {new string(' ', 10)} Product Price: ${products[i].productPrice}");
            }

            List<SelectedProducts> selectedProducts = new List<SelectedProducts>();

            while (true)
            {
                Console.Write("Write the name of the product you want to buy (done to skip): ");
                string select = Console.ReadLine();
                if (select?.ToLower().Equals("done") == true)
                {
                    break;
                }
                int flag = 0;
                for (int i = 0; i < products.Length; i++)
                {
                    if (select?.ToLower().Equals(products[i].productName.ToLower()) == true)
                    {
                        Console.Write("Enter the quantity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        flag = 1;
                        selectedProducts.Add(new SelectedProducts(products[i].productName, products[i].productPrice, quantity));
                    }
                }

                if (flag == 1)
                {
                    Console.Write("Do you want to add more? (yes/no): ");
                    string decision = Console.ReadLine();
                    if (decision?.Equals("yes") == true)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (flag == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your product name is invalid, please correct it!!");
                    Console.ResetColor();
                }
            }

            if (selectedProducts.Count >= 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The Selected products are: ");
                Console.ResetColor();

                for (int i = 0; i < selectedProducts.Count; i++)
                {
                    Console.WriteLine($"Product Name: {selectedProducts[i].productName} {new string(' ', 6)} Product Price: ${selectedProducts[i].productPrice} {new string(' ', 6)} Product Quantity: {selectedProducts[i].productQuantity}");
                }
            }

            Console.WriteLine();

            // Console.WriteLine();

            Console.WriteLine("Are you sure to buy these products? (yes/no): ");
            string buyEnsure = Console.ReadLine();

            if (buyEnsure?.ToLower().Equals("yes") == true){
                System.Console.Write("Enter your first Name: ");
                string firstName = Console.ReadLine();
                System.Console.Write("Enter your last Name: ");
                string lastName = Console.ReadLine();
                System.Console.Write("Enter your email address: ");
                string email = Console.ReadLine();
                System.Console.Write("Enter your address: ");
                string address = Console.ReadLine();
                System.Console.Write("Enter your date of birth:(d-m-y) ");
                string dob = Console.ReadLine();

                System.Console.WriteLine("---------------- Here is your Invoice ----------------");
                System.Console.WriteLine("*************** User Information: *****************");
                System.Console.WriteLine($"Name: {firstName} {lastName} {new string(' ', 7)} Email: {email}");

                System.Console.WriteLine($"Address: {address} {new string(' ', 7)} Date of Birth: {dob}");

                System.Console.WriteLine("*************** Total amount *****************");
                double totalAmount = 0;
                for (int i = 0; i < selectedProducts.Count; i++)
                {
                    totalAmount = totalAmount + (selectedProducts[i].productPrice * selectedProducts[i].productQuantity);
                    System.Console.WriteLine($"Product Name: {selectedProducts[i].productName} {new string(' ', 5)} Product Price: ${selectedProducts[i].productPrice} {new string(' ', 5)} Product Quantity: {selectedProducts[i].productQuantity} {new string(' ', 5)} Amount: ${selectedProducts[i].productPrice * selectedProducts[i].productQuantity}");
                }

                System.Console.WriteLine("--------------------------------------------------------------------------------------");

                System.Console.WriteLine($"Total Amount: {totalAmount + ((totalAmount * 2) / 100)} (2% vat included)");
                System.Console.WriteLine();

                System.Console.Write("Do you want to receive the invoice via email? (yes/no): ");
                string ensureEmail = Console.ReadLine();
                
                if(ensureEmail.ToLower().Equals("yes") == true){
                    System.Console.WriteLine("Your invoice has been sent to your email.");
                }
                else{
                    System.Console.WriteLine("Thank you' gesture to your users.");
                }
                

                
            }
            else
            {
                Console.WriteLine("Thank you for your response");
            }

                

            
        }
    }

    class Product
    {
        public string productName;
        public double productPrice;

        public Product(string productName, double productPrice)
        {
            this.productName = productName;
            this.productPrice = productPrice;
        }
    }

    class SelectedProducts
    {
        public string productName;
        public double productPrice;
        public int productQuantity;

        public SelectedProducts(string productName, double productPrice, int productQuantity)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
        }
    }
}
