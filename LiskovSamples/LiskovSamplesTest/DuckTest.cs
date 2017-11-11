using LiskovSamples;
using LiskovSamples.Duck;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LiskovSamplesTest
{
    [TestClass]
    public class DuckTest
    {
        private Duck _duck = Locator.GetInstance<Duck>();

        [TestMethod]
        public void QuackTest()
        {
            _duck.Quack();

            Assert.IsTrue(_duck.IsQuacking);
        }

        [TestMethod]
        public void StopQuackTest()
        {
            (_duck as ToyDuck)?.InsertBatteries();

            _duck.Quack();

            _duck.StopThatQuackAlready();

            Assert.IsFalse(_duck.IsQuacking);
        }

    }
}
