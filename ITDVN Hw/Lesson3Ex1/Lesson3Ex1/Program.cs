using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "Здравствуйте, бабушка!";
            NewPrinter printer = new NewPrinter();
            printer.Print(value);
        }
    }

    class Printer
    {
        public void Print(string value)
        {
            Console.WriteLine(value);
        }
    }

    class NewPrinter : Printer
    {
        public void Print(string value) 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
