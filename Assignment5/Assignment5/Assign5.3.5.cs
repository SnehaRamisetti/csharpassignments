using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class EmployeeB
    {
        int ID { get; set; }
        string Name { get; set; }
        double Salary { get; set; }
        
        public static void Main()
        {
            EmployeeB employee1 = new EmployeeB();
            {
                employee1.ID = 101;
                employee1.Name = "navya";
                employee1.Salary = 10000;

            };
            EmployeeB employee2 = new EmployeeB();
            {
                employee2.ID = 102;
                employee2.Name = "divya";
                employee2.Salary = 15000;

            };
            EmployeeB employee3 = new EmployeeB();
            {
                employee3.ID = 103;
                employee3.Name = "ramya";
                employee3.Salary = 20000;

            };
            EmployeeB employee4 = new EmployeeB();
            {
                employee4.ID = 104;
                employee4.Name = "vidya";
                employee4.Salary = 25000;

            };
            EmployeeB employee5 = new EmployeeB();
            {
                employee5.ID = 105;
                employee5.Name = "sowmya";
                employee5.Salary = 22000;

            };
            List<EmployeeB> employeeBs = new List<EmployeeB>();
            employeeBs.Add(employee1);
            employeeBs.Add(employee2);
            employeeBs.Add(employee3);
            employeeBs.Add(employee4);
            employeeBs.Add(employee5);
            foreach(EmployeeB b in employeeBs)
            {
                Console.WriteLine("ID={0},NAME={1},SALARY={2}", b.ID, b.Name, b.Salary);
            }
            Console.WriteLine("COUNT={0}", employeeBs.Count());
            EmployeeB employee6 = new EmployeeB();
            {
                employee6.ID = 105;
                employee6.Name = "sowmya";
                employee6.Salary = 22000;

            };
            employeeBs.Add(employee6);
            foreach (EmployeeB b in employeeBs)
            {
                Console.WriteLine("ID={0},NAME={1},SALARY={2}", b.ID, b.Name, b.Salary);
            }

            Console.WriteLine("COUNT={0}",employeeBs.Count());
            EmployeeB d = employeeBs.Find(emp => emp.Name.StartsWith("s"));
            Console.WriteLine("ID={0},NAME={1},SALARY={2}", d.ID, d.Name, d.Salary);
           
            Console.ReadKey();
           
        }
    }
}
