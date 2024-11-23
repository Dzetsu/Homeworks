using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();

            list.Add("string");
            list.Add("123");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Задание 4
            string[] array = GetArrayExtension.GetArray(list);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

    class MyList<T> : IList<T>, IEnumerable
    {
        //Поля для хранения и добавления значений.
        private T[] items = new T[1];
        private int size;

        //Свойства нашего листа
        public int Lenght { get { return items.Length; } }

        public T Items { get; }

        //Индексатор (для обращения к значению из листа через индекс)
        public T this[int index]
        {
            get 
            { 
                if (index <= items.Length - 1)
                    return items[index];
                return items[0];
            }
        }
        //Метод добавления значений в лист
        public void Add(T item)
        {
            if (size < items.Length)
            {
                AddItem(item);
            }
            else
            {
                Array.Resize(ref items, items.Length + 1);
                AddItem(item);
            }
        }
        //Метод для добавления значения
        private void AddItem(T item)
        {
            int tempSize = size;
            size = tempSize + 1;
            items[tempSize] = item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
    //Интерфейс (не знаю зачем его добавил...)
    public interface IList<T>
    {
        void Add(T item);
        T this[int index] { get; }
        T Items { get; }
    }

    //Задание 4
    class GetArrayExtension
    {
        public static T[] GetArray<T>(MyList<T> list)
        {
            T[] array = new T[list.Lenght];
            for (int i = 0; i < list.Lenght; i++)
            {
                array[i] = list[i];
            }
            return array;
        }
    }
}
