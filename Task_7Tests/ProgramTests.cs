using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void BootStrapperTest()
        {
            string[] inp = new string[] { "add", @"\\;\\3;5;7;1001" };

            Program p = new Program();

            p.BootStrapper(inp);

            int expected = 15;
            int actual = p.ResultSum;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BootStrapperTest2()
        {
            string[] inp = new string[] { "add", @"\\;\\3;5;7;1000" };

            Program p = new Program();

            p.BootStrapper(inp);

            int expected = 1015;
            int actual = p.ResultSum;

            Assert.AreEqual(expected, actual);
        }

    }
}