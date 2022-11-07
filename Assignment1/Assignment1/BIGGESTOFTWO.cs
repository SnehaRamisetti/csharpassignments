using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class BIGGESTOFTWO
    {
        public static void Main()
        {
            int i;
            int j;
            Console.WriteLine("enter the 1st number");
            i=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the 2nd number");
            j = Convert.ToInt32(Console.ReadLine());
            if(i>j)
            {
                Console.WriteLine("biggest number is {0}",i);
            }
            else
            {
                Console.WriteLine(" biggest number is {0}", j);
            }
            Console.ReadKey();

        }
    }
}
