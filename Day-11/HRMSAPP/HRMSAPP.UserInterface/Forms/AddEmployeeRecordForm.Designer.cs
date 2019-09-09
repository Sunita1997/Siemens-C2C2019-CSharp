namespace HRMSAPP.UserInterface.Forms
{
    partial class AddEmployeeRecordForm
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
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.lblSelectDepartment = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBoxEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.comboBoxDepartment);
            this.groupBoxEmployee.Controls.Add(this.lblSelectDepartment);
            this.groupBoxEmployee.Controls.Add(this.btnAdd);
            this.groupBoxEmployee.Controls.Add(this.txtLocation);
            this.groupBoxEmployee.Controls.Add(this.lblLocation);
            this.groupBoxEmployee.Controls.Add(this.txtSalary);
            this.groupBoxEmployee.Controls.Add(this.lblSalary);
            this.groupBoxEmployee.Controls.Add(this.txtName);
            this.groupBoxEmployee.Controls.Add(this.lblName);
            this.groupBoxEmployee.Location = new System.Drawing.Point(63, 25);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(619, 420);
            this.groupBoxEmployee.TabIndex = 2;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "RECORD OF";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(264, 276);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(228, 24);
            this.comboBoxDepartment.TabIndex = 13;
            // 
            // lblSelectDepartment
            // 
            this.lblSelectDepartment.AutoSize = true;
            this.lblSelectDepartment.Location = new System.Drawing.Point(46, 276);
            this.lblSelectDepartment.Name = "lblSelectDepartment";
            this.lblSelectDepartment.Size = new System.Drawing.Size(200, 17);
            this.lblSelectDepartment.TabIndex = 12;
            this.lblSelectDepartment.Text = "SELECT NEW DEPARTMENT:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(169, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 50);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(169, 211);
            this.txtLocation.Name = "txtLocation";
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
            // AddEmployeeRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 530);
            this.Controls.Add(this.groupBoxEmployee);
            this.Name = "AddEmployeeRecordForm";
            this.Text = "AddEmployeeRecord";
            this.Load += new System.EventHandler(this.AddEmployeeRecordForm_Load);
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label lblSelectDepartment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}