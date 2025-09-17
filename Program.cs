using System;
using System.Collections.Generic;
using System.Linq;
using Review_Call_Preparation;
namespace Practice
{
    class Problems
    {
        public static void Main(string[] args)
        {
            //multipleMissingNumbers missing = new multipleMissingNumbers();
            //missing.Missing();

            //SecondLargest sl = new SecondLargest();
            //sl.secondLarge();

            //implementation_abstraction ib = new implementation_abstraction();
            //ib.Voice();

            //linq l = new linq();
            //l.linqImplementation();

            //Reverse rv = new Reverse();
            //rv.reverse();

            Method_Overriding mo = new Method_Overriding();
            mo.Sound();
            Method_Overriding mo1 = new overriding_implementation();
            mo1.Sound();
        }
    }
}