using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERICS_METHOD 
{
    class Example
    {
        public static void ShowArray<T>(T[] array)
        {
            for (int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
