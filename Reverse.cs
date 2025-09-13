using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Call_Preparation
{
    class Reverse
    {
        public void reverse()
        {
            int n = 123;
            int result = 0;
            while(n > 0)
            {
                int temp = n % 10;
                result = result * 10 + temp;
                n = n / 10;
            }
            Console.WriteLine(result);
        }
    }
}
