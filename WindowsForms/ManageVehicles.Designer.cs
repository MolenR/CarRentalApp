namespace WindowsForms
{
    partial class ManageVehicles
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
            this.dgvVehicleList = new System.Windows.Forms.DataGridView();
            this.bAddVehicle = new System.Windows.Forms.Button();
            this.bEditVehicle = new System.Windows.Forms.Button();
            this.bDeleteVehicle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bExitVehicleList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehicleList
            // 
            this.dgvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleList.Location = new System.Drawing.Point(20, 31);
            this.dgvVehicleList.Name = "dgvVehicleList";
            this.dgvVehicleList.Size = new System.Drawing.Size(1035, 385);
            this.dgvVehicleList.TabIndex = 0;
            // 
            // bAddVehicle
            // 
            this.bAddVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddVehicle.Location = new System.Drawing.Point(1061, 31);
            this.bAddVehicle.Name = "bAddVehicle";
            this.bAddVehicle.Size = new System.Drawing.Size(111, 29);
            this.bAddVehicle.TabIndex = 2;
            this.bAddVehicle.Text = "Add Vehicle";
            this.bAddVehicle.UseVisualStyleBackColor = true;
            this.bAddVehicle.Click += new System.EventHandler(this.bAddVehicle_Click);
            // 
            // bEditVehicle
            // 
            this.bEditVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditVehicle.Location = new System.Drawing.Point(1061, 66);
            this.bEditVehicle.Name = "bEditVehicle";
            this.bEditVehicle.Size = new System.Drawing.Size(111, 29);
            this.bEditVehicle.TabIndex = 3;
            this.bEditVehicle.Text = "Edit Vehicle";
            this.bEditVehicle.UseVisualStyleBackColor = true;
            this.bEditVehicle.Click += new System.EventHandler(this.bEditVehicle_Click);
            // 
            // bDeleteVehicle
            // 
            this.bDeleteVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeleteVehicle.Location = new System.Drawing.Point(1061, 101);
            this.bDeleteVehicle.Name = "bDeleteVehicle";
            this.bDeleteVehicle.Size = new System.Drawing.Size(111, 29);
            this.bDeleteVehicle.TabIndex = 4;
            this.bDeleteVehicle.Text = "Delete Vehicle";
            this.bDeleteVehicle.UseVisualStyleBackColor = true;
            this.bDeleteVehicle.Click += new System.EventHandler(this.bDeleteVehicle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manage Vehicle List";
            // 
            // bExitVehicleList
            // 
            this.bExitVehicleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExitVehicleList.Location = new System.Drawing.Point(1049, 744);
            this.bExitVehicleList.Name = "bExitVehicleList";
            this.bExitVehicleList.Size = new System.Drawing.Size(115, 28);
            this.bExitVehicleList.TabIndex = 7;
            this.bExitVehicleList.Text = "Exit";
            this.bExitVehicleList.UseVisualStyleBackColor = true;
            this.bExitVehicleList.Click += new System.EventHandler(this.bExitVehicleList_Click);
            // 
            // ManageVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 786);
            this.Controls.Add(this.bExitVehicleList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bDeleteVehicle);
            this.Controls.Add(this.bEditVehicle);
            this.Controls.Add(this.bAddVehicle);
            this.Controls.Add(this.dgvVehicleList);
            this.Name = "ManageVehicles";
            this.Text = "Manage Vehicles";
            this.Load += new System.EventHandler(this.ManageVehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehicleList;
        private System.Windows.Forms.Button bAddVehicle;
        private System.Windows.Forms.Button bEditVehicle;
        private System.Windows.Forms.Button bDeleteVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bExitVehicleList;
    }
}