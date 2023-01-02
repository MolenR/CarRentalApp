using System;
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
            _rolename = user.UserRoles.FirstOrDefault().Role.Name;
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check for this window open and not open another window
            if (!Utils.FormIsOpen("EditRentalRecord"))
            {
                //Initialize new object
                var addRentalRecord = new EditRentalRecord() { MdiParent = this };
                addRentalRecord.Show();
            }
        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageVehicles"))
            {
                var vehicleListing = new ManageVehicles { MdiParent = this };
                vehicleListing.Show();
            }
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageRentalRecords"))
            {
                var manageRentalRecords = new ManageRentalRecords { MdiParent = this };
                manageRentalRecords.Show();
            }
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("ManageUsers"))
            {
                var manageUsers = new ManageUsers { MdiParent = this };
                manageUsers.Show();
            }
        }

        private void manageRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageRoles"))
            {
                var manageRoles = new ManageRoles { MdiParent = this };
                manageRoles.Show();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if(_user.Password == Utils.DefaultHashPassword())
            {
                var resetPassword = new ResetPassword(_user);
                resetPassword.ShowDialog();
            }

            var username = _user.Username;
            tsslLoginText.Text = $"Logged in As: {username}";
            if(_rolename != "admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
                manageRolesToolStripMenuItem.Visible = false;
            }
        }
    }
}
