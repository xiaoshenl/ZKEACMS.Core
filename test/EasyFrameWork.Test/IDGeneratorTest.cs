using Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EasyFrameWork.Test
{
    [TestClass]
    public class IDGeneratorTest
    {
        private IDGenerator _generator;
        public IDGeneratorTest()
        {
            _generator = new IDGenerator();
        }
        [TestMethod]
        public void TestCombine()
        {
            string id = _generator.CreateStringId();
        }
    }
}
