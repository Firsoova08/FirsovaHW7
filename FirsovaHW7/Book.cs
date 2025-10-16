using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirsovaHW7
{
    internal class Book
    {
        public string Title;
        public string Author;
        public int Year;
        public bool IsAvailable;

        public Book()
        {
            Title = "Неизвестно";
            Author = "Неизвестен";
            Year = 0;
            IsAvailable = false;
        }
        public Book(string bookTitle, string bookAuthor, int bookYear, bool bookAvailable)
        {
            Title = bookTitle;
            Author = bookAuthor;
            Year = bookYear;
            IsAvailable = bookAvailable;
        }
        public void ShowInfo()
        {
            string available = IsAvailable ? "Да" : "Нет";
            Console.WriteLine($"Книга: \"{Title}\"");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Год: {Year}");
            Console.WriteLine($"Доступна: {available}");
        
        }
    }
}

