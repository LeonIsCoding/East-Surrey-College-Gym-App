using System;
using System.Windows.Forms;

namespace GymApp {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (UserLogin(txtUsername.Text, txtPassword.Text)) {
                var CustomerDetailsForm = new EnteringDetails();
                CustomerDetailsForm.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("User not found, please try again");
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private static Boolean UserLogin(string Username, string Password) {
            if (Username == "Admin" && Password == "admin") {
                return true;
            }
            return false;
        }
    }
}