using NUnit.Framework;

namespace GymApp {
    [TestFixture]
        /// <summary>
        /// This class is used for testing various methods in the Utility class.
        /// </summary>
    class UtilityTest {

        // Tests

        /// <summary>
        /// This tests the rounding method in the class
        /// </summary>
        [Test]
            public void TestRoundValuesMethod() {
            Assert.AreEqual(10, Utility.RoundValue(0, 9.51));
            Assert.AreEqual(9, Utility.RoundValue(0, 9.49));
            Assert.AreEqual(10.5, Utility.RoundValue(1, 10.457));
            Assert.AreEqual(10.4, Utility.RoundValue(1, 10.44));
            Assert.AreEqual(15.35, Utility.RoundValue(2, 15.354));
            Assert.AreEqual(15.34, Utility.RoundValue(2, 15.336));
        }
    }
}
