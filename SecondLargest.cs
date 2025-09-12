using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Call_Preparation
{
    class SecondLargest
    {
        public void secondLarge()
        {
            int[] array = { 12, 35, 1, 10, 34, 1, 35 };

            int large = 0;
            int secondLarge = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > large)
                {
                    secondLarge = large;
                    large = array[i];
                }

                if (array[i] < large && array[i] > secondLarge)
                {
                    secondLarge = array[i];
                }
            }

            Console.WriteLine(secondLarge);
        }
    }
}
