using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChange
{
    public class Class1
    {
        public int qCount = 0;
        public int dCount = 0;
        public int nCount = 0;
        public int pCount = 0;
        
        
        public void GreaterThanTwentyFive(int input)
        {
            while (input > 0)
            {
                if (input >= 25)
                {
                    qCount  += 1;
                    input -= 25;
                }

                else if (input >= 10)
                {
                    dCount += 1;
                    input -= 10;
                }

                else if (input >= 5)
                {
                    nCount += 1;
                    input -= 5;
                }

                else if (input >= 1)
                {
                    pCount += 1;
                    input -= 1;
                }
            }



        }

        

    }
    
}
