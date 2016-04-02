using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SB.Calculator.UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {


        [Test]
        public void Add_WhenAdd2Plus2_ShouldReturn4()
        {

            var calculator = new Calculator();
            var sut = calculator.Add(2, 2);
            Assert.AreEqual(4, sut);


        }

        [Test]
        public void Add_WhenAdd4Plus6_ShouldReturn10()
        {

            var calculator = new Calculator();
            var sut = calculator.Add(4, 6);
            Assert.AreEqual(10, sut);


        }


        [Test]
        public void Add_WhenAddDesimalValues_ShouldReturResutl()
        {

            var calculator = new Calculator();
            var sut = calculator.Add(1.2, 1.3);
            Assert.AreEqual(2.5, sut);


        }


    }
}
