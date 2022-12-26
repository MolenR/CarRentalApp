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
    public partial class ManageRentalRecords : Form
    {
        private readonly CarRentalEntities carRentalDB;
        public ManageRentalRecords()
        {
            InitializeComponent();
            carRentalDB = new CarRentalEntities();
        }

        private void bAddRecord_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new EditRentalRecord(this);
            addRentalRecord.ShowDialog();
            addRentalRecord.MdiParent = this.MdiParent;
            carRentalDB.CarRentalRecords.Create();
            carRentalDB.SaveChanges();

            PopulateGrid();
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
                    .FirstOrDefault(qDB => qDB.id == id); // Get the value

                var editRentalRecord = new EditRentalRecord(record, this)
                {
                    MdiParent = this.MdiParent
                };
                editRentalRecord.Show();

                carRentalDB.CarRentalRecords.Add(record);
                carRentalDB.SaveChanges();

                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    .FirstOrDefault(qDB => qDB.id == id); // Get the value

                DialogResult dr = MessageBox.Show("DELETING RECORD ARE YOU SURE?",
                    "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    //Delete Vehicle from Table
                    carRentalDB.CarRentalRecords.Remove(record);
                    carRentalDB.SaveChanges();
                }
                PopulateGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bExitRecords_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManageRentalRecords_Load(object sender, EventArgs e)
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
            var records = carRentalDB.CarRentalRecords
                .Select(rec => new //Lambda Expression
                {
                    Customer = rec.CustomerName,
                    // AgeCheck = rec.DateOfBirth
                    StartDate = rec.DateRented,
                    EndDate = rec.DateReturned,
                    Id = rec.id,
                    rec.Cost,
                    RentedCarType = rec.TypesOfCar.Make + " " + rec.TypesOfCar.Model 
                })
                .ToList();

            dgvRentalRecordList.DataSource = records; //Data returned from the DB
            dgvRentalRecordList.Columns["StartDate"].HeaderText = "Start Date";
            dgvRentalRecordList.Columns["EndDate"].HeaderText = "End Date";
            dgvRentalRecordList.Columns["Id"].Visible = false;
        }
    }
}
