using LiskovSamples.CodeContracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSamplesTest
{
    [TestClass]
    public class SillyListTest
    {
        private SillyList _list = new SillyList();

        [TestMethod]
        public void TestAdd()
        {
            _list.Add("almafa");

            Assert.IsTrue(_list.Contains("almafa"));
        }

        [TestMethod]
        public void TestAdd_NullValue_ExpectException()
        {
            _list.Add(null);

            Assert.Fail(); //TODO:
        }

    }
}
