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
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private readonly CarRentalEntities carRentalDB = new CarRentalEntities(); // Initialize the DB in on go over the Script

        public AddEditVehicle()
        {
            InitializeComponent();
            lbTitleVehicle.Text = "Add Vehicle";
            isEditMode = false;
        }

        // Getting the Object TypesOfCar in the Constructor
        public AddEditVehicle(TypesOfCar carToEdit) // Setting field value // Method OverLoading
        {
            InitializeComponent(); // Intializing 
            lbTitleVehicle.Text = "Edit Vehicle"; // Setting Title 
            isEditMode = true;
            PopulateFields(carToEdit); // Pass field value
        }

        //
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
            if(isEditMode)
            {
                //Edit
                var id = int.Parse(lbID.Text); // can not use (int) because of ToString()
                var car = carRentalDB.TypesOfCars.FirstOrDefault(carId => carId.Id == id);
                car.Model = tbModelVehicle.Text;
                car.Make = tbMakeVehicle.Text;
                car.VIN = tbVINVehicle.Text;
                car.License = tbLicenseVehicle.Text;
                car.Year = int.Parse(tbYearVehicle.Text);

                carRentalDB.SaveChanges();
            }
            else //(!isEditMode)
            {
                try
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
                    carRentalDB.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bCancelEdit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
