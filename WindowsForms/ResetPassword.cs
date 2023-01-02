using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class ResetPassword : Form
    {
        private readonly CarRentalEntities carRentalDB = new CarRentalEntities();

        private User _user;

        public ResetPassword(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void bSavePassword_Click(object sender, EventArgs e)
        {
            try
            {
                var password = tbNewPassword.Text;
                
                var minLength = 8;
                string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string lowercase = "abcdefghijklmnopqrstuvw";
                string digits = "0123456789";
                string specialChars = "!@#$%^&*?";
                string whiteSpaces = " ";
                
                var confirm = tbConfirmPassword.Text;
                
                var user = carRentalDB.Users.FirstOrDefault(qDB => qDB.Id == _user.Id);

                user.Password = Utils.HashPassword(password);

                if(password.Length == minLength) 
                {
                    MessageBox.Show("PASSWORDS NOT SAME LENGTH");
                    return;
                }
                
                if (!password.Contains(uppercase) || 
                    !password.Contains(lowercase) || 
                    !password.Contains(digits) || 
                    !password.Contains(specialChars) ||
                    password.Contains(whiteSpaces))
                {
                    MessageBox.Show("PASSWORDS NEEDS TO CONTAIN UPPERCASE, " +
                        "\n\rLOWERCASE, \n\rDIGITS , \n\rSPECIALCHAR. \n\rNO WHITESPACES");
                    return;
                }

                if (password != confirm)
                {
                    MessageBox.Show("PASSWORDS DO NOT MATCH");
                    return;
                }

                carRentalDB.SaveChanges();

                MessageBox.Show("PASSWORD RESET");

                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("PASSWORD RESET FAILED");
            }
        }
    }
}
