using System;
using System.Data;
using System.Linq;
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
            if (!Utils.FormIsOpen("EditUser"))
            {
                var addUser = new EditUser(this);
                MdiParent = this.MdiParent;
                addUser.Show();
            }    
        }

        private void bEditUserRole_Click(object sender, EventArgs e)
        {
            try
            {
                // Get id of DB record
                var id = (int)dgvUsersList
                    .SelectedRows[0]
                    .Cells["Id"]
                    .Value; //Store value from cell value in new variable

                //Query Db for data
                var role = carRentalDB
                    .UserRoles
                    .FirstOrDefault(qDB => qDB.Id == id); // Get the value

                var editUserRole = new EditUser(this)
                {
                    MdiParent = this.MdiParent
                };
                editUserRole.Show();

                carRentalDB.SaveChanges();

                PopulateGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("FAILED EDITING RECORD");
            }
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
                
                //Hash the new created password
                var password_hashed = Utils.DefaultHashPassword();
                
                //The new entered password is the hashed_password
                user.Password = password_hashed;

                carRentalDB.SaveChanges();

                MessageBox.Show($"{user.Username}'s PASSWORD RESET");
                PopulateGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("PASSWORD RESET FAILED");
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
                user.isActive = user.isActive == true ? false : true; //CHECK OK
                
                carRentalDB.SaveChanges();
                MessageBox.Show($"{user.Username} USER STATUS CHANGED");
                
                PopulateGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("CAN NOT CHANGE USER STATUS");
            }
        }

        /*DeleteUserRol must be used first if User needs to be removed*/
        private void bDeleteUserRole_Click(object sender, EventArgs e)
        {
            try
            {
                // Get id of DB record
                var id = (int)dgvUsersList
                    .SelectedRows[0]
                    .Cells["Id"]
                    .Value; //Store value from cell value in new variable

                //Query Db for record
                var user = carRentalDB
                    .UserRoles
                    .FirstOrDefault(qDB => qDB.Id == id); // Get the value

                DialogResult dr = MessageBox.Show($"DELETING USER ROLE ARE YOU SURE?",
                    "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    //Delete Vehicle from Table
                    carRentalDB.UserRoles.Remove(user);
                    carRentalDB.SaveChanges();
                    MessageBox.Show("USER ROLE REMOVED");
                }
                PopulateGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("UNABLE TO DELETE USER ROLE. ADMIN REQUEST");
            }
        }

        private void bDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Get id of DB record
                var id = (int)dgvUsersList
                    .SelectedRows[0]
                    .Cells["Id"]
                    .Value; //Store value from cell value in new variable

                //Query Db for record
                var user = carRentalDB
                    .Users
                    .FirstOrDefault(qDB => qDB.Id == id); // Get the value

                DialogResult dr = MessageBox.Show($"DELETING USER ARE YOU SURE?",
                    "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    //Delete Vehicle from Table
                    carRentalDB.Users.Remove(user);
                    carRentalDB.SaveChanges();
                    MessageBox.Show("USER REMOVED");
                }
                PopulateGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("UNABLE TO DELETE USER. REMOVE USER ROLE FIRST");
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception)
            {

                MessageBox.Show("FAILED LOADING GRID");
            }
        }

        public void PopulateGrid()
        {
            var users = carRentalDB.Users
                .Select(rec => new //Lambda Expression
                {
                    rec.Id,
                    rec.Username,
                    UserRoles = rec.UserRoles.FirstOrDefault().Role.Name,
                    rec.Password,
                    rec.isActive
                })
                .ToList();

            dgvUsersList.DataSource = users; //Data returned from the DB
            dgvUsersList.Columns["Id"].Visible = false;
            dgvUsersList.Columns["UserName"].HeaderText = "Name";
            dgvUsersList.Columns["UserRoles"].HeaderText = "Role";
            //dgvUsersList.Columns["Password"].Visible = false;
            dgvUsersList.Columns["isActive"].HeaderText = "Active";
        }

        private void bRefreshUsers_Click(object sender, EventArgs e)
        {
            PopulateGrid(); //In use for query not loading - error
        }

        private void bExitUsers_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
