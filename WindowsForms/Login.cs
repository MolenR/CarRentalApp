using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Login : Form
    {
        private readonly CarRentalEntities carRentalDB = new CarRentalEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the Username and Password
                string username = tbUsername.Text.Trim();
                string password = tbPassword.Text;

                // Store the new value into new variable
                var password_hashed = Utils.HashPassword(password); 

                //Query with the DB
                var user = carRentalDB.Users
                    .FirstOrDefault(qDB =>
                    qDB.Username == username &&
                    qDB.Password == password && //Needs to change to password_hashed
                    qDB.isActive == true);
                if (user == null)
                {
                    MessageBox.Show("INVALID INSERT");
                }
                else
                {
                    //var role = user.UserRoles.FirstOrDefault();
                    //var roleName = role.Role.ShortName;
                    var mainWindow = new MainWindow(this, user);
                    mainWindow.Show();

                    Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("INVALID ENTRY");
            }
        }
    }
}
