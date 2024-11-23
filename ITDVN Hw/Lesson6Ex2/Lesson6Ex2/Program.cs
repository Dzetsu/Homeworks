using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Super", "Asus", 12999.99);
            notebook.Show();
        }
    }
    public struct Notebook
    {
        public string model;
        public string manufacture;
        public double price;

        public Notebook(string model, string manufacture, double price)
        {
            this.model = model;
            this.manufacture = manufacture;
            this.price = price;
        }

        public void Show()
        {
            Console.WriteLine($"Модель: {model}\n" +
                $"Производитель: {manufacture}\n" +
                $"Цена: {price}");
        }
    }
}
