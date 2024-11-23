using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterGRN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter convert = new Converter(41, 45, 0.47);
        }
    }


    class Converter
    {
        public double usd { get; }
        public double eur { get; }
        public double rub { get; }

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double ConvertFromGrn(double grn, string curr)
        {
            if (curr == "usd")
            {
                double result = grn / usd;
                PrintCurr(result, "usd");
                return result;
            }
            if (curr == "eur")
            {
                double result = grn / eur;
                PrintCurr(result, "eur");
                return result;
            }
            if (curr == "rub")
            {
                double result = grn / rub;
                PrintCurr(result, "rub");
                return result;
            }
            else
            {
                Console.WriteLine("Вы ввели неверное название валюты!");
                return grn;
            }
        }

        public double ConvertToGrn(double valueCurr, string curr)
        {
            if (curr == "usd")
            {
                double result = valueCurr * usd;
                PrintCurr(result, "grn");
                return result;
            }
            if (curr == "eur")
            {
                double result = valueCurr * eur;
                PrintCurr(result, "grn");
                return result;
            }
            if (curr == "rub")
            {
                double result = valueCurr * rub;
                PrintCurr(result, "grn");
                return result;
            }
            else
            {
                Console.WriteLine("Вы ввели неверное название валюты!");
                return valueCurr;
            }
        }

        private void PrintCurr(double result, string currConvert)
        {
            Console.WriteLine("У вас {0} в {1}", result, currConvert);
        }
    }
}
