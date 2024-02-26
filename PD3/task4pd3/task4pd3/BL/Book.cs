using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4pd3.BL
{
    internal class Book
    {
        public string Title ;
        public string Author ;
        public int PublicationYear ;
        public decimal Price ;
        public int QuantityInStock;

        public Book(string title, string author, int publicationYear, decimal price, int quantityInStock)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        public string GetTitle()
        {
            return $"Title: {Title}";
        }

        public string GetAuthor()
        {
            return $"Author: {Author}";
        }

        public string GetPublicationYear()
        {
            return $"Publication Year: {PublicationYear}";
        }

        public string GetPrice()
        {
            return $"Price: {Price:C}";
        }

        public void SellCopies(int numberOfCopies)
        {
            if (numberOfCopies <= QuantityInStock)
            {
                QuantityInStock -= numberOfCopies;
                Console.WriteLine($"{numberOfCopies} copies of '{Title}' sold successfully.");
            }
            else
            {
                Console.WriteLine($"Error: Not enough copies of '{Title}' in stock.");
            }
        }

        public void Restock(int additionalCopies)
        {
            QuantityInStock += additionalCopies;
            Console.WriteLine($"{additionalCopies} copies of '{Title}' restocked successfully.");
        }

        public string BookDetails()
        {
            return $"{GetTitle()}, {GetAuthor()}, {GetPublicationYear()}, {GetPrice()}, Quantity in Stock: {QuantityInStock}";
        }
    }
}
