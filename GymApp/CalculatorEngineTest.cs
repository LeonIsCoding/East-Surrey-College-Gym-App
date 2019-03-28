using System;
using NUnit.Framework;

namespace GymApp {
    /// <summary>
    /// This class is used for testing various methods in the CalculatorEngine class.
    /// </summary>
        [TestFixture]
    class CalculatorEngineTest {
        // Tests

        /// <summary>
        /// This test makes sure that the CalculatorEngine class exists
        /// </summary>
        [Test]
        public void GetClass() {
            CalculatorEngine ce = new CalculatorEngine();
        }
        /// <summary>
        /// This test checks the recommended daily intake method 
        /// </summary>
        [Test]
        public void CalcRDI() {
            Assert.AreEqual(1200.0, Engine.CalcRDI("Sedentary", 1000));
            Assert.AreEqual(1375.0, Engine.CalcRDI("Light (1-3 days per week)", 1000));
            Assert.AreEqual(1550.0, Engine.CalcRDI("Moderate (3-5 days per week)", 1000));
            Assert.AreEqual(1725.0, Engine.CalcRDI("Heavy (6-7 days per week)", 1000));
            Assert.AreEqual(1900.0, Engine.CalcRDI("Very Heavy (Twice per day or more)", 1000));

            Assert.Throws<Exception>(() => Engine.CalcRDI(null, 1000));
        }
        /// <summary>
        /// This test checks the BMR calculation method
        /// returns BMR double
        /// </summary>
        [Test]
        public void CalcBMR() {
            Engine.IsMale = false;
            Engine.AgeYears = 21;
            Engine.WeightKG = 64;
            Engine.HeightCM = 210;
            Engine.BMR = Engine.BMR_rHB();

            Assert.AreEqual(1599.051, Engine.BMR);
        }
        /// <summary>
        /// This tests the BMI calculation method
        /// </summary>
        [Test]
        public void CalcBMI() {
            Engine.IsMale = false;
            Engine.AgeYears = 21;
            Engine.WeightKG = 64;
            Engine.HeightM = 2.1;
            Engine.BMI = Engine.CalcBMI();

            Assert.AreEqual(14.512471655328797, Engine.BMI);
        }
        /// <summary>
        /// This tests that the correct BMI category is returned depending on the parameter
        /// </summary>
        [Test]
        public void CalcBMICategory() {
            Assert.AreEqual("Underweight", Engine.GetBMICategory(16));
            Assert.AreEqual("Healthy", Engine.GetBMICategory(19.5));
            Assert.AreEqual("Overweight", Engine.GetBMICategory(26.4));
            Assert.AreEqual("Obese", Engine.GetBMICategory(31));
        }
        private CalculatorEngine Engine { get; set; } = new CalculatorEngine();
    }
}