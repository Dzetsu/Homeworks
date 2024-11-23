using System;

namespace NewCurs1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Великий Гэтсби");
            book.Content = "История о Гэтсби";
            book.Author = "Френксис Скотт";
            book.Show();
        }
    }

    class Book
    {
        Title title = null;
        Author author = null;
        Content content = null;

        void InitilizationBook()
        {
            this.title = new Title();
            this.author = new Author();
            this.content = new Content();
        }

        public Book(string title)
        {
            InitilizationBook();
            this.title.title = title;
        }

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
        }

        public string Author
        {
            set
            {
                this.author.author = value;
            }
        }

        public string Content
        {
            set
            {
                this.content.content = value;
            }
        }
    }

    class Title
    {
        public string title { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    class Author
    {
        public string author { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(author);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    class Content
    {
        public string content { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
