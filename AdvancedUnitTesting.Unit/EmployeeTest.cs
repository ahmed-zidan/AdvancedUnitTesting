using AdvancedUnitTesting.prog;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdvancedUnitTesting.Unit
{
    [TestFixture]
    class EmployeeTest
    {

        Employee emp;

        [SetUp]
        public void setup()
        {
            emp = new Employee();
        }



        [Test]
        [TestCase(60, true)]
        [TestCase(70, true)]
        [TestCase(40, true)]
        public void employeeIsSeniorTest1(int age, bool expected)
        {
            var res = emp.isSenior(age);
            Assert.That(res, Is.EqualTo(expected));
        }


        [Test]
        [TestCaseSource(typeof(TestData))]
       
        public bool employeeIsSeniorTest2(int age)
        {
            return emp.isSenior(age);
        }


        public class TestData:IEnumerable
        {
            
            public IEnumerator GetEnumerator()
            {
                yield return new TestCaseData(60).Returns(true);
                yield return new TestCaseData(70).Returns(true);
                yield return new TestCaseData(40).Returns(false);
                
            }
        }




        [Test]
        [Sequential]
        public void employeeIsSeniorTest3([Values(60 , 70 , 30)]int age, [Values(true , true , false)]bool expected)
        {
            var res = emp.isSenior(age);
            Assert.That(res, Is.EqualTo(expected));
        }

        [Test]
        public void employeeIsSeniorTest4([Range(60, 100, 10)] int age, [Values(true)] bool expected)
        {
            var res = emp.isSenior(age);
            Assert.That(res, Is.EqualTo(expected));
        }

        [Test]
        public void employeeIsSeniorTest5([Random(60, 100, 5,Distinct = true)] int age, [Values(true)] bool expected)
        {
            var res = emp.isSenior(age);
            Assert.That(res, Is.EqualTo(expected));
        }


    }
}
