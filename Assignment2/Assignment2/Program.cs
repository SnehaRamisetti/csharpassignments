using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        public class Employee
        {

            int EmpNo;
            string EmpName;
            double Salary;
            double HRA;
            double TA;
            double DA;
            double PF;
            double TDS;
            double NetSalary;
            double GrossSalary;
            public Employee(int EmpNo, string EmpName, double Salary)
            {
                this.EmpNo = EmpNo;
                this.EmpName = EmpName;
                this.Salary = Salary;

            }
            public void Calculate()
            {
                if (Salary < 5000)
                {
                    HRA = Salary * 10 / 100;
                    TA = Salary * 5 / 100;
                    DA = Salary * 15 / 100;

                }
                else if (Salary < 10000)
                {
                    HRA = Salary * 15 / 100;
                    TA = Salary * 10 / 100;
                    DA = Salary * 20 / 100;

                }
                else if (Salary < 15000)
                {
                    HRA = Salary * 20 / 100;
                    TA = Salary * 15 / 100;
                    DA = Salary * 25 / 100;
                }
                else if (Salary < 20000)
                {
                    HRA = Salary * 25 / 100;
                    TA = Salary * 20 / 100;
                    DA = Salary * 30 / 100;
                }
                else if (Salary >= 20000)
                {
                    HRA = Salary * 30 / 100;
                    TA = Salary * 25 / 100;
                    DA = (Salary * 35 / 100);
                }
                else
                {
                    Console.WriteLine("enter correct salary");
                }
                GrossSalary = Salary + HRA + TA + DA;
                Console.WriteLine("grosssalary={0}", GrossSalary);
                Console.WriteLine("DA={0}", DA);
                Console.WriteLine("TA={0}", TA);
                Console.WriteLine("HRA={0}", HRA);
            }
            public void CalculateSalary()
            {
                PF = GrossSalary * 10 / 100;
                TDS = GrossSalary * 18 / 100;
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine("Netsalary={0}", NetSalary);
                Console.WriteLine("PF={0}", PF);
                Console.WriteLine("TDS={0}", TDS);
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter Empno:");
           int Empno=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter Empname:");
           string Empname =(Console.ReadLine());

            Console.WriteLine("enter Salary:");
           double Salary = Convert.ToDouble(Console.ReadLine());

            Employee c1 = new Employee(Empno,Empname,Salary);
            c1.Calculate();
            c1.CalculateSalary();

        }
    }
}
