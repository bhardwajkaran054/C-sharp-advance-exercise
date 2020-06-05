
using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
            //for finding square
            Func<int, int> square = s => s * s;
            Console.WriteLine(square(5));

        }
    }
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Title 1", Price = 5},
                new Book() {Title = "Title 2", Price = 7},
                new Book() {Title = "Title 3", Price = 17}
            };
        }
    }
    public class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
    }
}
