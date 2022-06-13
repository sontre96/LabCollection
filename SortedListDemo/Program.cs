using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListDemo
{
    
    class Program
    {
        public static void Main()
        {
            SortedList objSl = new SortedList();
            objSl.Add("4", "!");
            objSl.Add("3", "Brilliant");
            objSl.Add("2", "am");
            objSl.Add("1", "I");

            Console.WriteLine("Number of Elements in objSl : {0}", objSl.Count);
            Console.WriteLine("\t-KEY-\t-VALUES-");

            for (int i = 0; i < objSl.Count; i++)
            {
                Console.WriteLine("\t{0}:\t{1}", objSl.GetKey(i), objSl.GetByIndex(i));
            }

            Console.ReadLine();

        }
    }
}
