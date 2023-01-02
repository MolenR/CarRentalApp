using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class ManageRentalRecords : Form
    {
        private readonly CarRentalEntities carRentalDB = new CarRentalEntities();
        public ManageRentalRecords()
        {
            InitializeComponent();
        }

        private void bAddRecord_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddRecord"))
            {
                var addRecord = new EditRentalRecord(this);
                MdiParent = this.MdiParent;
                addRecord.Show();
            }
        }

        private void bEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // Get id of DB record
                var id = (int)dgvRentalRecordList
                    .SelectedRows[0]
                    .Cells["ID"]
                    .Value; //Store value from cell value in new variable

                //Query Db for record
                var record = carRentalDB
                    .CarRentalRecords
                    .FirstOrDefault(qDB => qDB.Id == id); // Get the value

                var editRentalRecord = new EditRentalRecord(record, this)
                {
                    MdiParent = this.MdiParent
                };
                editRentalRecord.Show();

                carRentalDB.CarRentalRecords.Add(record); // Checken werkt niet goed
                carRentalDB.SaveChanges();

                PopulateGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("FAILED EDITING RECORD");
            }
        }

        private void bDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // Get id of DB record
                var id = (int)dgvRentalRecordList
                    .SelectedRows[0]
                    .Cells["Id"]
                    .Value; //Store value from cell value in new variable

                //Query Db for record
                var record = carRentalDB
                    .CarRentalRecords
                    .FirstOrDefault(qDB => qDB.Id == id); // Get the value

                DialogResult dr = MessageBox.Show("DELETING RECORD ARE YOU SURE?",
                    "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    //Delete Vehicle from Table
                    carRentalDB.CarRentalRecords.Remove(record);
                    carRentalDB.SaveChanges();
                    MessageBox.Show("RECORD REMOVED");
                    PopulateGrid();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("FAILED REMOVING RECORD");
            }
        }


        private void ManageRentalRecords_Load(object sender, EventArgs e)
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
            var records = carRentalDB.CarRentalRecords
                .Select(rec => new //Lambda Expression
                {
                    Customer = rec.CustomerName,
                    // AgeCheck = rec.Age
                    StartDate = rec.DateRented,
                    EndDate = rec.DateReturned,
                    rec.Id,
                    rec.Cost,
                    RentedCarType = rec.TypesOfCar.Make + " " + rec.TypesOfCar.Model 
                })
                .ToList();

            dgvRentalRecordList.DataSource = records; //Data returned from the DB
            dgvRentalRecordList.Columns["StartDate"].HeaderText = "Start Date";
            dgvRentalRecordList.Columns["EndDate"].HeaderText = "End Date";
            dgvRentalRecordList.Columns["Id"].Visible = false;
        }

        private void bExitRecords_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bRefreshRecords_Click(object sender, EventArgs e)
        {
            PopulateGrid(); // Needed untill Add and Edit are fixed to Refresh the DB
        }
    }
}
