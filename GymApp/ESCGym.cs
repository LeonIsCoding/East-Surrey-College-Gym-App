#region (C) Copyright 2018 Leon Essam.
// ---Begin Copyright Notice---20180213T10900
//
// NOTICE
//
// THIS SOFTWARE IS THE PROPERTY OF AND CONTAINS CONFIDENTIAL INFORMATION OF
// INFOR AND/OR ITS AFFILIATES OR SUBSIDIARIES AND SHALL NOT BE DISCLOSED
// WITHOUT PRIOR WRITTEN PERMISSION. lICENSED CUSTOMERS MAY COPY AND ADAPT
// THIS SOFTWARE FOR THEIR OWN USE IN ACCORDANCE WITH THE TERMS OF THEIR
// SOFTWARE LICENSE AGREEMENT. ALL OTHER RIGHTS RESERVED.
//
// (c) COPYRIGHT 2018 INFOR. ALL RIGHTS RESERVED. THE WORD AND DESIGN MARKS
// SET FORTH HEREIN ARE TRADEMARKS AND/OR REGISTERED TRADEMARKS OF INFOR
// AND/OR ITS AFFILIATES AND SUBSIDIARIES. ALL RIGHTS RESERVED. ALL OTHER
// TRADEMARKS LISTED HEREIN ARE THE PROPETY OF THEIR RESPECTIVE OWNERS.

// ---End Copyright Notice---
#endregion

using System;
using System.Windows.Forms;
//
// Author: Leon Essam
// Version: 0.8
// ID: 2

namespace GymApp {
    public partial class ESCGym : Form {

        int AgeYears = 0;
        int WeightKg = 0;
        int HeightCm = 0;

        // These constants are used to set the decimal places when rounding a value
        const int ZERODECIMALPLACES = 0;
        const int ONEDECIMALPLACES = 1;
        const int TWODECIMALPLACES = 2;

        // This constant is used to convert the Height in centermetres into metres.
        const double DENOMINATOR = 100d;

        public ESCGym() {
            InitializeComponent();
        }

        private void v_Calculate_Click(object sender, EventArgs e) {
            // Call getValidationFailureMessage to validate the input & method will return a message if there is a failure
            // An empty message means it has passed all validation

            string validationFailureMessage = getValidationFailureMessage();
            if (validationFailureMessage != string.Empty) {
                MessageBox.Show(validationFailureMessage);
                return;
            }
            // Instanciate an instance of the Customer object note 
            // there is only ever one of these. 
            Customer cu = new Customer();
            // Instanciate an instance of the CalculatorEngine object note 
            // there is only ever one of these. 
            CalculatorEngine ce = new CalculatorEngine();

            // Set calculator object properties to current input values
            ce.AgeYears = AgeYears;
            ce.WeightKG = WeightKg;
            ce.HeightCM = HeightCm;
            // Force denominator to be double
            ce.HeightM = HeightCm / DENOMINATOR;
            ce.ExerciseLevel = v_ExerciseLevel.SelectedItem.ToString();
            ce.IsMale = v_Male.Checked;
            ce.BMR = ce.BMR;

            // Set calculations and format them according to client requirements

            // For safety, each of these should be wrapped in a try catch in case 
            // an exception is thrown in the CalculationEngine
            // but not sure how best to code this but expect a feedback to the user with an error

            v_BMR.Text = Utility.RoundValue(TWODECIMALPLACES, ce.BMR).ToString();

            v_BMI.Text = Utility.RoundValue(ONEDECIMALPLACES, ce.BMI).ToString();

            v_DailyKilocalorieIntake.Text = Math.Round(ce.RDI).ToString();

            v_Category.Text = ce.BMICategory;
        }

        private void v_Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private string getValidationFailureMessage() {
            if (Validator.IsExerciseLevelUnselected(v_ExerciseLevel.SelectedIndex)) {
                return "Exercise Level must be selected";
            }
            try {
                WeightKg = Convert.ToInt32(v_Weight.Text);
                HeightCm = Convert.ToInt32(v_Height.Text);
                AgeYears = Convert.ToInt32(v_Age.Text);
            }
            catch (Exception) {
                return "All values must be numeric";
            }

            return string.Empty;
        }

        private void ESCGym_Load(object sender, EventArgs e) {
            //var LoginForm = new Login();
            //LoginForm.ShowDialog();
        }

        private void v_Help_Click(object sender, EventArgs e) {

            MessageBox.Show("Function not implemented yet");
        }

        private void v_Print_Click(object sender, EventArgs e) {
            MessageBox.Show("Function not implemented yet");
        }
    }
}
