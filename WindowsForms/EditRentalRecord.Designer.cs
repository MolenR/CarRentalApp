namespace WindowsForms
{
    partial class EditRentalRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpRented = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTypeCar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bSubmit = new System.Windows.Forms.Button();
            this.dtpReturned = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCarModel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpAge = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.bCancelRent = new System.Windows.Forms.Button();
            this.lbRecordId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Calisto MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(8, 9);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(149, 34);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Rent-a-Car";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerName.Location = new System.Drawing.Point(14, 76);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(307, 26);
            this.tbCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // dtpRented
            // 
            this.dtpRented.CalendarFont = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRented.Location = new System.Drawing.Point(14, 270);
            this.dtpRented.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtpRented.Name = "dtpRented";
            this.dtpRented.Size = new System.Drawing.Size(313, 22);
            this.dtpRented.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Start Date";
            // 
            // cbTypeCar
            // 
            this.cbTypeCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeCar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypeCar.FormattingEnabled = true;
            this.cbTypeCar.Location = new System.Drawing.Point(14, 127);
            this.cbTypeCar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbTypeCar.Name = "cbTypeCar";
            this.cbTypeCar.Size = new System.Drawing.Size(307, 26);
            this.cbTypeCar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type Car";
            // 
            // bSubmit
            // 
            this.bSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubmit.Location = new System.Drawing.Point(751, 458);
            this.bSubmit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(106, 26);
            this.bSubmit.TabIndex = 9;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // dtpReturned
            // 
            this.dtpReturned.CalendarFont = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturned.Location = new System.Drawing.Point(341, 270);
            this.dtpReturned.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtpReturned.Name = "dtpReturned";
            this.dtpReturned.Size = new System.Drawing.Size(313, 22);
            this.dtpReturned.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "End Date";
            // 
            // tbCost
            // 
            this.tbCost.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCost.Location = new System.Drawing.Point(14, 340);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(313, 26);
            this.tbCost.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 321);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = " Car Model";
            // 
            // cbCarModel
            // 
            this.cbCarModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarModel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarModel.FormattingEnabled = true;
            this.cbCarModel.Location = new System.Drawing.Point(14, 175);
            this.cbCarModel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbCarModel.Name = "cbCarModel";
            this.cbCarModel.Size = new System.Drawing.Size(307, 26);
            this.cbCarModel.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(338, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date of Birth";
            // 
            // dtpAge
            // 
            this.dtpAge.CalendarFont = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAge.Location = new System.Drawing.Point(331, 76);
            this.dtpAge.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtpAge.MaxDate = new System.DateTime(2022, 12, 23, 0, 0, 0, 0);
            this.dtpAge.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtpAge.Name = "dtpAge";
            this.dtpAge.Size = new System.Drawing.Size(323, 22);
            this.dtpAge.TabIndex = 14;
            this.dtpAge.Value = new System.DateTime(2022, 12, 23, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calisto MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 219);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Rent Date";
            // 
            // bCancelRent
            // 
            this.bCancelRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelRent.Location = new System.Drawing.Point(14, 458);
            this.bCancelRent.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bCancelRent.Name = "bCancelRent";
            this.bCancelRent.Size = new System.Drawing.Size(106, 26);
            this.bCancelRent.TabIndex = 17;
            this.bCancelRent.Text = "Cancel";
            this.bCancelRent.UseVisualStyleBackColor = true;
            this.bCancelRent.Click += new System.EventHandler(this.bCancelRent_Click);
            // 
            // lbRecordId
            // 
            this.lbRecordId.AutoSize = true;
            this.lbRecordId.Font = new System.Drawing.Font("Calisto MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordId.Location = new System.Drawing.Point(777, 9);
            this.lbRecordId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbRecordId.Name = "lbRecordId";
            this.lbRecordId.Size = new System.Drawing.Size(0, 22);
            this.lbRecordId.TabIndex = 18;
            this.lbRecordId.Visible = false;
            // 
            // EditRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.lbRecordId);
            this.Controls.Add(this.bCancelRent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpAge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCarModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTypeCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpReturned);
            this.Controls.Add(this.dtpRented);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "EditRentalRecord";
            this.Text = "Rental Record";
            this.Load += new System.EventHandler(this.EditRentalRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpRented;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTypeCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.DateTimePicker dtpReturned;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCarModel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpAge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bCancelRent;
        private System.Windows.Forms.Label lbRecordId;
    }
}

