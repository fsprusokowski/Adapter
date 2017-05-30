using Adapter.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdapterTests
{
    [TestClass]
    public class ThreePinTests
    {
        [TestMethod]
        public void ThreePinConnectionFailedWithTwoInputs()
        {
            var plug = new ThreePinPLug();

            plug.Connect(FemalePLug.TwoInputs);

            Assert.IsFalse(plug.Connected);
        }

        [TestMethod]
        public void ThreePinConnectionSuccessWithThreeInputs()
        {
            var plug = new ThreePinPLug();

            plug.Connect(FemalePLug.ThreeInputs);

            Assert.IsTrue(plug.Connected);
        }
    }
}
