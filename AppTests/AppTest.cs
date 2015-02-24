using App;
using NUnit.Framework;

namespace AppTests
{
    [TestFixture]
    public class AppTest
    {
        [Test]
        public void SimpleTest()
        {
            Assert.DoesNotThrow(() => Program.Main());
        }
    }
}
