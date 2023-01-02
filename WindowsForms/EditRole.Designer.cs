namespace WindowsForms
{
    partial class EditRole
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
            this.bCancelRole = new System.Windows.Forms.Button();
            this.bEditRole = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbRoleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRoles = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCancelRole
            // 
            this.bCancelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelRole.Location = new System.Drawing.Point(357, 96);
            this.bCancelRole.Name = "bCancelRole";
            this.bCancelRole.Size = new System.Drawing.Size(115, 28);
            this.bCancelRole.TabIndex = 25;
            this.bCancelRole.Text = "Cancel";
            this.bCancelRole.UseVisualStyleBackColor = true;
            this.bCancelRole.Click += new System.EventHandler(this.bCancelRole_Click);
            // 
            // bEditRole
            // 
            this.bEditRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditRole.Location = new System.Drawing.Point(12, 96);
            this.bEditRole.Name = "bEditRole";
            this.bEditRole.Size = new System.Drawing.Size(115, 28);
            this.bEditRole.TabIndex = 24;
            this.bEditRole.Text = "Save";
            this.bEditRole.UseVisualStyleBackColor = true;
            this.bEditRole.Click += new System.EventHandler(this.bEditRole_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tbRoleName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 41);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(460, 40);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // tbRoleName
            // 
            this.tbRoleName.Location = new System.Drawing.Point(233, 3);
            this.tbRoleName.Name = "tbRoleName";
            this.tbRoleName.Size = new System.Drawing.Size(219, 20);
            this.tbRoleName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Role";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRoles
            // 
            this.lbRoles.AutoSize = true;
            this.lbRoles.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.lbRoles.Location = new System.Drawing.Point(14, 9);
            this.lbRoles.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbRoles.Name = "lbRoles";
            this.lbRoles.Size = new System.Drawing.Size(0, 19);
            this.lbRoles.TabIndex = 22;
            // 
            // EditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 136);
            this.Controls.Add(this.bCancelRole);
            this.Controls.Add(this.bEditRole);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lbRoles);
            this.Name = "EditRole";
            this.Text = "Edit Role";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelRole;
        private System.Windows.Forms.Button bEditRole;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRoles;
        private System.Windows.Forms.TextBox tbRoleName;
    }
}