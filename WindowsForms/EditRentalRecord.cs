using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class EditRentalRecord : Form
    {
        // Gives Access to the Entities inside de DB
        private readonly CarRentalEntities carRentalDB = new CarRentalEntities();
        private bool isEditMode;

        private ManageRentalRecords _manageRecords;

        public EditRentalRecord(ManageRentalRecords manageRecords = null)
        {
            InitializeComponent();

            lbTitle.Text = "Add New Record";
            this.Text = "Add New Record";
            isEditMode = false; 
            _manageRecords = manageRecords;
        }

        public EditRentalRecord(CarRentalRecord recordToEdit, ManageRentalRecords manageRecords = null)
        {
            InitializeComponent(); // Intializing 
            lbTitle.Text = "Edit Record"; // Setting Title
            this.Text = "Edit Record"; // Set Title Form to this
            _manageRecords = manageRecords;
            if (recordToEdit == null) 
            {
                MessageBox.Show("INVALID SELECTED RECORD");
            }
            else
            {
                isEditMode = true;
                PopulateFields(recordToEdit); // Pass field value
            }
        }

        private void PopulateFields(CarRentalRecord recordToEdit)
        {
            tbCustomerName.Text = recordToEdit.CustomerName.ToString();

            //dtpAge.Value = (DateTime)recordToEdit.Age; // Make definition for Age
            
            cbTypeCar.Text = recordToEdit.CarType.ToString();
            dtpRented.Value = (DateTime)recordToEdit.DateRented;
            dtpReturned.Value = (DateTime)recordToEdit.DateRented;
            tbCost.Text = recordToEdit.Cost.ToString();
            lbRecordId.Text = recordToEdit.Id.ToString();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = tbCustomerName.Text;
                string errorMessages = "";

                // Date of Birth
                var dateOfBirth = dtpAge.Value;
                //Set Minimal Age
                int minAge = 18;
                //Calculate the user Age
                var today = DateTime.Today;
                int age = today.Year - dateOfBirth.Year;
                if (dateOfBirth > DateTime.Now.AddYears(-age)) age--;

                // Costs
                double cost = Convert.ToDouble(tbCost.Text);

                // DateTime
                var dateRent = dtpRented.Value;
                var dateReturned = dtpReturned.Value;

                // Select car type
                var carType = cbTypeCar.Text; //cbTypeCar.SelectedIndex.ToString shows type index[number]
                
                // Check if userInput is true
                bool isValid = true;

                if(!isValid)
                {
                    if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                    {   
                        errorMessages += "ERROR: PLEASE ENTER VALUE.\n\r";
                    }

                    if((age < minAge) || (dateRent > dateReturned))
                    {   
                        errorMessages += "ERROR: INVALID DATE.\n\r";
                    }
                }
                else 
                {
                    var rentalRecord = new CarRentalRecord(); // .NET makes query LINQ faster by refactoring

                    if (isEditMode)
                    {
                        // IF in EditMode get ID and retrieve record from DB
                        var id = int.Parse(lbRecordId.Text);
                        rentalRecord = carRentalDB.CarRentalRecords.FirstOrDefault(qDB => qDB.Id == id);
                    }
                    //If Not in EditMode. Add object to the DB
                    else
                    {
                        //Populate record with values
                        RentalRecordProfile(customerName, cost, dateRent, dateReturned, rentalRecord);
                        //Add 
                        carRentalDB.CarRentalRecords.Add(rentalRecord);
                        carRentalDB.SaveChanges();

                        _manageRecords.PopulateGrid(); // NullReferenceException
                    }
                }
                carRentalDB.SaveChanges();
                MessageBox.Show("RECORD SAVED");

                MessageBox.Show($"Thank you {customerName}, \n\r" +
                    $"\n\rRenting the car type: \n\r{carType}\n\r" +
                    $"\n\rFrom {dateRent} untill {dateReturned}\n\r" +
                    $"\n\rThe total costs will be: ${cost}\n\r" +
                    "\n\rTHANK YOU FOR RENTING WITH US");
                        
                Close();
            }
            // Catch the Error
            catch (Exception)
            {
                MessageBox.Show("FAILED SUBMITTING FORM");
                //throw will end the program out of the execption
            }
        }

        private void RentalRecordProfile(string customerName, double cost, DateTime dateRent, DateTime dateReturned, CarRentalRecord rentalRecord)
        {
            rentalRecord.CustomerName = customerName;
            // Add Age to DB so it can be querried
            //rentalRecord.Age = dateOfBirth,
            rentalRecord.DateRented = dateRent;
            rentalRecord.DateReturned = dateReturned;
            rentalRecord.Cost = (decimal)cost;
            rentalRecord.CarType = (int)cbTypeCar.SelectedValue;
        }

        private void EditRentalRecord_Load(object sender, EventArgs e)
        {
            //Query for the List of cars
            //var cars = carRentalDB.TypesOfCars.ToList();

            var cars = carRentalDB.TypesOfCars
                .Select(car => new { ID = car.Id, Name = car.Make + " " + car.Model })
                .ToList();
            //ComboBox search Name
            cbTypeCar.DisplayMember = "Name";
            //Store the id
            cbTypeCar.ValueMember = "ID";
            cbTypeCar.DataSource = cars;
        }

        private void bCancelRent_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
