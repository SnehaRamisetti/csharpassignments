using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public delegate void printdelegate(double salary,double petrol,double food,double others);
    internal  class Manager
    {
        double petrol;
        double food;
        double others;
        double salary;

        public void cal(double salary)
        {
          Console.WriteLine("salary:",salary);
        }
        public  static void print(double salary, double petrol,double food,double others)
        {
            
            Console.WriteLine("petrol:",petrol);
          
            Console.WriteLine("food:",food);

            Console.WriteLine("others",others);
        }





        public static void Main(string[] args)
        {
            Manager manager = new Manager();
            Console.WriteLine("ENTER SALARY");
            double salary = Convert.ToDouble(Console.ReadLine());
            manager.cal(salary);
           double petrol = salary * 8 / 100;
           double food = salary * 13 / 100;
           double others = salary * 3 / 100;
            printdelegate del = new printdelegate(print);
            del(salary,petrol,food,others);
           
            Console.ReadKey();
        }
        

    }
}
