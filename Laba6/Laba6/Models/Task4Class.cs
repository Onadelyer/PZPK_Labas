using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Laba6.Models
{
    class PrintedPublication
    {
        protected string title;
        protected string author;
        protected int year;

        public PrintedPublication()
        {
            title = "PrintedPublication";
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

        public virtual int GetPrice()
        {
            return 30;
        }

        public virtual void Show(Label label)
        {
            label.Content = $"Назва: {title}\n"+
                $"Автор: {author}\n"+
                $"Рік видання: {year}";
        }
    }

    class Magazine : PrintedPublication
    {
        private string genre;

        public Magazine() : base()
        {
            genre = "Невідомий жанр";
            title = "Magazine";
        }

        public Magazine(string title, string author, int year, string genre) : base(title, author, year)
        {
            this.genre = genre;
        }

        public override int GetPrice()
        {
            return 50;
        }

        public override void Show(Label label)
        {
            base.Show(label);
            label.Content += $"\nЖанр: {genre}";
        }
    }

    class Book : PrintedPublication
    {
        private int pageCount;

        public Book() : base()
        {
            pageCount = 0;
            title = "Book";
        }

        public Book(string title, string author, int year, int pageCount) : base(title, author, year)
        {
            this.pageCount = pageCount;
        }

        public override int GetPrice()
        {
            return 20;
        }

        public override void Show(Label label)
        {
            base.Show(label);
            label.Content += $"\nКількість сторінок: {pageCount}";
        }
    }

    class Textbook : Book
    {
        private string subject;

        public Textbook() : base()
        {
            subject = "Невідомий предмет";
            title = "Textbook";
        }

        public Textbook(string title, string author, int year, int pageCount, string subject) : base(title, author, year, pageCount)
        {
            this.subject = subject;
        }

        public override int GetPrice()
        {
            return 70;
        }

        public override void Show(Label label)
        {
            base.Show(label);
            label.Content += $"\nПредмет: {subject}";
        }
    }
}
