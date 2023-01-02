namespace WindowsForms
{
    partial class ManageRoles
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
            this.bRefreshVehicles = new System.Windows.Forms.Button();
            this.bExitRolesList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bDeleteRole = new System.Windows.Forms.Button();
            this.bAddRole = new System.Windows.Forms.Button();
            this.dgvRolesList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesList)).BeginInit();
            this.SuspendLayout();
            // 
            // bRefreshVehicles
            // 
            this.bRefreshVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRefreshVehicles.Location = new System.Drawing.Point(281, 117);
            this.bRefreshVehicles.Name = "bRefreshVehicles";
            this.bRefreshVehicles.Size = new System.Drawing.Size(115, 30);
            this.bRefreshVehicles.TabIndex = 34;
            this.bRefreshVehicles.Text = "Refresh";
            this.bRefreshVehicles.UseVisualStyleBackColor = true;
            // 
            // bExitRolesList
            // 
            this.bExitRolesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExitRolesList.Location = new System.Drawing.Point(281, 685);
            this.bExitRolesList.Name = "bExitRolesList";
            this.bExitRolesList.Size = new System.Drawing.Size(115, 30);
            this.bExitRolesList.TabIndex = 33;
            this.bExitRolesList.Text = "Exit";
            this.bExitRolesList.UseVisualStyleBackColor = true;
            this.bExitRolesList.Click += new System.EventHandler(this.bExitRolesList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Manage Roles List";
            // 
            // bDeleteRole
            // 
            this.bDeleteRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeleteRole.Location = new System.Drawing.Point(281, 81);
            this.bDeleteRole.Name = "bDeleteRole";
            this.bDeleteRole.Size = new System.Drawing.Size(115, 30);
            this.bDeleteRole.TabIndex = 31;
            this.bDeleteRole.Text = "Delete Role";
            this.bDeleteRole.UseVisualStyleBackColor = true;
            this.bDeleteRole.Click += new System.EventHandler(this.bDeleteRole_Click);
            // 
            // bAddRole
            // 
            this.bAddRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddRole.Location = new System.Drawing.Point(281, 45);
            this.bAddRole.Name = "bAddRole";
            this.bAddRole.Size = new System.Drawing.Size(115, 30);
            this.bAddRole.TabIndex = 29;
            this.bAddRole.Text = "Add Role";
            this.bAddRole.UseVisualStyleBackColor = true;
            this.bAddRole.Click += new System.EventHandler(this.bAddRole_Click);
            // 
            // dgvRolesList
            // 
            this.dgvRolesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRolesList.Location = new System.Drawing.Point(18, 45);
            this.dgvRolesList.Name = "dgvRolesList";
            this.dgvRolesList.Size = new System.Drawing.Size(257, 670);
            this.dgvRolesList.TabIndex = 28;
            // 
            // ManageRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 736);
            this.Controls.Add(this.bRefreshVehicles);
            this.Controls.Add(this.bExitRolesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bDeleteRole);
            this.Controls.Add(this.bAddRole);
            this.Controls.Add(this.dgvRolesList);
            this.Name = "ManageRoles";
            this.Text = "Manage Roles";
            this.Load += new System.EventHandler(this.ManageRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRefreshVehicles;
        private System.Windows.Forms.Button bExitRolesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bDeleteRole;
        private System.Windows.Forms.Button bAddRole;
        private System.Windows.Forms.DataGridView dgvRolesList;
    }
}