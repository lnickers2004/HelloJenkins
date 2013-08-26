using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace HelloJenkins.Tests
{
    [TestFixture]
    public class and_and_comparing_two_numbers
    {
        [Test]
        public void and_comparing_7_to_5_test()
        {
            Assert.Greater(7, 5);
        }
    }
}
