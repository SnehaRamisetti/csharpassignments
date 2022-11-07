using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ARRAYDEMO
    {
        public static void Main()
        {
            int i;
            int[] array = new int[10];
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine(" enter the value");
                array[i] = Convert.ToInt32(Console.ReadLine());
            } 
        }
    }
}
