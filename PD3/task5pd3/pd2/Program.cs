using System;
using System.Collections.Generic;
using System.Linq;
using pd2.CL;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Diagnostics;
using System.IO;

namespace pd2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            List<User> user = new List<User>();
            List<Admin> admin = new List<Admin>();
            List<Product> products = new List<Product>();
            


            while (true)
            {
                Console.Clear();
                Console.Write("####################################################################################################################");
                Console.Write(" ||                                               ------------                                                 || #");
                Console.Write(" ||                                             || LOGIN MENU ||                                               || #");
                Console.Write(" ||                                               ------------                                                 || #");
                Console.Write(" ||                                             || 1. SIGN-UP ||                                               || #");
                Console.Write(" ||                                               ------------                                                 || #");
                Console.Write(" ||                                             || 2. SIGN-IN ||                                               || #");
                Console.Write(" ||                                               ------------                                                 || #");
                Console.Write(" ||                                             || 3.  EXIT   ||                                               || #");
                Console.Write(" ||                                               ------------                                                 || #");
                Console.Write("####################################################################################################################");
                Console.Write("Enter a option: ");
                int option = int.Parse(Console.ReadLine());
                LoadData(user, admin);

                if (option == 1)
                {
                    SignUp(user, admin);
                }
                else if (option == 2)
                {
                    SignIn(user, admin, products);
                }
                else if (option == 3)
                {
                    Environment.Exit(0);
                }
                Console.ReadKey();

                SaveData(user, admin);
            }
        }
        static void SignUp(List<User> user, List<Admin> admin)
        {
            Console.Clear();
            Console.WriteLine("-------------- SIGN UP --------------");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();


            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            Console.Write("Enter id: ");
            string id = Console.ReadLine();

            Console.Write("Are you a admin or user? (a/u): ");
            char userType = char.Parse(Console.ReadLine());

            if (userType == 'a')
            {
                Admin newAdmin = new Admin(name, id, password);
                admin.Add(newAdmin);
                Console.WriteLine("\nAdmin signed up successfully!");
            }
            else if (userType == 'u')
            {
                User newUser = new User(name, id, password);
                user.Add(newUser);
                Console.WriteLine("\nUser signed up successfully!");
            }
            else
            {
                Console.WriteLine("\nInvalid user type. Please enter 'a' for Admin or 'u' for User.");
            }

            SaveData(user, admin);
        }

        static void SignIn(List<User> user, List<Admin> admin, List<Product> products)
        {
            Console.Clear();
            Console.WriteLine("-------------- SIGN IN --------------");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            Console.Write("Enter id: ");
            string id = Console.ReadLine();

            Admin matchedAdmin = admin.Find(t => t.name == name && t.password == password && t.id == id);
            User matchedUser = user.Find(u => u.name == name && u.password == password && u.id == id);

            if (matchedAdmin != null)
            {
                Console.WriteLine($"Welcome, {matchedAdmin.name} (Admin)!");
                adminOption(products);
            }
            else if (matchedUser != null)
            {
                Console.WriteLine($"Welcome, {matchedUser.name} (User)!");
                UserMenu(products);
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
            }
            SaveData(user, admin);
        }
        static void SaveData(List<User> users, List<Admin> admins)
        {
            // Save user data to file
            using (StreamWriter writer = new StreamWriter("userData.txt"))
            {
                foreach (User user in users)
                {
                    writer.WriteLine($"{user.name},{user.id},{user.password}");
                }
            }

            // Save admin data to file
            using (StreamWriter writer = new StreamWriter("adminData.txt"))
            {
                foreach (Admin admin in admins)
                {
                    writer.WriteLine($"{admin.name},{admin.id},{admin.password}");
                }
            }
        }

        static void LoadData(List<User> users, List<Admin> admins)
        {
            // Load user data from file
            if (File.Exists("userData.txt"))
            {
                string[] lines = File.ReadAllLines("userData.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        User user = new User(parts[0], parts[1], parts[2]);
                        users.Add(user);
                    }
                }
            }

            // Load admin data from file
            if (File.Exists("adminData.txt"))
            {
                string[] lines = File.ReadAllLines("adminData.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        Admin admin = new Admin(parts[0], parts[1], parts[2]);
                        admins.Add(admin);
                    }
                }
            }
        }
        static void UserMenu(List<Product> products)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("User Menu");
                Console.WriteLine("1. View Products");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            ViewProducts(products);
                            break;
                        case 2:
                            return; // Exit the user menu
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void adminOption(List<Product> products)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Product CRUD Operations");
                    Console.WriteLine("1. Create Product");
                    Console.WriteLine("2. View Products");
                    Console.WriteLine("3. Update Product");
                    Console.WriteLine("4. Delete Product");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");

                    if (int.TryParse(Console.ReadLine(), out int choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                CreateProduct(products);
                                break;
                            case 2:
                                ViewProducts(products);
                                break;
                            case 3:
                                UpdateProduct(products);
                                break;
                            case 4:
                                DeleteProduct(products);
                                break;
                            case 5:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }

            static void CreateProduct(List<Product> products)
            {
                Console.Clear();
                Console.WriteLine("Create Product");
                Console.Write("Enter product name: ");
                string name = Console.ReadLine();
                Console.Write("Enter product price: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal price))
                {
                    Product newProduct = new Product { Name = name, Price = price };
                    products.Add(newProduct);
                    Console.WriteLine("Product created successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid price. Please enter a valid number.");
                }
            }

            static void ViewProducts(List<Product> products)
            {
                Console.Clear();
                Console.WriteLine("View Products");
                if (products.Count > 0)
                {
                    foreach (var product in products)
                    {
                        Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price:C}");
                    }
                }
                else
                {
                    Console.WriteLine("No products available.");
                }
            }


            static void UpdateProduct(List<Product> products)
            {
                Console.Clear();
                Console.WriteLine("Update Product");
                ViewProducts(products);
                Console.Write("Enter the ID of the product to update: ");
                if (int.TryParse(Console.ReadLine(), out int productId))
                {
                    Product existingProduct = products.Find(p => p.Id == productId);
                    if (existingProduct != null)
                    {
                        Console.Write("Enter new product name: ");
                        existingProduct.Name = Console.ReadLine();
                        Console.Write("Enter new product price: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal newPrice))
                        {
                            existingProduct.Price = newPrice;
                            Console.WriteLine("Product updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid price. Update failed.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Product with ID {productId} not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            static void DeleteProduct(List<Product> products)
            {
                Console.Clear();
                Console.WriteLine("Delete Product");
                ViewProducts(products);
                Console.Write("Enter the ID of the product to delete: ");
                if (int.TryParse(Console.ReadLine(), out int productId))
                {
                    Product existingProduct = products.Find(p => p.Id == productId);
                    if (existingProduct != null)
                    {
                        products.Remove(existingProduct);
                        Console.WriteLine("Product deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"Product with ID {productId} not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

        }

    }





