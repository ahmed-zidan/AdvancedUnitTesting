using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedUnitTesting.prog
{
   public class Employee
    {
        public int age { set; get; }


        public bool isSenior(int age)
        {
            if(age >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
