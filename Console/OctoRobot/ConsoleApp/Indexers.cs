using System.Linq;

namespace Octo.Robot
{
    public class Months
    {
        private string[] months = new string[] { "Baisakh", "Jestha", "Asadh", "Shrawan", "Bhadra", "Asoj", "Kartik", "Mangsir", "Poush", "Magh", "Falgun", "Chaitra" };

        public string this[int i] {
            get {
                return months[i];
            }
        }
    }

    public class Library
    {
        private Book[] books = new Book[5];

        public Book GetBookByIndex(int index)
        {
            return books[index];
        }

        public Library()
        {
            GenerateDummyData();
        }

        private void GenerateDummyData()
        {
            books[0] = new Book() { Name = "C#", Author = "Author 1" };
            books[1] = new Book() { Name = "SQL", Author = "Author 2" };
            books[2] = new Book() { Name = "HTML", Author = "Author 3" };
            books[4] = new Book() { Name = "ASP.NET", Author = "Author 4" };
            books[4] = new Book() { Name = "JS", Author = "Author 5" };
        }

        public Book this[int i] {
            get {
                return books[i];
            }
        }

        public Book[] this[string s] {
            get {
                return books.Where(p => p.Author.Contains(s)).ToArray();
            }
        }
    }

    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }
}