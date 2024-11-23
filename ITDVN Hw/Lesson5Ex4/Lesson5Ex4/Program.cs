using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Console.WriteLine(store["Хлеб"]);
            store.findProduct(1);
        }
    }


    class Article
    {
        public string NameOfProduct { get; private set; }
        public string NameOfShop { get; private set; }
        public int Price { get; private set; }

        public Article(string nameP, string nameS, int price)
        {
            NameOfProduct = nameP;
            NameOfShop = nameS;
            Price = price;
        }
    }

    class Store
    {
        public Article[] products = new Article[5];
        
        public Store()
        {
            products[0] = new Article("Хлеб", "Натали", 42);
            products[1] = new Article("Вода", "АТБ", 129);
            products[2] = new Article("Ручка", "Глобус", 10);
            products[3] = new Article("Сникерс", "Наша Раша", 69);
            products[4] = new Article("Lion", "Гастроном", 54);
        }

        public void findProduct(int index)
        {
            if (index < 0 || index >= products.Length)
                Console.WriteLine("Неверный индекс товара!");
            else
                Console.WriteLine($"Ваш товар {products[index].NameOfProduct}");
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < products.Length; i++)
                    if (products[i].NameOfProduct == index)
                        return string.Format(products[i].NameOfProduct + $" продается в магазине {products[i].NameOfShop} за {products[i].Price} рубля");
                return string.Format($"{index}, такого товара нет в продаже.");
            }
        }

    }
}
