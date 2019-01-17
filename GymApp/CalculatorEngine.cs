using System;

namespace GymApp
{
    /// <summary>
    /// This class creates a calculation engine object, note there is only ever one instance of this class
    /// </summary>
    public class CalculatorEngine {
        // Constructor
        public CalculatorEngine() {
            
        }

        // Properties

        /// <summary>
        /// This property holds the age in years
        /// </summary>
        public int AgeYears { get; set; }
        /// <summary>
        /// This property holds the weight in kilograms
        /// </summary>
        public int WeightKG {
            get {
                return _Weight;
            }
            set {
                _Weight = value;
            }
        }
        /// <summary>
        /// This property holds the height in centimeters
        /// </summary>
        public int HeightCM {
            get {
                return _HeightCM;
            }
            set {
                _HeightCM = value;
            }
        }
        /// <summary>
        /// Note, this propety holds the height in metres as a double since we're dividing Height in centimetres by 100 to get Height in meters
        /// </summary>
        public double HeightM
        {
            get {
                return _HeightM;
            }
            set {
                _HeightM = value;
            }
        }
        /// <summary>
        /// This propety holds the user's BMR
        /// </summary>
        public double BMR
        {
            get {                
                return _BMR;
            }
            set {
                _BMR = value;
                _BMR = BMR_rHB();
            }
        }
        /// <summary>
        /// This property holds the Body Mass Index
        /// </summary>
        public double BMI {
            get {
                return _BMI;
            }
            set {
                _BMI = value;
                _BMI = CalcBMI();
            }
        }
        /// <summary>
        /// This property holds the Body Mass Index
        /// </summary>
        public string BMICategory {
            get {
                return _BMICategory;
            }
            set {
                _BMICategory = value;
                _BMICategory = GetBMICategory(BMI);
            }
        }
        /// <summary>
        /// This property holds a flag that indicates that the calculations have to be done for 
        /// male or female depending whether its true or false. If true then it's a male
        /// </summary>
        public bool IsMale
        {
            get {
                return _IsMale;
            }
            set {
                _IsMale = value;
            }
        }
        /// <summary>
        /// This property holds the Recommended Daily Intake which is a measurement of Kilocalorie
        /// </summary>
        public double RDI
        {
            get {
                return _RDI;
            }
            set {
                _RDI = value;
                _RDI = CalcRDI(ExerciseLevel, _BMR);
            }
        }
        /// <summary>
        /// This property holds the exercise level which is a string which is the selected item from the UI control
        /// </summary>
        public string ExerciseLevel
        {
            get {
                return _ExerciseLevel;
            }
            set {
                _ExerciseLevel = value;
            }
        }
        // Methods

