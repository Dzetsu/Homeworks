using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }


    abstract class AbstractHandler 
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Chenge();
        public abstract void Save();
    }

    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Файл с типом файла XML открыт");
        }
        public override void Create()
        {
            Console.WriteLine("Файл с типом файла XML создан");
        }
        public override void Chenge()
        {
            Console.WriteLine("Файл с типом файла XML изменен");

        }
        public override void Save()
        {
            Console.WriteLine("Файл с типом файла XML сохранен");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Файл с типом файла TXT открыт");
        }
        public override void Create()
        {
            Console.WriteLine("Файл с типом файла TXT создан");
        }
        public override void Chenge()
        {
            Console.WriteLine("Файл с типом файла TXT изменен");
        }
        public override void Save()
        {
            Console.WriteLine("Файл с типом файла TXT сохранен");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Файл с типом файла DOC открыт");
        }
        public override void Create()
        {
            Console.WriteLine("Файл с типом файла DOC создан");
        }
        public override void Chenge()
        {
            Console.WriteLine("Файл с типом файла DOC изменен");
        }
        public override void Save()
        {
            Console.WriteLine("Файл с типом файла DOC сохранен");
        }
    }
}
