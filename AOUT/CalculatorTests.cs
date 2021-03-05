using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AOUT
{
    class CalculatorTests
    {
        private Calculator m_calc;

        [SetUp]
        public void SetUp()
        {
            m_calc = new Calculator();
        }

        [Test]
        public void Sum_NoAddOnce_DefaultToZero()
        {
            int sum = m_calc.Sum();
            Assert.AreEqual(0, sum);
        }

        [Test]
        public void Add_CalledOnce_SavesNumberForSume()
        {
            m_calc.add(5);
            Assert.AreEqual(5, m_calc.Sum());
        }
    }
}
