using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        interface IPrintableinterface
        {
            void Print();
        }
        public class Employee:IPrintableinterface
        {

           public int EmpNo;
           public string EmpName;
            public double Salary;
            double HRA;
            double TA;
            double DA;
            double PF;
            double TDS;
            public double NetSalary;
           public double GrossSalary;
            public Employee(int EmpNo, string EmpName, double Salary)
            {
                this.EmpNo = EmpNo;
                this.EmpName = EmpName;
                this.Salary = Salary;

            }
            public  virtual void Calculate()
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
                
                Console.WriteLine("DA={0}", DA);
                Console.WriteLine("TA={0}", TA);
                Console.WriteLine("HRA={0}", HRA);
                Console.WriteLine("GrossSalary={0}",GrossSalary);
            }
            public virtual void CalculateSalary()
            {
                PF = GrossSalary * 10 / 100;
                TDS = GrossSalary * 18 / 100;
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine("NetSalary={0}",NetSalary);
                
                
                
            }
            public void Print()
            {
                Console.WriteLine("Empname={0}",EmpName);
                Console.WriteLine("Empno={0}",EmpNo);
                Console.WriteLine("Salary={0}",Salary);
                
            }




        }
        class Manager : Employee
        {
            double petrol;
            double food;
            double other;
            public Manager(int Empno, string EmpName, double Salary) : base(Empno, EmpName, Salary)
            {

                this.EmpNo = Empno;
                this.EmpName = EmpName;
                this.Salary = Salary;


            }
            public void input()
            {
                petrol = Salary * 8 / 100;
                food = Salary * 13 / 100;
                other = Salary * 3 / 100;
            
            }
            public  override void Calculate()
            {
               GrossSalary= petrol+food+other;
                Console.WriteLine("grosssalary:{0}", GrossSalary);

            }
            public override void CalculateSalary()
            {
                base.CalculateSalary();
                Console.WriteLine("NetSalary:{0}", NetSalary);


            }

        }
        class MarketingExecutive : Employee
        {
            double travel;
            double tour;
            double telephone;
            public MarketingExecutive(int Empno, string EmpName, double Salary) : base(Empno, EmpName, Salary)
            {

                this.EmpNo = Empno;
                this.EmpName = EmpName;
                this.Salary = Salary;


            }
            public void detail()
            {
                Console.WriteLine("how many kilometer you travelled:");
                double travel = Convert.ToDouble(Console.ReadLine());
                tour = travel * 5;
                telephone = 1000;
            }
            public override void Calculate()
            {
                GrossSalary = travel + tour + telephone;
                Console.WriteLine("grosssalary:{0}", GrossSalary);

            }
            public override void CalculateSalary()
            {
                base.CalculateSalary();
                Console.WriteLine("NetSalary:{0}", NetSalary);




            }

            static void Main(string[] args)
            {
                Console.WriteLine("enter Empno:");
                int Empno = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter Empname:");
                string Empname = (Console.ReadLine());

                Console.WriteLine("enter Salary:");
                double Salary = Convert.ToDouble(Console.ReadLine());
                IPrintableinterface I1=new Employee(Empno, Empname, Salary);
                I1.Print();

                Employee c1 = new Employee(Empno, Empname, Salary);
                c1.Calculate();

                c1.CalculateSalary();
               


                Manager c2 = new Manager(Empno, Empname, Salary);
                c2.input();

                c2.Calculate();
                c2.CalculateSalary();
                MarketingExecutive c3= new MarketingExecutive(Empno, Empname, Salary);
                c3.detail();

                c3.Calculate();
                c3.CalculateSalary();

                Console.ReadKey();

            }
        }
    }
}
