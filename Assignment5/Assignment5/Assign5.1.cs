using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] copy1=new int[5];
            string[] arr2 = new string[5];
            string[] copy2=new string[5];
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Enter the element:");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int J= 0; J < arr2.Length; J++)
            {
                Console.WriteLine("Enter the  string element:");
                arr2[J] = (Console.ReadLine());
            }
            Console.WriteLine("TO IMPLEMENT SORT METHOD");
            Array.Sort(arr1);
            foreach(int a in arr1)
            {
                Console.WriteLine(a);
            }
            Array.Sort(arr2);
            foreach (string a in arr2)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("TO IMPLEMENT REVERSE METHOD");
                Array.Reverse(arr1);
                Array.Reverse(arr2);
            foreach (int a in arr1)
            {
                Console.WriteLine(a);
            }
            foreach (string a in arr2)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("TO IMPLEMENT COPY METHOD");
            Array.Copy(arr1, copy1, 5);
            Array.Copy(arr2, copy2, 5);
            foreach(int a in copy1)
            {
                Console.WriteLine(a);
            }
            foreach (string a in copy2)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("TO IMPLEMENT CLEAR METHOD");
            Array.Clear(arr1, 0, arr1.Length);    
            Array.Clear(arr2, 0, arr2.Length);
            foreach (int a in arr1)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            foreach (string a in arr2)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();


        }
    }
}
