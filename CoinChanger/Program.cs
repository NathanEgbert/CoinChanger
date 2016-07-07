using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinChange;
namespace CoinChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            execute();
        }

        public static void execute()
        {
            var obj1 = new Class1();
            obj1.GreaterThanTwentyFive(86);
            Console.WriteLine("Quarter:" + obj1.qCount);
            Console.WriteLine("Dime:" + obj1.dCount);
            Console.WriteLine("Nickel:" + obj1.nCount);
            Console.WriteLine("Penny:" + obj1.pCount);
        }
    }
}
