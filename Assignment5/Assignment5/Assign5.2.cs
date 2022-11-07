using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Employee
    {
        
        int ID { get; set; }
        string Name { get; set; }
        double Salary { get; set; }
    
        public static void Main()
        {
            Employee employee1= new Employee();
            {
                employee1.ID = 101;
                employee1.Name = "navya";
                employee1.Salary = 10000;

            };
            Employee employee2 = new Employee();
            {
                employee2.ID = 102;
                employee2.Name = "divya";
                employee2.Salary = 15000;

            };
            Employee employee3 = new Employee();
            {
                employee3.ID = 103;
                employee3.Name = "ramya";
                employee3.Salary = 20000;

            };
            Employee employee4 = new Employee();
            {
                employee4.ID = 104;
                employee4.Name = "vidya";
                employee4.Salary = 25000;

            };
            Employee employee5 = new Employee();
            {
                employee5.ID = 105;
                employee5.Name = "sowmya";
                employee5.Salary = 22000;

            };
            ArrayList arrayList = new ArrayList();
            arrayList.Add(employee1);
            arrayList.Add(employee2);
            arrayList.Add(employee3);
            arrayList.Add(employee4);
            arrayList.Add(employee5);
            foreach(Employee a in arrayList)
            {
                Console.WriteLine("ID={0},NAME={1},SALARY={2}", a.ID, a.Name, a.Salary);
            }
            Console.ReadKey();
        }
    }
}
