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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new EditRentalRecord();
            addRentalRecord.ShowDialog();
            addRentalRecord.MdiParent = this;
        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declare Variable
            
            // Cast Application from the base Form
            var OpenForms = Application.OpenForms.Cast<Form>();

            // Declare boolean to check if From is already open
            bool isOpen = OpenForms.Any(qDB => qDB.Name == "ManageVehicles");

            // Should check for this and not open another window
            if(!isOpen)
            {
                var vehicleListing = new ManageVehicles();
                vehicleListing.MdiParent = this;
                vehicleListing.Show();
            }
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            bool isOpen = OpenForms.Any(qDB => qDB.Name == "ManageRentalRecords");
            if(!isOpen)
            {
                var manageRentalRecords = new ManageRentalRecords();
                manageRentalRecords.MdiParent = this;
                manageRentalRecords.Show();
            }
        }
    }
}
