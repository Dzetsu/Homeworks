using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestDebugAs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an index for an array.
            int index;

            // Perform some action that sets the index.
            index = 40;

            // Test that the index value is valid.
            Debug.Assert(index > -1);
        }
    }
}
