using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathima_26_6_20
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("give a number");
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            numbers.Sort();
            Console.WriteLine("Biggest number is {0}", numbers.Count);
            //Kappa Keepo

        }
    }
}
