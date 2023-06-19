using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10FundamentalsExercises
{
    internal class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string ISBN { get; }

        public bool IsAvailable { get; private set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsAvailable = true; //Assuming the book is initially available
        }

        public void BorrowBook()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"The book '{Title}' by {Author} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"The book '{Title}' by {Author} is currently not available.");
            }
        }
    }
}
