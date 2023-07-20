using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using AdvancedUnitTesting.prog;
using static AdvancedUnitTesting.prog.ProductClassEnum;

namespace AdvancedUnitTesting.Unit
{
    [TestFixture]
    public class ProductTest
    {

        Product pr;

        [SetUp]
        public void setup()
        {
            pr = new Product();
        }


        [TearDown]
        public void endObj()
        {
            pr = null;
        }


        [Test]
        [Ignore("for development changes")]
        [Category("FirstClass")]
        public void checkProductFirstClass()
        {
            //Product pr = new Product();

            var res = pr.ProductBasedOnPrice(2000);
            Assert.That(res, Is.EqualTo(ProductEnum.firstClass.ToString()));
        }

        [Test]
        [Category("SecondClass")]
        public void checkProductSecondClass()
        {
            //Product pr = new Product();

            var res = pr.ProductBasedOnPrice(2000);
            Assert.That(res, Is.EqualTo(ProductEnum.firstClass.ToString()));
        }

    }
}
