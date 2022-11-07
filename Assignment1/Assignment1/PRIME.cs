using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class PRIME
    {
        public static void Main()
        {
            int i;
            int j = 1;
             int num= 0;
            Console.WriteLine("enter the number");
            i= Convert.ToInt32(Console.ReadLine());
            while(j<i)
            {
                if(i %j==0)
                    {
                    num++;
                    j++;
                    }
                else
                {
                    j++;
                }

            }
            if(num>=2)
            {
                Console.WriteLine("{0} is prime",i);
            }
            else
            {
                Console.WriteLine("{0} is not prime",i);
            }
            Console.ReadKey();

        }
    }
}
