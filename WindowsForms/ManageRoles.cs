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
    public partial class ManageRoles : Form
    {
        private readonly CarRentalEntities carRentalDB = new CarRentalEntities();

        public ManageRoles()
        {
            InitializeComponent();
        }

        private void bAddRole_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("EditRole"))
            {
                var addRole = new EditRole(this);
                MdiParent = this.MdiParent;
                addRole.Show();
            }
        }

        private void bDeleteRole_Click(object sender, EventArgs e)
        {
            try
            {
                // Get id of DB record
                var id = (int)dgvRolesList
                    .SelectedRows[0]
                    .Cells["Id"]
                    .Value; //Store value from cell value in new variable

                //Query Db for record
                var role = carRentalDB
                    .Roles
                    .FirstOrDefault(qDB => qDB.Id == id); // Get the value

                DialogResult dr = MessageBox.Show($"DELETING USER ROLE ARE YOU SURE?",
                    "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    //Delete Vehicle from Table
                    carRentalDB.Roles.Remove(role);
                    carRentalDB.SaveChanges();
                    MessageBox.Show("ROLE REMOVED");
                }
                PopulateGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("UNABLE TO DELETE ROLE. ADMIN REQUEST");
            }
        }

        private void bExitRolesList_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManageRoles_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception)
            {

                MessageBox.Show("COULD NOT LOAD GRID");
            }
        }

        public void PopulateGrid()
        {
            var roles = carRentalDB.Roles
                .Select(rec => new //Lambda Expression
                {
                    rec.Id,
                    rec.Name
                })
                .ToList();

            dgvRolesList.DataSource = roles; //Data returned from the DB
            dgvRolesList.Columns["Id"].Visible = false;
            dgvRolesList.Columns["Name"].HeaderText = "Roles";
        }
    }
}
