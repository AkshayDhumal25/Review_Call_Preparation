using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Call_Preparation
{
    class overriding_implementation : Method_Overriding
    {
        public override void Sound()
        {
            Console.WriteLine("Specific Sound");
        }
    }
}
