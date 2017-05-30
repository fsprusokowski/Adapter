using Adapter.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdapterTests
{
    [TestClass]
    public class TwoPinPLugTests
    {
        [TestMethod]
        public void TwoPinConnectionSuccessWithTwoInputs()
        {
            var plug = new TwoPinPlug();

            plug.Connect(FemalePLug.TwoInputs);

            Assert.IsTrue(plug.Connected);
        }

        [TestMethod]
        public void TwoPinConnectionSuccessWithThreeInputs()
        {
            var plug = new TwoPinPlug();

            plug.Connect(FemalePLug.ThreeInputs);

            Assert.IsTrue(plug.Connected);
        }
    }
}
