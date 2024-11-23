using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9Ex1
{
    internal class ClassSum
    {
        public int A {  get; private set; }
        public int B { get; private set; }

        public ClassSum(int a, int b) 
        {
            A = a;
            B = b;
        }

        public void Sum()
        {
            Console.WriteLine(A + B);
        }
    }
}
