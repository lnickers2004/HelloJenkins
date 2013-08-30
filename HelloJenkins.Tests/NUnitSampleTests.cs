using NUnit.Framework;

namespace HelloJenkins.Tests {
    [TestFixture]
    public class NUnitSampleTests {
        [Test]
        public void SomePassingTest() {
            Assert.AreEqual(5, 5);
        }

        [Test]
        public void SomeFailingTestMadeItPassNow() {
            Assert.Less(5, 7);
        }
    }
    
}
