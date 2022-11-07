using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Player1
     {
        public string Name { get; set; }
        public int Runs { get; set; }
        public Player1(string name,int runs)
        {
            Name = name;
            Runs=runs;
        }
        class Team : IEnumerable
        {
            Player1[] person = new Player1[4];
            public Team()
            {
                person[0] = new Player1("navya", 50);
                person[0] = new Player1("sneha", 150);
                person[0] = new Player1("divya", 75);
                person[0] = new Player1("ramya", 5);
            }
            public IEnumerator GetEnumerator()
            {
                return person.GetEnumerator();
            }
        }   
        class prg
        {
             public static void Main(String[]args)
             {
                Team india = new Team();
                foreach(Player1 p in india)
                {
                    Console.WriteLine("Name={0}and Runs={1}",p.Name,p.Runs);
                }
                Console.ReadKey();
             }
        }
            

        
    }
}
    
