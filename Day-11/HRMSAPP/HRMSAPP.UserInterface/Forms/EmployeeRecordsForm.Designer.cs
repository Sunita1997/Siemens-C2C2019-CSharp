namespace HRMSAPP.UserInterface.Forms
{
    partial class EmployeeRecordsForm
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
            this.panelDepartments = new System.Windows.Forms.Panel();
            this.comboBoxDepartments = new System.Windows.Forms.ComboBox();
            this.lblDepartments = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.columnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.columnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.columnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDepartments
            // 
            this.panelDepartments.Controls.Add(this.comboBoxDepartments);
            this.panelDepartments.Controls.Add(this.lblDepartments);
            this.panelDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDepartments.Location = new System.Drawing.Point(52, 35);
            this.panelDepartments.Name = "panelDepartments";
            this.panelDepartments.Size = new System.Drawing.Size(801, 75);
            this.panelDepartments.TabIndex = 0;
            // 
            // comboBoxDepartments
            // 
            this.comboBoxDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDepartments.FormattingEnabled = true;
            this.comboBoxDepartments.Location = new System.Drawing.Point(371, 22);
            this.comboBoxDepartments.Name = "comboBoxDepartments";
            this.comboBoxDepartments.Size = new System.Drawing.Size(370, 28);
            this.comboBoxDepartments.TabIndex = 1;
            this.comboBoxDepartments.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDepartments_SelectedIndexChanged);
            // 
            // lblDepartments
            // 
            this.lblDepartments.AutoSize = true;
            this.lblDepartments.Location = new System.Drawing.Point(28, 22);
            this.lblDepartments.Name = "lblDepartments";
            this.lblDepartments.Size = new System.Drawing.Size(194, 20);
            this.lblDepartments.TabIndex = 0;
            this.lblDepartments.Text = "Select a Department: ";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnName,
            this.columnSalary,
            this.columnLocation,
            this.columnSelect,
            this.columnUpdate,
            this.columnDelete});
            this.dgvEmployees.Location = new System.Drawing.Point(52, 141);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(1090, 280);
            this.dgvEmployees.TabIndex = 1;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmployees_CellContentClick);
            // 
            // columnId
            // 
            this.columnId.DataPropertyName = "EmployeeId";
            this.columnId.HeaderText = "ID";
            this.columnId.MinimumWidth = 6;
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            this.columnId.Width = 125;
            // 
            // columnName
            // 
            this.columnName.DataPropertyName = "EmployeeName";
            this.columnName.HeaderText = "NAME";
            this.columnName.MinimumWidth = 6;
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            this.columnName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnName.Width = 125;
            // 
            // columnSalary
            // 
            this.columnSalary.DataPropertyName = "EmployeeSalary";
            this.columnSalary.HeaderText = "SALARY";
            this.columnSalary.MinimumWidth = 6;
            this.columnSalary.Name = "columnSalary";
            this.columnSalary.ReadOnly = true;
            this.columnSalary.Width = 125;
            // 
            // columnLocation
            // 
            this.columnLocation.DataPropertyName = "EmployeeLocation";
            this.columnLocation.HeaderText = "LOCATION";
            this.columnLocation.MinimumWidth = 6;
            this.columnLocation.Name = "columnLocation";
            this.columnLocation.ReadOnly = true;
            this.columnLocation.Width = 125;
            // 
            // columnSelect
            // 
            this.columnSelect.HeaderText = "SELECT";
            this.columnSelect.MinimumWidth = 6;
            this.columnSelect.Name = "columnSelect";
            this.columnSelect.ReadOnly = true;
            this.columnSelect.Text = "Select";
            this.columnSelect.UseColumnTextForButtonValue = true;
            this.columnSelect.Width = 125;
            // 
            // columnUpdate
            // 
            this.columnUpdate.HeaderText = "UPDATE";
            this.columnUpdate.MinimumWidth = 6;
            this.columnUpdate.Name = "columnUpdate";
            this.columnUpdate.ReadOnly = true;
            this.columnUpdate.Text = "Update Record";
            this.columnUpdate.UseColumnTextForButtonValue = true;
            this.columnUpdate.Width = 125;
            // 
            // columnDelete
            // 
            this.columnDelete.HeaderText = "DELETE";
            this.columnDelete.MinimumWidth = 6;
            this.columnDelete.Name = "columnDelete";
            this.columnDelete.ReadOnly = true;
            this.columnDelete.Text = "Delete Record";
            this.columnDelete.UseColumnTextForButtonValue = true;
            this.columnDelete.Width = 125;
            // 
            // EmployeeRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 566);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.panelDepartments);
            this.Name = "EmployeeRecordsForm";
            this.Text = "EmployeeRecordsForm";
            this.Load += new System.EventHandler(this.EmployeeRecordsForm_Load);
            this.panelDepartments.ResumeLayout(false);
            this.panelDepartments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDepartments;
        private System.Windows.Forms.ComboBox comboBoxDepartments;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewLinkColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLocation;
        private System.Windows.Forms.DataGridViewButtonColumn columnSelect;
        private System.Windows.Forms.DataGridViewButtonColumn columnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn columnDelete;
    }
}