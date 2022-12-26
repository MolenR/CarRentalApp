﻿using System;
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
    public partial class ManageVehicles : Form
    {
        // Gives Access to the Entities inside de DB
        private readonly CarRentalEntities carRentalDB;

        public ManageVehicles()
        {
            InitializeComponent();

            //Initializing to new Instance 
            carRentalDB = new CarRentalEntities();
        }

        private void ManageVehicles_Load(object sender, EventArgs e)
        {
            //SELECT * FROM TypeOfCars
            //Query for the List of cars
            //var cars = carRentalDB.TypesOfCars.ToList();

            // LINQ Query 
            var cars = carRentalDB.TypesOfCars
                .Select(vehicleID => new //Lambda Expression
                {
                    Make = vehicleID.Make, // {Property = value.db}
                    Model = vehicleID.Model,
                    VIN = vehicleID.VIN,
                    License = vehicleID.License,
                    Year = vehicleID.Year,
                    vehicleID.Id
                }) 
                .ToList(); 
            
            dgvVehicleList.DataSource = cars; //Data returned from the DB

            dgvVehicleList.Columns[5].Visible = false; // Setting Column invisible to user
            //Set Columns from the DB to own string 
            //dgvVehicleList.Columns[0].HeaderText = "ID";
            //dgvVehicleList.Columns[1].HeaderText = "NAME";
        }

        private void bAddVehicle_Click(object sender, EventArgs e)
        {
            AddEditVehicle addEdit = new AddEditVehicle
            {
                MdiParent = this.MdiParent
            };
            addEdit.Show();
        }

        private void bEditVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                // Get id of DB record
                var id = (int)dgvVehicleList.SelectedRows[0].Cells["ID"].Value; //Store value from cell value in new variable

                //Query Db for record
                var car = carRentalDB.TypesOfCars.FirstOrDefault(qDB => qDB.Id == id); // Get the value

                //Launch AddEditVehicle window with data from the DB
                var addEditVehicle = new AddEditVehicle(car)
                {
                    MdiParent = this.MdiParent
                };
                addEditVehicle.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bDeleteVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                // Get id of DB record
                var id = (int)dgvVehicleList.SelectedRows[0].Cells["Id"].Value; //Store value from cell value in new variable

                //Query Db for record
                var car = carRentalDB.TypesOfCars.FirstOrDefault(qDB => qDB.Id == id); // Get the value

                //Delete Vehicle from Table
                carRentalDB.TypesOfCars.Remove(car);
                carRentalDB.SaveChanges();

                dgvVehicleList.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            //Refresh
            PopulateGrid();
        }

        // Can be Called for Refresh page // Same way as to populate the DB with data values 
        public void  PopulateGrid()
        {
            //Select model cars from DB
            var cars = carRentalDB.TypesOfCars
                .Select(vehicleID => new //Lambda Expression
                {
                    vehicleID.Make, // {Property = value.db}
                    vehicleID.Model,
                    vehicleID.VIN,
                    vehicleID.License,
                    vehicleID.Year,
                    vehicleID.Id
                })
                .ToList();

            dgvVehicleList.DataSource = cars; //Data returned from the DB

            dgvVehicleList.Columns["Id"].Visible = false; // Setting Column invisible to user
        }

        private void bExitEdit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}