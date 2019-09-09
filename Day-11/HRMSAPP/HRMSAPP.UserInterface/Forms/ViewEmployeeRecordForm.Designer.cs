namespace HRMSAPP.UserInterface.Forms
{
    partial class ViewEmployeeRecordForm
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
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.groupBoxEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.btnOk);
            this.groupBoxEmployee.Controls.Add(this.txtDepartment);
            this.groupBoxEmployee.Controls.Add(this.lblDepartment);
            this.groupBoxEmployee.Controls.Add(this.txtLocation);
            this.groupBoxEmployee.Controls.Add(this.lblLocation);
            this.groupBoxEmployee.Controls.Add(this.txtSalary);
            this.groupBoxEmployee.Controls.Add(this.lblSalary);
            this.groupBoxEmployee.Controls.Add(this.txtName);
            this.groupBoxEmployee.Controls.Add(this.lblName);
            this.groupBoxEmployee.Controls.Add(this.txtId);
            this.groupBoxEmployee.Controls.Add(this.lblId);
            this.groupBoxEmployee.Location = new System.Drawing.Point(143, 57);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(573, 372);
            this.groupBoxEmployee.TabIndex = 0;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "RECORD OF";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(234, 316);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(98, 50);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(169, 263);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(323, 22);
            this.txtDepartment.TabIndex = 9;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(46, 263);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(107, 17);
            this.lblDepartment.TabIndex = 8;
            this.lblDepartment.Text = "DEPARTMENT:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(169, 211);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(323, 22);
            this.txtLocation.TabIndex = 7;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(46, 211);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(82, 17);
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "LOCATION:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(169, 161);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(323, 22);
            this.txtSalary.TabIndex = 5;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(46, 161);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(66, 17);
            this.lblSalary.TabIndex = 4;
            this.lblSalary.Text = "SALARY:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(169, 106);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(323, 22);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(46, 106);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "NAME:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(169, 54);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(323, 22);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(46, 54);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 17);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID: ";
            // 
            // ViewEmployeeRecordFomr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 502);
            this.Controls.Add(this.groupBoxEmployee);
            this.Name = "ViewEmployeeRecordFomr";
            this.Text = "ViewEmployeeRecordForm";
            this.Load += new System.EventHandler(this.ViewEmployeeRecord_Load);
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Button btnOk;
    }
}