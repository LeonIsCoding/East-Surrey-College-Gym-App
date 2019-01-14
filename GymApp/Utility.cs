using System;

namespace GymApp {
    /// <summary>
    /// This class holds generic methods that can be called from anywhere in our application.
    /// </summary>
    public static class Utility {

        /// <summary>
        /// This methods rounds a value to a specfic number of decimal places
        /// </summary>
        /// <param name="decimalplacesrequired"></param>
        /// <param name="value"></param>
        /// <returns>returns the value rounded to the specficied of decimal places</returns>
        public static double RoundValue(int decimalplacesrequired, double value) {

            // Check that we have a sensible value for number of decimal places required
            // Probably better to throw new exception at this point
            // But not sure how best to code this

            if (decimalplacesrequired < 0 || decimalplacesrequired > 4) {

                return value;
            }
            // Check that we have a sensible value for the number to be rounded
            // Probably better to throw new exception at this point
            // But not sure how best to code this

            if (value <= 0) {

                return value;
            }
            // If we drop through here then we have sensible values for the input parameters

            double FormattedValue = Math.Round(value, decimalplacesrequired);

            return FormattedValue;
        }
    }
}
