using System;
using System.Windows.Forms;

namespace GymApp {
    public partial class EnteringDetails : Form {
        public EnteringDetails() {
            InitializeComponent();
        }

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
        private void v_Exit_Click(object sender, EventArgs e) {

            Application.Exit();
        }

        private void v_OK_Click(object sender, EventArgs e) {

            string ValidationFailureMessage = GetValidationFailureMessage();
            if (ValidationFailureMessage != string.Empty) {
                MessageBox.Show(ValidationFailureMessage);
                return;
            }

            Customer cu = new Customer();
            cu.Title = v_Title.Text;
            cu.Firstname = v_Firstname.Text;
            cu.Surname = v_Surname.Text;
            cu.Address = v_Address.Text;
            cu.Email = v_Email.Text;
            cu.PhoneNumber = v_Phone.Text;
            cu.Membership = v_GymMember.Checked;

            MessageBox.Show("New customer has been created");
            var mainForm = new ESCGym();
            mainForm.Show();
            this.Hide();
        }
    }
}
