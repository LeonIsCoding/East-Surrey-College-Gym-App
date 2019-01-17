using System;
using System.Windows.Forms;

namespace GymApp {
    /// <summary>
    /// This partial class acts as the backend for the Login form
    /// </summary>
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        /// <summary>
        /// This method runs when the user clicks on the Login control
        /// It first checks if the UserLogin method returns true
        /// If true then it hides the current form and displays the EnterDetails form.
        /// If not, it will display a messagebox with an error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e) {
            if (UserLogin(txtUsername.Text, txtPassword.Text)) {
                var CustomerDetailsForm = new EnteringDetails();
                CustomerDetailsForm.Show();
                Hide();
            }
            else {
                MessageBox.Show("User not found, please try again");
            }
        }
        /// <summary>
        /// The exit method simply closes down the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        /// <summary>
        /// This private static bool method has string parameters that are used as a user login
        /// If Username equals "Admin" and Password equals "admin", then it returns true
        /// If not, returns false
        /// </summary>
        /// <param name="Username"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        private static bool UserLogin(string Username, string Password) {
            if (Username == "Admin" && Password == "admin") {
                return true;
            }
            return false;
        }
    }
}