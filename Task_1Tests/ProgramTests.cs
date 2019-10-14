using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void BootStrapperTest()
        {
            string[] inp = new string[] { "sum", "2,3" };

            Program p = new Program();

            p.BootStrapper(inp);

            int expected = 5;
            int actual = p.ResultSum;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void BootStrapperTest2()
        {
            string[] inp = new string[] { "multiply", "2,3" };

            Program p = new Program();

            p.BootStrapper(inp);

            int expected = -1;
            int actual = p.ResultSum;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void BootStrapperTest3()
        {
            string[] inp = new string[] { "sum", "2" };

            Program p = new Program();

            p.BootStrapper(inp);

            int expected = 2;
            int actual = p.ResultSum;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BootStrapperTest4()
        {
            string[] inp = new string[] { "sum" };

            Program p = new Program();

            p.BootStrapper(inp);

            int expected = 0;
            int actual = p.ResultSum;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BootStrapperTest5()
        {
            string[] inp = new string[] { "sum", "2,3,5" };

            Program p = new Program();

            p.BootStrapper(inp);

            int expected = -1;
            int actual = p.ResultSum;

            Assert.AreEqual(expected, actual);
        }
    }
}