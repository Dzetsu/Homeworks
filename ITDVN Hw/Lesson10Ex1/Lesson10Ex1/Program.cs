using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 123;
            var result = Myclass<int>.FactoryMethod(num);
            Console.WriteLine(result.GetType());
        }
    }


    class Myclass<T>
    {
        public static T FactoryMethod(T exp) 
        {
            return exp;
        }
    }
}
