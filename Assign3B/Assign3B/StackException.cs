using System;
using System.Collections.Generic;

using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assign3B
{
    internal class StackException : Exception
    {
        public StackException()
        {

            
            Console.WriteLine("stack is full");

        }
        public StackException(string message)
        {


            Console.WriteLine("stack is empty");

        }


        public static void Main ()
        {
            int i;
            int k;
            Stack<int> mystack = new Stack<int>(6);
            Console.WriteLine("push=1 or pop=2");
            int a=Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {

                for (i = 0; i <= 10; i++)
                {
                    Console.WriteLine("Enter the element:");
                    int V = Convert.ToInt32(Console.ReadLine());
                    mystack.Push(V);
                    mystack.Count();
                    if (mystack.Count == 5)
                    {
                        throw new StackException();
                    }
                    
                   
                }
               
            }
            else if(a == 2)
            {
                for (k = 5; k >= 1; k--)
                {

                    mystack.Pop();
                    mystack.Count();
                    if (mystack.Count == 0)
                    {
                        throw new StackException(" Can't do pop operation");
                    }
                }
            }
            else
            {
                Console.WriteLine("ENTER VALID NUMBER");
            }

            foreach (int j in mystack)
            {
                Console.WriteLine(j);
            }
            Console.ReadKey();
        }

    }
}
