using NUnit.Framework;

namespace GymApp {
    [TestFixture]
    class ValidatorTest {
        [Test]
        public void IsEmptyTestMethod() {
            Assert.AreEqual(false, Validator.IsEmpty("amiempty"));
            Assert.AreEqual(true, Validator.IsEmpty(string.Empty));
        }
        [Test]
        public void IsExerciseLevelUnselectedTestMethod() {
            Assert.AreEqual(false, Validator.IsExerciseLevelUnselected(1));
            Assert.AreEqual(true, Validator.IsExerciseLevelUnselected(-1));
        }
    }
}
