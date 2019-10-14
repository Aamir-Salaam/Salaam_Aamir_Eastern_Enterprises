using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void BootStrapperTest()
        {
            string[] inp = new string[] { "multiply", @"\\;\\3;5;1001" };

            Program p = new Program();

            p.BootStrapper(inp);

            int expected = 15;
            int actual = p.ResultProduct;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BootStrapperTest2()
        {
            string[] inp = new string[] { "multiply", @"\\;\\3;5;1000" };

            Program p = new Program();

            p.BootStrapper(inp);

            int expected = 15000;
            int actual = p.ResultProduct;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BootStrapperTest3()
        {
            string[] inp = new string[] { "multiply", @"\\;\\3;5;-7;1000" };

            Program p = new Program();

            p.BootStrapper(inp);

            int expected = -1;
            int actual = p.ResultProduct;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BootStrapperTest4()
        {
            string[] inp = new string[] { "multiply", @"2,3\n5" };

            Program p = new Program();

            p.BootStrapper(inp);

            int expected = 30;
            int actual = p.ResultProduct;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BootStrapperTest5()
        {
            string[] inp = new string[] { "multiply", "2,3,6" };

            Program p = new Program();

            p.BootStrapper(inp);

            int expected = 36;
            int actual = p.ResultProduct;

            Assert.AreEqual(expected, actual);
        }

    }
}