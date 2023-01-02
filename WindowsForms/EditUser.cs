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
    public partial class EditUser : Form
    {
        private readonly CarRentalEntities carRentalDB = new CarRentalEntities();
        
        private ManageUsers _manageUsers;

        public EditUser(ManageUsers manageUsers)
        {
            InitializeComponent();
            _manageUsers = manageUsers;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = carRentalDB.Roles.ToList();
            cbRolesList.DataSource = roles;
            cbRolesList.ValueMember = "Id";
            cbRolesList.DisplayMember = "Name";
        }

        private void bAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbUsername.Text;
                var roleID = (int)cbRolesList.SelectedValue;
                string password = Utils.DefaultHashPassword();
                var user = new User
                {
                    Username = username,
                    Password = password,
                    isActive = true
                };
                carRentalDB.Users.Add(user);
                carRentalDB.SaveChanges();

                var userID = user.Id;

                var userRole = new UserRole 
                {
                    RoleID = roleID,
                    UserID = userID
                };
                
                carRentalDB.UserRoles.Add(userRole);
                carRentalDB.SaveChanges();

                MessageBox.Show("NEW USER ADDED");
                
                _manageUsers.PopulateGrid(); //NullReferenceExeption

                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR FAILED ADDING NEW USER");
            }        
        }

        private void bCancelUser_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
