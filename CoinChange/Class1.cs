using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CoinChange
{
    public class Class1
    {
        private int qCount;
        private int dCount;
        private int nCount;
        private int pCount;

       private int quarter = 25;
       private int dime = 10;
       private int nickel = 5;
       private int penny = 1;
       private int count = 1;
       

        
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
                if (coinEvaluation(input, quarter))
                {
                    qCount = coinCountEvaluation(qCount);
                    input -= quarter;
                   
                }

                else if (coinEvaluation(input, dime))
                {
                    dCount = coinCountEvaluation(dCount);
                     input-= dime;
                    
                }

                else if (coinEvaluation(input, nickel))
                {
                    nCount = coinCountEvaluation(nCount);
                     input -= nickel;
                    
                }

                else if (coinEvaluation(input, penny))
                {
                    pCount = coinCountEvaluation(pCount);
                     input -= penny;
                    
                }
            }//end while loop

        }//end make change method


        //evaluates the coins compared to the input
        private bool coinEvaluation(int input1, int coin)
        {
            if (input1 >= coin)
            {
                return true;
            }
            return false;

        }//end coinEvaluation
    

        //evaluates the coin count
        private int coinCountEvaluation(int coin2)
        {
              return coin2 += count;
        }

        private int inputEvaluation(int input2,int coin3)
        {
            return input2 -= coin3;
        }

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
