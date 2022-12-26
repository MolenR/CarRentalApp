using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForms
{
    public partial class RentalRecord : Form
    {
        // Gives Access to the Entities inside de DB
        private readonly CarRentalEntities carRentalDB;

        public RentalRecord()
        {
            InitializeComponent();

            //Initializing to new Instance 
            carRentalDB = new CarRentalEntities();
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

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMessages += "Error: Please Enter Missing Data.\n\r";
                }

                if(age < minAge)
                {
                    isValid = false;
                    errorMessages += "Error: Invalid Age.\n\r";
                }

                if (string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMessages += "Error: Please Enter Missing Data.\n\r";
                }

                if (dateRent > dateReturned)
                {
                    isValid = false;
                    errorMessages += "Illegal Date Selection\n\r";
                }

                if (isValid)
                {
                    //Declare object to the DB 
                    var rentalRecord = new CarRentalRecord // .NET makes query LINQ faster by refactoring 
                    {
                        /*rentalRecord.*/CustomerName = customerName,
                        //DateOfBirth = dateOfBirth,
                        DateRented = dateRent,
                        DateReturned = dateReturned,
                        Cost = (decimal)cost,
                        CarType = (int)cbTypeCar.SelectedValue
                    };
                    /* Use of {} and ; on end!!*/

                    //Add 
                    carRentalDB.CarRentalRecords.Add(rentalRecord);
                    carRentalDB.SaveChanges();

                    MessageBox.Show($"Thank you {customerName}, \n\r" +
                        $"Renting the car type: {carType}\n\r" +
                        $"From {dateRent} untill {dateReturned}\n\r" +
                        $"The total costs will be: ${cost}\n\r" +
                        "THANK YOU FOR RENTING WITH US");
                }
                else
                {
                    MessageBox.Show(errorMessages);
                }
            }
            // Catch the Error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw will end the program out of the execption
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Query for the List of cars
            //var cars = carRentalDB.TypesOfCars.ToList();

            var cars = carRentalDB.TypesOfCars
                .Select(car => new { ID = car.Id, Name = car.Make + " " + car.Model })
                .ToList();
            //ComboBox search Name
            cbTypeCar.DisplayMember= "Name";
            //Store the id
            cbTypeCar.ValueMember= "ID";
            cbTypeCar.DataSource= cars;
        }

        private void bCancelRent_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
