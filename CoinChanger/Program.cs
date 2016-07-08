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
            int input1;

            Console.WriteLine("Enter coins amount 1-99: ");
            input1 = Convert.ToInt32(Console.ReadLine());
            
            //execute method
            execute(input1);
        }

        public static void execute(int input)
        {
            
            //create object
            var obj1 = new Class1();
            obj1.MakeChange(input);

            Console.WriteLine("Quarter:" + obj1.getQuarters());
            Console.WriteLine("Dime:" + obj1.getDimes());
            Console.WriteLine("Nickel:" + obj1.getNickels());
            Console.WriteLine("Penny:" + obj1.getPennies());

            
        }
    }
}
