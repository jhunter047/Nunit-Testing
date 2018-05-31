using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testdemo
{
    [TestFixture]
    class mytestcase
    {
        [TestCase]
        public void add()
        {
            mymath math = new mymath();
            Assert.AreEqual(31, math.add(20, 11));

        }
        [TestCase]
        public void sub()
        {
            mymath math = new mymath();
            Assert.AreEqual(10, math.sub(20, 10));
        }
    }
}
