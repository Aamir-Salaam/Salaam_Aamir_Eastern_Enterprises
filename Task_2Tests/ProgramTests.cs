using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void BootStrapperTest()
        {
            string[] inp = new string[] { "sum", "2,3,4,5" };

            Program p = new Program();

            p.BootStrapper(inp);

            int expected = 14;
            int actual = p.ResultSum;

            Assert.AreEqual(expected, actual);
        }
    }
}