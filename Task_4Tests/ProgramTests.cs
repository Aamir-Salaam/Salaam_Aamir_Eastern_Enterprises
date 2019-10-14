using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void BootStrapperTest()
        {
            string[] inp = new string[] { "add", @"\\;\\2;3;5;7" };

            Program p = new Program();

            p.BootStrapper(inp);

            int expected = 17;
            int actual = p.ResultSum;

            Assert.AreEqual(expected, actual);
        }
    }
}