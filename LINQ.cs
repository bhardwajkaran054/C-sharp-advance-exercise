using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.Where(b=>b.Price<10);
            foreach(var book in cheapBooks)
              Console.WriteLine(book.Title +" "+ book.Price);
              
            ////////// LINQ Extension Method ///////////////////
            
            var cheapBooks = books.Where(b=>b.Price<10).OrderBy(b=>Title).Select(b=>b.Title);
            //OR
            var cheaperBooks = books
                                  .Where(b=>b.Price<10)
                                  .OrderBy(b=>Title)
                                  .Select(b=>b.Title)
                                  
            /////////// LINQ Query Operation //////////////////////
            var cheaperBooks = from b in books
                             where b.Price < 10
                             orderedby b.Title
                             Select b.Title
             foreach(var book in cheaperBooks)
              Console.WriteLine(book.Title +" "+ book.Price);
        }
	public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "ADO.Net Step by Step", Price = 5 },
                new Book() {Title = "ASP.NET MVC", Price = 9.99f },
                new Book() {Title = "ASP.NET Web API", Price = 12 },
                new Book() {Title = "C# Advanced Topics", Price = 7 },
                new Book() {Title = "C# Advanced Topics", Price = 9 }
            };
        }
    }

    
    }
}
