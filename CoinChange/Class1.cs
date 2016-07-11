using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChange
{
    public class Class1
    {
        public int qCount;
        private int dCount;
        private int nCount;
        private int pCount;

        
        //constructor
        
        public Class1()
        {
            qCount = 0;
            dCount = 0;
            nCount = 0;
            pCount = 0;

        }//end constructor
        

        public void MakeChange(int input)
        {
            while (input > 0)
            {
                if (input >= 25)
                {
                    qCount += 1;
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
            }//end while loop

        }//end make change method


        //getters

        public int Quarters
        {
            get
            {
                return qCount;
            }
        }

        public int Dimes
        {
            get
            {
                return dCount;
            }
        }

        public int Nickels
        {
            get
            {
                return nCount;
            }
        }

        public int Pennies
        {
             get
            {
                return pCount;
            }
           
        }


    }//end class
}
