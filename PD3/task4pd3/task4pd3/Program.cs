using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4pd3.BL;

namespace task4pd3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                List<Book> bookList = new List<Book>();

                int choice;
                do
                {
                    Console.WriteLine("\nMenu Options:");
                    Console.WriteLine("1. Add Book");
                    Console.WriteLine("2. View All Books Information");
                    Console.WriteLine("3. Get Author Details of a Specific Book");
                    Console.WriteLine("4. Sell Copies of a Specific Book");
                    Console.WriteLine("5. Restock a Specific Book");
                    Console.WriteLine("6. See the Count of Books");
                    Console.WriteLine("7. Exit");

                    Console.Write("Enter your choice (1-7): ");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                        Console.Clear();
                        // Add Book
                        Console.Write("Enter book title: ");
                            string title = Console.ReadLine();
                            Console.Write("Enter author: ");
                            string author = Console.ReadLine();
                            Console.Write("Enter publication year: ");
                            int publicationYear = int.Parse(Console.ReadLine());
                            Console.Write("Enter price: ");
                            decimal price = decimal.Parse(Console.ReadLine());
                            Console.Write("Enter quantity in stock: ");
                            int quantityInStock = int.Parse(Console.ReadLine());

                            Book newBook = new Book(title, author, publicationYear, price, quantityInStock);
                            bookList.Add(newBook);
                            Console.WriteLine($"Book '{title}' added successfully.");
                            break;

                        case 2:
                        Console.Clear();
                        // View All Books Information
                        Console.WriteLine("All Books Information:");
                            foreach (var book in bookList)
                            {
                                Console.WriteLine(book.BookDetails());
                            }
                            break;

                        case 3:
                        Console.Clear();
                        // Get Author Details of a Specific Book
                        Console.Write("Enter the title of the book: ");
                            string searchTitle = Console.ReadLine();
                            Book authorBook = bookList.Find(book => book.Title.Equals(searchTitle, StringComparison.OrdinalIgnoreCase));

                            if (authorBook != null)
                            {
                                Console.WriteLine(authorBook.GetAuthor());
                            }
                            else
                            {
                                Console.WriteLine($"Book with title '{searchTitle}' not found.");
                            }
                            break;

                        case 4:
                        Console.Clear();
                        // Sell Copies of a Specific Book
                        Console.Write("Enter the title of the book: ");
                            string sellTitle = Console.ReadLine();
                            Book sellBook = bookList.Find(book => book.Title.Equals(sellTitle, StringComparison.OrdinalIgnoreCase));

                            if (sellBook != null)
                            {
                                Console.Write("Enter the number of copies to sell: ");
                                int sellCopies = int.Parse(Console.ReadLine());
                                sellBook.SellCopies(sellCopies);
                            }
                            else
                            {
                                Console.WriteLine($"Book with title '{sellTitle}' not found.");
                            }
                            break;

                        case 5:
                        Console.Clear();
                        // Restock a Specific Book
                        Console.Write("Enter the title of the book: ");
                            string restockTitle = Console.ReadLine();
                            Book restockBook = bookList.Find(book => book.Title.Equals(restockTitle, StringComparison.OrdinalIgnoreCase));

                            if (restockBook != null)
                            {
                                Console.Write("Enter the number of copies to restock: ");
                                int restockCopies = int.Parse(Console.ReadLine());
                                restockBook.Restock(restockCopies);
                            }
                            else
                            {
                                Console.WriteLine($"Book with title '{restockTitle}' not found.");
                            }
                            break;

                        case 6:
                        Console.Clear();
                        // See the Count of Books
                        Console.WriteLine($"Total Books in the list: {bookList.Count}");
                            break;

                        case 7:
                            // Exit
                            Console.WriteLine("Exiting the program.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                            break;
                    }

                } while (choice != 7);
            }
        }
    }

