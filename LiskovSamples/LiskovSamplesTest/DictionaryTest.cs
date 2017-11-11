using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiskovSamples.Dictionary;
using LiskovSamples;
using System;

namespace LiskovSamplesTest
{
    [TestClass]
    public class DictionaryTest
    {
        SillyDictionary _dictionary = Locator.GetInstance<SillyDictionary>();

        [TestMethod]
        public void GetValueTest()
        {
            _dictionary.Add("almafa", "belafa");

            String value = _dictionary.GetValue("almafa");

            Assert.AreEqual("belafa", value);
        }

        [TestMethod]
        public void GetValueTest_MissingKey()
        {
            String value = _dictionary.GetValue("almafa");

            Assert.IsNull(value);
        }

    }
}
