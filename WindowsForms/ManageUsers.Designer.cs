namespace WindowsForms
{
    partial class ManageUsers
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
            this.bExitUsers = new System.Windows.Forms.Button();
            this.lbManageUsers = new System.Windows.Forms.Label();
            this.bDeactivateUser = new System.Windows.Forms.Button();
            this.bResetPassword = new System.Windows.Forms.Button();
            this.bAddNewUser = new System.Windows.Forms.Button();
            this.dgvUsersList = new System.Windows.Forms.DataGridView();
            this.bRefreshUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.SuspendLayout();
            // 
            // bExitUsers
            // 
            this.bExitUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExitUsers.Location = new System.Drawing.Point(1057, 744);
            this.bExitUsers.Name = "bExitUsers";
            this.bExitUsers.Size = new System.Drawing.Size(115, 30);
            this.bExitUsers.TabIndex = 25;
            this.bExitUsers.Text = "Exit";
            this.bExitUsers.UseVisualStyleBackColor = true;
            this.bExitUsers.Click += new System.EventHandler(this.bExitUsers_Click);
            // 
            // lbManageUsers
            // 
            this.lbManageUsers.AutoSize = true;
            this.lbManageUsers.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManageUsers.Location = new System.Drawing.Point(14, 9);
            this.lbManageUsers.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbManageUsers.Name = "lbManageUsers";
            this.lbManageUsers.Size = new System.Drawing.Size(107, 19);
            this.lbManageUsers.TabIndex = 24;
            this.lbManageUsers.Text = "Manage Users";
            // 
            // bDeactivateUser
            // 
            this.bDeactivateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeactivateUser.Location = new System.Drawing.Point(1057, 102);
            this.bDeactivateUser.Name = "bDeactivateUser";
            this.bDeactivateUser.Size = new System.Drawing.Size(115, 30);
            this.bDeactivateUser.TabIndex = 23;
            this.bDeactivateUser.Text = "Reset User";
            this.bDeactivateUser.UseVisualStyleBackColor = true;
            this.bDeactivateUser.Click += new System.EventHandler(this.bDeactivateUser_Click);
            // 
            // bResetPassword
            // 
            this.bResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bResetPassword.Location = new System.Drawing.Point(1057, 66);
            this.bResetPassword.Name = "bResetPassword";
            this.bResetPassword.Size = new System.Drawing.Size(115, 30);
            this.bResetPassword.TabIndex = 22;
            this.bResetPassword.Text = "Reset Password";
            this.bResetPassword.UseVisualStyleBackColor = true;
            this.bResetPassword.Click += new System.EventHandler(this.bResetPassword_Click);
            // 
            // bAddNewUser
            // 
            this.bAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddNewUser.Location = new System.Drawing.Point(1057, 30);
            this.bAddNewUser.Name = "bAddNewUser";
            this.bAddNewUser.Size = new System.Drawing.Size(115, 30);
            this.bAddNewUser.TabIndex = 21;
            this.bAddNewUser.Text = "Add New User";
            this.bAddNewUser.UseVisualStyleBackColor = true;
            this.bAddNewUser.Click += new System.EventHandler(this.bAddNewUser_Click);
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersList.Location = new System.Drawing.Point(20, 31);
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.Size = new System.Drawing.Size(1031, 743);
            this.dgvUsersList.TabIndex = 20;
            // 
            // bRefreshUsers
            // 
            this.bRefreshUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRefreshUsers.Location = new System.Drawing.Point(1057, 138);
            this.bRefreshUsers.Name = "bRefreshUsers";
            this.bRefreshUsers.Size = new System.Drawing.Size(115, 30);
            this.bRefreshUsers.TabIndex = 26;
            this.bRefreshUsers.Text = "Refresh";
            this.bRefreshUsers.UseVisualStyleBackColor = true;
            this.bRefreshUsers.Click += new System.EventHandler(this.bRefreshUsers_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 786);
            this.Controls.Add(this.bRefreshUsers);
            this.Controls.Add(this.bExitUsers);
            this.Controls.Add(this.lbManageUsers);
            this.Controls.Add(this.bDeactivateUser);
            this.Controls.Add(this.bResetPassword);
            this.Controls.Add(this.bAddNewUser);
            this.Controls.Add(this.dgvUsersList);
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bExitUsers;
        private System.Windows.Forms.Label lbManageUsers;
        private System.Windows.Forms.Button bDeactivateUser;
        private System.Windows.Forms.Button bResetPassword;
        private System.Windows.Forms.Button bAddNewUser;
        private System.Windows.Forms.DataGridView dgvUsersList;
        private System.Windows.Forms.Button bRefreshUsers;
    }
}