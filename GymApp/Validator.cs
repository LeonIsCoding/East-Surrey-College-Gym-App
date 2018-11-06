using System;

namespace GymApp
{
    /// <summary>
    /// This class holds methods that will validate user information that can be called anywhere from the application
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// This method checks that a value (after trimming leading and trailing spces is empty
        /// </summary>
        /// <param name="value"></param>
        /// <returns>true or false depending on whether the ttrimmed value is empty</returns>
        public static Boolean IsEmpty(string value) {
            value = value.Trim();
            if (value == string.Empty) {
                return true;
            }
            return false;
        }
        /// <summary>
        /// This method examines the index value of the selected item from a list box which will be -1 if no item is selected
        /// returns false if the index is -1
        /// </summary>
        /// <param name="value"></param>
        /// <returns>true or false depending on whether an item in the Excercise Level control has been seleected</returns>
        public static Boolean IsExerciseLevelUnselected(int value) {
            if (value == -1) {
                return true;
            }
            return false;
        }


    }
}