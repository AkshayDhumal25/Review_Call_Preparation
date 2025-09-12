using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Call_Preparation
{
    class linq
    {
        public void linqImplementation()
        {
            int[] array = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            var value = array.Where(x => x == 1).First();

            if(value == 1)
            {
                Console.WriteLine("1 Present");
            }
            else
            {
                Console.WriteLine("Not Present");
            }
        }
    }
}
