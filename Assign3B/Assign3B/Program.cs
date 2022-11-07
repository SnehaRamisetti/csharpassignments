using System;
using System.Collections.Generic;

using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assign3B
{
    internal class Mystack:ICloneable
    {
      
        object ICloneable.Clone()
        {
            return Clone();
            
        }
        public object Clone()
        {
            return new Mystack();
            
        }
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            int position;
          
            Stack<int> mystack = new Stack<int>(6);
            
           
            mystack.Push(1);
            mystack.Push(2);    
            mystack.Push(3);
            mystack.Push(4);
            mystack.Push(5);
            mystack.Pop();
            mystack.Push(6);
           
           
            Console.WriteLine(mystack.Contains(7));
           
            foreach (int i in mystack)
            {
                Console.WriteLine(i);
            }
            position = mystack.Peek();
            Console.WriteLine(position);
            mystack.Clear();
            Console.WriteLine("COUNT={0}",mystack.Count());
           
            

            
            Console.ReadKey();


        }
    }
}
