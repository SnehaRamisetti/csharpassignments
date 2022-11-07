using System;
using System.Collections;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3B
{
    internal class Clone
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            

            Stack mystack = new Stack(6);
            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);
            mystack.Push(4);
            mystack.Push(5);
           
            mystack.Push(6);
            mystack.Push(7);
            foreach (int i in mystack)
            {
                Console.WriteLine(i);
            }
            Stack mystack2 = mystack;
            foreach (int i in mystack2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
