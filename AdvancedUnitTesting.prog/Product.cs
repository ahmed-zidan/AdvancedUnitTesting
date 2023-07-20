using System;
using System.Collections.Generic;
using System.Text;
using static AdvancedUnitTesting.prog.ProductClassEnum;

namespace AdvancedUnitTesting.prog
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }


        public string ProductBasedOnPrice(int price)
        {
            if (price > 1000)
            {
                return ProductEnum.firstClass.ToString();
            }
            else
            {
                return ProductEnum.SecondClass.ToString();
            }
        }
    }
}
