using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void BootStrapperTest()
        {
            string[] inp = new string[] { "sum", @"2,3,4\n6" };

            Program p = new Program();

            p.BootStrapper(inp);

            int expected = 15;
            int actual = p.ResultSum;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BootStrapperTest2()
        {
            string[] inp = new string[] { "sum", "2,3,4;6" };

            Program p = new Program();

            p.BootStrapper(inp);

            int expected = -1;
            int actual = p.ResultSum;

            Assert.AreEqual(expected, actual);
        }
    }
}