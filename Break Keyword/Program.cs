using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            for (; ; )
            {
                Console.WriteLine($"{++i}");
                if (i == 10)
                {
                    break;
                }

            }

            Console.ReadKey();
        }
    }
}
