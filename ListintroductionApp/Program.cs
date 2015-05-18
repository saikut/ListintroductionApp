using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListintroductionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.Add(4);
            myList.Add(6);
            myList.Add(14);

            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            List<string> secondList = new List<string>();
            secondList.Add("BITM");
            secondList.Add("Dhaka");

            foreach (string s in secondList)
            {
                Console.Write(s + "");
            }
            Console.ReadKey();
        }
    }
}