        /// <summary>
        ///This method returns Basal Metabolic Rate, return to 2 decimal places
        ///This method calculates the BMR using the revised Harris-Benedict equation
        /// </summary>
        /// <param name="WeightKG"></param>
        /// <param name="HeightCM"></param>
        /// <param name="AgeYears"></param>
        /// <param name="IsMale"></param>
        /// <returns>Basal Metabolic Rate, revised Harris-Benedict equation</returns>
        public double BMR_rHB() {
            ///These constants are factors used in the calculation of Basal Metabolic Rate (BMR) 
            ///using the revised Harris-Benedict equation for men
            const double MENBMRFACTOR = 88.362;
            const double MENWEIGHTFACTOR = 13.397;
            const double MENHEIGHTFACTOR = 4.799;
            const double MENAGEFACTOR = 5.677;

            ///These constants are factors used in the calculation of Basal Metabolic Rate (BMR)
            ///using the revised Harris-Benedict equation for women
            const double WOMENBMRFACTOR = 447.593;
            const double WOMENWEIGHTFACTOR = 9.247;
            const double WOMENHEIGHTFACTOR = 3.098;
            const double WOMENAGEFACTOR = 4.330;

            double result = 69;

            if (IsMale == true) {
                result = MENBMRFACTOR +
                         (MENWEIGHTFACTOR * WeightKG) +
                         (MENHEIGHTFACTOR * HeightCM) -
                         (MENAGEFACTOR * AgeYears);

            } else {
                result = WOMENBMRFACTOR +
                         (WOMENWEIGHTFACTOR * WeightKG) +
                         (WOMENHEIGHTFACTOR * HeightCM) -
                         (WOMENAGEFACTOR * AgeYears);
            }
            return result;
        }
        /// <summary>
        ///This method returns Basal Metabolic Rate, return to 2 decimal places
        ///This method calculates the BMR using the non-revised Harris-Benedict equation
        /// </summary>
        /// <param name="WeightKG"></param>
        /// <param name="HeightCM"></param>
        /// <param name="AgeYears"></param>
        /// <param name="IsMale"></param>
        /// <returns>Basal Metabolic Rate, non-revised Harris-Benedict equation</returns>
        public double BMR_HB() {
            // These constants are factors used in the calculation of Basal Metabolic Rate (BMR) 
            // using the non-revised Harris-Benedict equation for men
            const double MENBMRFACTOR = 66.47;
            const double MENWEIGHTFACTOR = 13.75;
            const double MENHEIGHTFACTOR = 5.003;
            const double MENAGEFACTOR = 6.755;

            // These constants are factors used in the calculation of Basal Metabolic Rate (BMR)
            // using the non-revised Harris-Benedict equation for women
            const double WOMENBMRFACTOR = 655.1;
            const double WOMENWEIGHTFACTOR = 9.563;
            const double WOMENHEIGHTFACTOR = 1.850;
            const double WOMENAGEFACTOR = 4.676;

            double result = 69;

            if (IsMale == true) {
                result = MENBMRFACTOR +
                         (MENWEIGHTFACTOR * WeightKG) +
                         (MENHEIGHTFACTOR * HeightCM) -
                         (MENAGEFACTOR * AgeYears);
            } else {
                result = WOMENBMRFACTOR +
                         (WOMENWEIGHTFACTOR * WeightKG) +
                         (WOMENHEIGHTFACTOR * HeightCM) -
                         (WOMENAGEFACTOR * AgeYears);
            }
            return result;
        }
        /// <summary>
        /// This method calculates the BMI by taking the weight and height
        /// Dividing them and rounding them up together to one decimal place.
        /// </summary>
        /// <param name="Weight"></param>
        /// <param name="Height"></param>
        /// <returns>Body Mass Index</returns>
        public double CalcBMI() {
            double result = 0;

            result = WeightKG / Math.Pow(HeightM, 2);

            return result;
        }
        /// <summary>
        /// This method calculates the Recommended Daily Kilocalorie Intake
        /// It first checks the selected exercise level, the times the BMR by set constants.
        /// </summary>
        /// <param name="Level"></param>
        /// <param name="BMR"></param>
        /// <returns>Basal Metabolic Rate</returns>
        public double CalcRDI(string Level, double BMR) {

            //These constants are used in the calculation of the recommended daily kilocalorie intake
            const double DIRFACTOR_NONE = 1.2;
            const double DIRFACTOR_LIGHT = 1.375;
            const double DIRFACTOR_MODERATE = 1.55;
            const double DIRFACTOR_HEAVY = 1.725;
            const double DIRFACTOR_VERYHEAVY = 1.9;

            double result = 0;

            switch (Level) {
                case "Sedentary": {
                        result = BMR * DIRFACTOR_NONE;
                        break;
                    }
                case "Light (1-3 days per week)": {
                        result = BMR * DIRFACTOR_LIGHT;
                        //return result;
                        break;
                    }
                case "Moderate (3-5 days per week)": {
                        result = BMR * DIRFACTOR_MODERATE;
                        break;
                    }
                case "Heavy (6-7 days per week)": {
                        result = BMR * DIRFACTOR_HEAVY;
                        break;
                    }
                case "Very Heavy (Twice per day or more)": {
                        result = BMR * DIRFACTOR_VERYHEAVY;
                        break;
                    }

                default: {
                        throw new Exception("Unexpected Level");
                    }

            }
            //result = Weight / Math.Pow(Height, 2);
            return result;
        }
        /// <summary>
        /// This method calculates the BMI category by comparing 
        /// the range of the values and assigning a correct category
        /// </summary>
        /// <param name="BMI"></param>
        /// <returns>Body Mass Index Category</returns>
        public string GetBMICategory(double BMI) {
            string Category = string.Empty;

            if (BMI < 18.5) {
                Category = "Underweight";
            } else if (BMI >= 18.5 && BMI <= 24.9) {
                Category = "Healthy";
            } else if (BMI >= 25 && BMI <= 29.9) {
                Category = "Overweight";
            } else {
                Category = "Obese";
            }
            return Category;
        }

        // Instance Variables
        private int _Age;
        private int _Weight;
        private int _HeightCM;
        private string _BMICategory;
        private bool _IsMale;
        private string _ExerciseLevel;
        /// <summary>
        /// Note, this variable must be a double since we're dividing Height in centimeters by 100 to get Height in meters
        /// </summary>
        private double _HeightM;
        private double _BMR;
        private double _BMI;
        private double _RDI;
    }
}