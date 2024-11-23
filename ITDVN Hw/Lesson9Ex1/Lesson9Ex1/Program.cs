using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avearage avearage;
            avearage = (x, y, z) => (x + y + z) / 3;
            //Можно сделать через CR, но смысла нет
            Console.WriteLine(avearage(1, 2, 3));
            ClassSum sum = new ClassSum(2, 3);
            sum.Sum();
        }
    }

    public delegate double Avearage(int x, int y, int z);


}
