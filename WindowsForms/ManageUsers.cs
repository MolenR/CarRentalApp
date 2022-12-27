using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class ManageUsers : Form
    {
        private readonly CarRentalEntities carRentalDB = new CarRentalEntities();
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void bAddNewUser_Click(object sender, EventArgs e)
        {
            // Add Form to Add New User
        }

        private void bResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                // Get id of DB record
                var id = (int)dgvUsersList
                    .SelectedRows[0]
                    .Cells["ID"]
                    .Value; //Store value from cell value in new variable

                //Query Db for record
                var user = carRentalDB
                    .Users
                    .FirstOrDefault(qDB => qDB.Id == id); // Get the value
                
                //Store the default password
                var defaultPassword = "default1";
                
                //Hash the new created password
                var password_hashed = Utils.HashPassword(defaultPassword);
                
                //The new entered password is the hashed_password
                user.Password = password_hashed;

                carRentalDB.SaveChanges();

                MessageBox.Show($"{user.Username}'s PASSWORD RESET");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Get id of DB record
                var id = (int)dgvUsersList
                    .SelectedRows[0]
                    .Cells["ID"]
                    .Value; //Store value from cell value in new variable

                //Query Db for record
                var user = carRentalDB
                    .Users
                    .FirstOrDefault(qDB => qDB.Id == id); // Get the value

                //Set User to InActive if Deactivate
                user.isActive = user.isActive == true ? false : true; 

                carRentalDB.SaveChanges();

                MessageBox.Show($"{user.Username}'s USER DEACTIVATED");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void PopulateGrid()
        {
            var records = carRentalDB.Users
                .Select(rec => new //Lambda Expression
                {
                    UserId = rec.Id
                })
                .ToList();

            dgvUsersList.DataSource = records; //Data returned from the DB
        }

        private void bRefreshUsers_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void bExitUsers_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
