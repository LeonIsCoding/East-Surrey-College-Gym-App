using System;
using System.Windows.Forms;

namespace GymApp {
    /// <summary>
    /// This public partial class is the backend of the EnteringDetails form
    /// </summary>
    public partial class EnteringDetails : Form {
        public EnteringDetails() {
            InitializeComponent();
        }
        /// <summary>
        /// This method returns a validation failure message depending on if information is blank
        /// </summary>
        /// <returns></returns>
        private string GetValidationFailureMessage() {
            if (Validator.IsEmpty(v_Address.Text)) {
                return "Address can not be blank";
            }
            if (Validator.IsEmpty(v_Email.Text)) {
                return "Email can not be blank";
            }
            if (Validator.IsEmpty(v_Firstname.Text)) {
                return "First name can not be blank";
            }
            if (Validator.IsEmpty(v_Phone.Text)) {
                return "Phone can not be blank";
            }
            if (Validator.IsEmpty(v_Surname.Text)) {
                return "Surname can not be blank";
            }
            if (Validator.IsEmpty(v_Title.Text)) {
                return "Title can not be blank";
            }
            return string.Empty;
        }
        /// <summary>
        /// The exit method simply closes down the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void v_Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        /// <summary>
        /// This method from the OK button on the form first checks if it currently has an exisiting validation failure message
        /// if false, it will create a new Customer object from the form controls text values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void v_OK_Click(object sender, EventArgs e) {
            string ValidationFailureMessage = GetValidationFailureMessage();
            if (ValidationFailureMessage != string.Empty) {
                MessageBox.Show(ValidationFailureMessage);
                return;
            }
            Customer cu = new Customer {
                Title = v_Title.Text,
                Firstname = v_Firstname.Text,
                Surname = v_Surname.Text,
                Address = v_Address.Text,
                Email = v_Email.Text,
                PhoneNumber = v_Phone.Text,
                Membership = v_GymMember.Checked
            };
            MessageBox.Show("New customer has been created");
            var mainForm = new ESCGym();
            mainForm.Show();
            Hide();
        }
    }
}
