using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class AssignQ6
    { 
         public struct book
    {
        public int bookid,ibooktype;
        public string title;
        public int price;
    }
    public  enum booktype
    {
        magazine = 1,
        novel = 2,
        referencebook = 3,
        miscellaneous = 4,
    }
    public static void Main()
    {
        Console.WriteLine("enter book id");
        int bookid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter title");
        string title = Console.ReadLine();
        Console.WriteLine("enter book price");
        int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter book type");
            int ibooktype = Convert.ToInt32(Console.ReadLine());

            string booktype = Enum.GetName(typeof(booktype), ibooktype);
            

        Console.WriteLine("{0},{1},{2},{3}", bookid, title, price,booktype);
        Console.ReadKey();
    }
}
}
