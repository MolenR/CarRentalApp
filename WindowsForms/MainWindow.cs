using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class MainWindow : Form
    {
        private Login _login;
        public string _rolename;
        public User _user;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(Login login, User user)
        {
            InitializeComponent();  
            _login = login;
            _user = user;
            _rolename = user.UserRoles.FirstOrDefault().Role.ShortName;
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var isOpen = Utils.FormIsOpen("EditRentalRecord");
            if (!isOpen)
            {
                //Instance new object
                var addRentalRecord = new EditRentalRecord() { MdiParent = this };
                addRentalRecord.Show();
            }
        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var isOpen = Utils.FormIsOpen("ManageVehicles");
            if (!isOpen)
            {
                // Should check for this and not open another window
                var vehicleListing = new ManageVehicles { MdiParent = this };
                vehicleListing.Show();
            }
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var isOpen = Utils.FormIsOpen("ManageRentalRecords");
            if (!isOpen)
            {
                var manageRentalRecords = new ManageRentalRecords { MdiParent = this };
                manageRentalRecords.Show();
            }
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var isOpen = Utils.FormIsOpen("ManageUsers");
            if (!isOpen)
            {
                var manageUsers = new ManageUsers { MdiParent = this };
                manageUsers.Show();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if(_rolename != "admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
            }
        }
    }
}
