using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Num[] array = new Num[5];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => { return rand.Next(1000); };
            }
            Avearage avearage;
            avearage = (x) =>
            {
                int result = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    result += x[i].Invoke();
                }
                return result / x.Length;
            };
            Console.WriteLine(avearage(array));
        }
    }

    public delegate int Num();
    public delegate int Avearage(Num[] x);
}
