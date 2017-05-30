using Adapter.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdapterTests
{
    [TestClass]
    public class AdapterTests
    {
        [TestMethod]
        public void AdapterConnectionSuccessWithTwoInputs()
        {
            var plug = new ThreePinPLug();
            var adapter = new PlugAdapter(plug);

            adapter.Connect(FemalePLug.TwoInputs);

            Assert.IsTrue(plug.Connected);
        }

        [TestMethod]
        public void AdapterConnectionSuccessWithThreeInputs()
        {
            var plug = new ThreePinPLug();
            var adapter = new PlugAdapter(plug);

            adapter.Connect(FemalePLug.TwoInputs);

            Assert.IsTrue(plug.Connected);
        }
    }
}
