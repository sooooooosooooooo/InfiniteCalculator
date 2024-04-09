using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteCalculator
{
    internal class Infinite
    {
        public int[] Num = new int[0];
        public bool Negativity = false;
        //convertation of string to array
        public Infinite(string number)
        {
            // if number is negative
            if (number[0] == '-')
            {
                Negativity = true;
                for (int i = 1;i < number.Length; i++)
                {
                    Num = Num.Append(Convert.ToInt32(number[i]) - 48).ToArray();
                }
            }
            // in fumber is positive
            else
            {
                for(int i = 0; i < number.Length; i++)
                {
                    Num = Num.Append(Convert.ToInt32(number[i]) - 48).ToArray();
                }
            }
        }
        public Infinite() { }
    }
}
