using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Call_Preparation
{
    class multipleMissingNumbers
    {
        public void Missing()
        {
            string str = "Engineer";
            var dict = new Dictionary<char, int>();

            for(int i = 0; i < str.Length; i++)
            {
                if (dict.ContainsKey(str[i]))
                {
                    dict[str[i]]++;
                }
                else
                {
                    dict[str[i]] = 1;
                }
            }

            foreach(var c in dict)
            {
                Console.WriteLine($"{c.Key} : {c.Value}");
            }
        }
    }
}
