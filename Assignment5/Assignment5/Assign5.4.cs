using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class MyStack<T>
    {
        public static void Main()
        {
            Stack<object> mystack = new Stack<object>();
            mystack.Push(1);
            mystack.Push("two");
            mystack.Push(3.576);
            mystack.Push(4.4654767);
            mystack.Push(null);
            foreach (var i in mystack)
            {
                Console.WriteLine(i);
            }
            mystack.Pop();
            foreach (var i in mystack)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
