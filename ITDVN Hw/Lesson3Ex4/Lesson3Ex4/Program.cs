using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker worker = new DocumentWorker();
            Console.Write("Введите ключ: ");
            string password = Console.ReadLine();
            switch (password)
            {
                case "42":
                    worker = new ProDocumentWorker();
                    break;
                case "52":
                    worker = new ExpertDocumentWorker();
                    break;
                default:
                    break;
            }
            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
        }
    }

    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт.");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате," +
                " сохранение в остальных форматах доступно в версии Эксперт");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    { 
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
