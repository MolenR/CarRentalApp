namespace WindowsForms
{
    partial class EditVehicle
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbYearVehicle = new System.Windows.Forms.TextBox();
            this.tbLicenseVehicle = new System.Windows.Forms.TextBox();
            this.tbVINVehicle = new System.Windows.Forms.TextBox();
            this.tbModelVehicle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMakeVehicle = new System.Windows.Forms.TextBox();
            this.bCancelEdit = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.lbTitleVehicle = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbYearVehicle, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbLicenseVehicle, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbVINVehicle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbModelVehicle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbMakeVehicle, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1073, 352);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbYearVehicle
            // 
            this.tbYearVehicle.Location = new System.Drawing.Point(539, 283);
            this.tbYearVehicle.Name = "tbYearVehicle";
            this.tbYearVehicle.Size = new System.Drawing.Size(531, 20);
            this.tbYearVehicle.TabIndex = 9;
            // 
            // tbLicenseVehicle
            // 
            this.tbLicenseVehicle.Location = new System.Drawing.Point(539, 213);
            this.tbLicenseVehicle.Name = "tbLicenseVehicle";
            this.tbLicenseVehicle.Size = new System.Drawing.Size(531, 20);
            this.tbLicenseVehicle.TabIndex = 8;
            // 
            // tbVINVehicle
            // 
            this.tbVINVehicle.Location = new System.Drawing.Point(539, 143);
            this.tbVINVehicle.Name = "tbVINVehicle";
            this.tbVINVehicle.Size = new System.Drawing.Size(531, 20);
            this.tbVINVehicle.TabIndex = 7;
            // 
            // tbModelVehicle
            // 
            this.tbModelVehicle.Location = new System.Drawing.Point(539, 73);
            this.tbModelVehicle.Name = "tbModelVehicle";
            this.tbModelVehicle.Size = new System.Drawing.Size(531, 20);
            this.tbModelVehicle.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "VIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "License";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Year";
            // 
            // tbMakeVehicle
            // 
            this.tbMakeVehicle.Location = new System.Drawing.Point(539, 3);
            this.tbMakeVehicle.Name = "tbMakeVehicle";
            this.tbMakeVehicle.Size = new System.Drawing.Size(531, 20);
            this.tbMakeVehicle.TabIndex = 5;
            // 
            // bCancelEdit
            // 
            this.bCancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelEdit.Location = new System.Drawing.Point(12, 404);
            this.bCancelEdit.Name = "bCancelEdit";
            this.bCancelEdit.Size = new System.Drawing.Size(115, 28);
            this.bCancelEdit.TabIndex = 1;
            this.bCancelEdit.Text = "Cancel";
            this.bCancelEdit.UseVisualStyleBackColor = true;
            this.bCancelEdit.Click += new System.EventHandler(this.bCancelEdit_Click);
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Location = new System.Drawing.Point(970, 404);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(115, 28);
            this.bSave.TabIndex = 2;
            this.bSave.Text = "Save Edit";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // lbTitleVehicle
            // 
            this.lbTitleVehicle.AutoSize = true;
            this.lbTitleVehicle.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleVehicle.Location = new System.Drawing.Point(14, 9);
            this.lbTitleVehicle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitleVehicle.Name = "lbTitleVehicle";
            this.lbTitleVehicle.Size = new System.Drawing.Size(0, 19);
            this.lbTitleVehicle.TabIndex = 6;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(551, 9);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 13);
            this.lbID.TabIndex = 7;
            this.lbID.Visible = false;
            // 
            // AddEditVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 511);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbTitleVehicle);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bCancelEdit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditVehicle";
            this.Text = "Edit";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bCancelEdit;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lbTitleVehicle;
        private System.Windows.Forms.TextBox tbYearVehicle;
        private System.Windows.Forms.TextBox tbLicenseVehicle;
        private System.Windows.Forms.TextBox tbVINVehicle;
        private System.Windows.Forms.TextBox tbModelVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMakeVehicle;
        private System.Windows.Forms.Label lbID;
    }
}