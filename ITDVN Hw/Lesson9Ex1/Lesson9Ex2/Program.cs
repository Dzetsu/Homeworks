using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Find choose = new Find();
            Console.Write("Введите действие: ");
            char x = Convert.ToChar(Console.ReadLine());
            double res = choose.Choice(x);
            Console.WriteLine("\nРезультат: " + res);
        }
    }

    public delegate double Add(int x, double y);
    public delegate double Sub(int x, double y);
    public delegate double Mul(int x, double y);
    public delegate double Div(int x, double y);

    class Find
    {
        public double Choice(char x) 
        {
            Add add;
            add = (z, y) => { return z + y; };
            Sub sub;
            sub = (z, y) => z - y;
            Mul mul;
            mul = (z, y) => z * y;
            Div div;
            div = (z, y) => z / y + z % y;
            switch (x)
            {
                case '+':
                    Console.Write("Введите 1 значение: ");
                    int z = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nВведите 2 значение: ");
                    double y = Convert.ToInt32(Console.ReadLine());
                    return add(z, y);
                case '-':
                    Console.Write("Введите 1 значение: ");
                    int e = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nВведите 2 значение: ");
                    double v = Convert.ToInt32(Console.ReadLine());
                    return sub(e, v);
                case '*':
                    Console.Write("Введите 1 значение: ");
                    int p = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nВведите 2 значение: ");
                    double t = Convert.ToInt32(Console.ReadLine());
                    return mul(p, t);
                case '/':
                    Console.Write("Введите 1 значение: ");
                    int r = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nВведите 2 значение: ");
                    double k = Convert.ToInt32(Console.ReadLine());
                    if (k != 0)
                        return div(r, k);
                    else return 0;
                default:
                    Console.WriteLine("Нет такого действия");
                    return 0;
            }
        }
    }
}
