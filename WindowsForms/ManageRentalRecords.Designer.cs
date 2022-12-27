namespace WindowsForms
{
    partial class ManageRentalRecords
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
            this.label1 = new System.Windows.Forms.Label();
            this.bExitRecords = new System.Windows.Forms.Button();
            this.lbManageRentalRecords = new System.Windows.Forms.Label();
            this.bDeleteRecord = new System.Windows.Forms.Button();
            this.bEditRecord = new System.Windows.Forms.Button();
            this.bAddRecord = new System.Windows.Forms.Button();
            this.dgvRentalRecordList = new System.Windows.Forms.DataGridView();
            this.bRefreshRecords = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalRecordList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-8, -22);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Manage Vehicle List";
            // 
            // bExitRecords
            // 
            this.bExitRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExitRecords.Location = new System.Drawing.Point(1057, 744);
            this.bExitRecords.Name = "bExitRecords";
            this.bExitRecords.Size = new System.Drawing.Size(115, 30);
            this.bExitRecords.TabIndex = 19;
            this.bExitRecords.Text = "Exit";
            this.bExitRecords.UseVisualStyleBackColor = true;
            this.bExitRecords.Click += new System.EventHandler(this.bExitRecords_Click);
            // 
            // lbManageRentalRecords
            // 
            this.lbManageRentalRecords.AutoSize = true;
            this.lbManageRentalRecords.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManageRentalRecords.Location = new System.Drawing.Point(14, 9);
            this.lbManageRentalRecords.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbManageRentalRecords.Name = "lbManageRentalRecords";
            this.lbManageRentalRecords.Size = new System.Drawing.Size(174, 19);
            this.lbManageRentalRecords.TabIndex = 17;
            this.lbManageRentalRecords.Text = "Manage Rental Records";
            // 
            // bDeleteRecord
            // 
            this.bDeleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeleteRecord.Location = new System.Drawing.Point(1057, 103);
            this.bDeleteRecord.Name = "bDeleteRecord";
            this.bDeleteRecord.Size = new System.Drawing.Size(115, 30);
            this.bDeleteRecord.TabIndex = 16;
            this.bDeleteRecord.Text = "Delete Record";
            this.bDeleteRecord.UseVisualStyleBackColor = true;
            this.bDeleteRecord.Click += new System.EventHandler(this.bDeleteRecord_Click);
            // 
            // bEditRecord
            // 
            this.bEditRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditRecord.Location = new System.Drawing.Point(1057, 67);
            this.bEditRecord.Name = "bEditRecord";
            this.bEditRecord.Size = new System.Drawing.Size(115, 30);
            this.bEditRecord.TabIndex = 15;
            this.bEditRecord.Text = "Edit Record";
            this.bEditRecord.UseVisualStyleBackColor = true;
            this.bEditRecord.Click += new System.EventHandler(this.bEditRecord_Click);
            // 
            // bAddRecord
            // 
            this.bAddRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddRecord.Location = new System.Drawing.Point(1057, 31);
            this.bAddRecord.Name = "bAddRecord";
            this.bAddRecord.Size = new System.Drawing.Size(115, 30);
            this.bAddRecord.TabIndex = 14;
            this.bAddRecord.Text = "Add Record";
            this.bAddRecord.UseVisualStyleBackColor = true;
            this.bAddRecord.Click += new System.EventHandler(this.bAddRecord_Click);
            // 
            // dgvRentalRecordList
            // 
            this.dgvRentalRecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalRecordList.Location = new System.Drawing.Point(20, 31);
            this.dgvRentalRecordList.Name = "dgvRentalRecordList";
            this.dgvRentalRecordList.Size = new System.Drawing.Size(1031, 743);
            this.dgvRentalRecordList.TabIndex = 13;
            // 
            // bRefreshRecords
            // 
            this.bRefreshRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRefreshRecords.Location = new System.Drawing.Point(1057, 139);
            this.bRefreshRecords.Name = "bRefreshRecords";
            this.bRefreshRecords.Size = new System.Drawing.Size(115, 30);
            this.bRefreshRecords.TabIndex = 27;
            this.bRefreshRecords.Text = "Refresh";
            this.bRefreshRecords.UseVisualStyleBackColor = true;
            this.bRefreshRecords.Click += new System.EventHandler(this.bRefreshRecords_Click);
            // 
            // ManageRentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 786);
            this.Controls.Add(this.bRefreshRecords);
            this.Controls.Add(this.bExitRecords);
            this.Controls.Add(this.lbManageRentalRecords);
            this.Controls.Add(this.bDeleteRecord);
            this.Controls.Add(this.bEditRecord);
            this.Controls.Add(this.bAddRecord);
            this.Controls.Add(this.dgvRentalRecordList);
            this.Controls.Add(this.label1);
            this.Name = "ManageRentalRecords";
            this.Text = "Manage Rental Records";
            this.Load += new System.EventHandler(this.ManageRentalRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalRecordList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bExitRecords;
        private System.Windows.Forms.Label lbManageRentalRecords;
        private System.Windows.Forms.Button bDeleteRecord;
        private System.Windows.Forms.Button bEditRecord;
        private System.Windows.Forms.Button bAddRecord;
        private System.Windows.Forms.DataGridView dgvRentalRecordList;
        private System.Windows.Forms.Button bRefreshRecords;
    }
}