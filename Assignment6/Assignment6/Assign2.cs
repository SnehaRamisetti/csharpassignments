using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static Assignment6.Assign2;

namespace Assignment6
{
    internal class Assign2
    {
        public delegate void sampledelegate();
         public class Manager
        {
            double petrol;
            double food;
            double others;
            double salary;

            public void cal(double salary)
            {
                Console.WriteLine("salary:", salary);
            }
            public static void print1()
            {

                Console.WriteLine("petrol:");

                Console.WriteLine("food:");

                Console.WriteLine("others");
            }

        }
        public class MarketingExecutive
        {
            double kilometer;
            double tour;
            double telephone;
            double salary;


            public static void print2()
            {

                Console.WriteLine("kilometer");

                Console.WriteLine("TOUR:");

                Console.WriteLine("TELEPHONE");
            }

        }
        public class program
        {
            public static void Main()
            {
                Manager manager = new Manager();
                Console.WriteLine("ENTER SALARY");
                double salary = Convert.ToDouble(Console.ReadLine());
                manager.cal(salary);
                double petrol = salary * 8 / 100;
                double food = salary * 13 / 100;
                double others = salary * 3 / 100;
                sampledelegate del1,del2,del3;
                del1 = new sampledelegate(print1);
                del2 = new sampledelegate(print2);
                del3 = del1 + del2;
                del3();
                
                
               
                MarketingExecutive marketingExecutive = new MarketingExecutive();
                Console.WriteLine("enter kilometer");
                double kilometer=Convert.ToDouble(Console.ReadLine());
                double tour = kilometer * 5;
                double telephone = 1000;

                Console.ReadKey();

            }
        }
    }
}
