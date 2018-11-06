using NUnit.Framework;

namespace GymApp {
    /// <summary>
    /// This class contains all the testing for the Customer class.
    /// </summary>
    [TestFixture]
    class CustomerTest {

        /// <summary>
        /// This test checks to see if the Customer class exists.
        /// </summary>
        [Test]
        public void CheckCustomerObjectExists() {
            Customer cu = new Customer();

            Assert.IsTrue(cu != null);
        }
        [Test]
        public void TestCustomerAllProperties() {
            Customer cu = new Customer {

            Address = "23 Fake St",
            Email = "email@leon.com",
            Firstname = "Leon",
            Membership = false,
            PhoneNumber = "4883784",
            Surname = "Lovely",
            Title = "Dr"
        };
            Assert.AreEqual("23 Fake St", cu.Address);
            Assert.AreEqual("email@leon.com", cu.Email);
            Assert.AreEqual("Leon", cu.Firstname);
            Assert.AreEqual(false, cu.Membership);
            Assert.AreEqual("4883784", cu.PhoneNumber);
            Assert.AreEqual("Lovely", cu.Surname);
            Assert.AreEqual("Dr", cu.Title);
        }
    }
}