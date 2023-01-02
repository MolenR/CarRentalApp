using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class EditRole : Form
    {
        private readonly CarRentalEntities carRentalDB = new CarRentalEntities();
        
        private ManageRoles _manageRoles;

        public EditRole(ManageRoles manageRoles)
        {
            InitializeComponent();
            _manageRoles = manageRoles;
        }

        private void bEditRole_Click(object sender, EventArgs e)
        {
            try
            {
                string roleName = tbRoleName.Text;
               
                var role = new Role
                {
                    Name = roleName
                };
                carRentalDB.Roles.Add(role);
                carRentalDB.SaveChanges();

                MessageBox.Show("NEW ROLE ADDED");

                _manageRoles.PopulateGrid(); //NullReferenceExeption

                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR FAILED ADDING NEW ROLE");
            }
        }
        private void bCancelRole_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
