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
    public partial class EditVehicle : Form
    {
        private readonly CarRentalEntities carRentalDB = new CarRentalEntities(); // Initialize the DB in on go over the Script
        private bool isEditMode;

        private ManageVehicles _manageVehicles;

        public EditVehicle(ManageVehicles manageVehicles = null)
        {
            InitializeComponent();
            lbTitleVehicle.Text = "Add New Vehicle";
            this.Text = "Add New Vehicle";
            isEditMode = false;
            _manageVehicles = manageVehicles;
        }

        // Getting the Object TypesOfCar in the Constructor
        public EditVehicle(TypesOfCar carToEdit, ManageVehicles manageVehicles = null) // Setting field value // Method OverLoading
        {
            InitializeComponent(); // Intializing 
            lbTitleVehicle.Text = "Edit Vehicle"; // Setting Title
            this.Text = "Edit Vehicle";
            _manageVehicles = manageVehicles;
            if (carToEdit == null ) 
            {
                MessageBox.Show("Invalid Selected Record");
            }
            else
            {
                isEditMode = true;
                PopulateFields(carToEdit); // Pass field value
            }
        }

        private void PopulateFields(TypesOfCar car)
        {
            lbID.Text = car.Id.ToString();
            tbMakeVehicle.Text = car.Make;
            tbModelVehicle.Text = car.Model;
            tbVINVehicle.Text = car.VIN;
            tbLicenseVehicle.Text = car.License;
            tbYearVehicle.Text = car.Year.ToString();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(tbMakeVehicle.Text) || string.IsNullOrWhiteSpace(tbModelVehicle.Text))
                {
                    MessageBox.Show("INVALID INSERT");
                }
                else
                {
                    if (isEditMode)
                    {
                        //Edit
                        var id = int.Parse(lbID.Text); // can not use (int) because of ToString()
                        var car = carRentalDB.TypesOfCars.FirstOrDefault(carId => carId.Id == id);
                        car.Model = tbModelVehicle.Text;
                        car.Make = tbMakeVehicle.Text;
                        car.VIN = tbVINVehicle.Text;
                        car.License = tbLicenseVehicle.Text;
                        car.Year = int.Parse(tbYearVehicle.Text);
                    }
                    else
                    {
                        //Add Vehicle
                        var newCar = new TypesOfCar // Create new Model
                        {
                            Make = tbMakeVehicle.Text,
                            Model = tbModelVehicle.Text,
                            VIN = tbVINVehicle.Text,
                            License = tbLicenseVehicle.Text,
                            Year = int.Parse(tbYearVehicle.Text)
                        };

                        carRentalDB.TypesOfCars.Add(newCar); // Add to the record
                        _manageVehicles.PopulateGrid();
                    }
                    carRentalDB.SaveChanges();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");                
            }
        }

        private void bCancelEdit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
