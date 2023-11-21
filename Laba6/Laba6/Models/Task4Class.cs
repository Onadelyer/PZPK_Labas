using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Models
{
    class PrintedPublication
    {
        protected string title;
        protected string author;
        protected int year;

        public PrintedPublication()
        {
            title = "Невідомий заголовок";
            author = "Невідомий автор";
            year = 2000;
        }

        public PrintedPublication(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }

        public PrintedPublication(string title)
        {
            this.title = title;
            author = "Невідомий автор";
            year = 2000;
        }

        ~PrintedPublication()
        {
            Console.WriteLine($"Об'єкт {title} утилізовано.");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Назва: {title}");
            Console.WriteLine($"Автор: {author}");
            Console.WriteLine($"Рік видання: {year}");
        }

        public void Show()
        {
            Console.WriteLine("Інформація про об'єкт:");
            DisplayInfo();
        }
    }

    class Magazine : PrintedPublication
    {
        private string genre;

        public Magazine() : base()
        {
            genre = "Невідомий жанр";
        }

        public Magazine(string title, string author, int year, string genre) : base(title, author, year)
        {
            this.genre = genre;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Жанр: {genre}");
        }
    }

    class Book : PrintedPublication
    {
        private int pageCount;

        public Book() : base()
        {
            pageCount = 0;
        }

        public Book(string title, string author, int year, int pageCount) : base(title, author, year)
        {
            this.pageCount = pageCount;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Кількість сторінок: {pageCount}");
        }
    }

    class Textbook : Book
    {
        private string subject;

        public Textbook() : base()
        {
            subject = "Невідомий предмет";
        }

        public Textbook(string title, string author, int year, int pageCount, string subject) : base(title, author, year, pageCount)
        {
            this.subject = subject;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Предмет: {subject}");
        }
    }
}
