namespace HRMSAPP.UserInterface.Forms
{
    partial class HRMSMenuForm
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
            this.menuStripEmployeeOperations = new System.Windows.Forms.MenuStrip();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeesSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripEmployeeOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripEmployeeOperations
            // 
            this.menuStripEmployeeOperations.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripEmployeeOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsToolStripMenuItem});
            this.menuStripEmployeeOperations.Location = new System.Drawing.Point(0, 0);
            this.menuStripEmployeeOperations.Name = "menuStripEmployeeOperations";
            this.menuStripEmployeeOperations.Size = new System.Drawing.Size(1077, 28);
            this.menuStripEmployeeOperations.TabIndex = 1;
            this.menuStripEmployeeOperations.Text = "Employee Operations";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployeesSubMenu,
            this.addEmployeeSubMenu,
            this.toolStripSeparator1,
            this.exitSubMenu});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.operationsToolStripMenuItem.Text = "&Operations";
            // 
            // viewEmployeesSubMenu
            // 
            this.viewEmployeesSubMenu.Name = "viewEmployeesSubMenu";
            this.viewEmployeesSubMenu.Size = new System.Drawing.Size(224, 26);
            this.viewEmployeesSubMenu.Text = "View Employees";
            this.viewEmployeesSubMenu.Click += new System.EventHandler(this.ViewEmployeesSubMenu_Click);
            // 
            // addEmployeeSubMenu
            // 
            this.addEmployeeSubMenu.Name = "addEmployeeSubMenu";
            this.addEmployeeSubMenu.Size = new System.Drawing.Size(224, 26);
            this.addEmployeeSubMenu.Text = "Add Employee";
            this.addEmployeeSubMenu.Click += new System.EventHandler(this.AddEmployeeSubMenu_Click);
            // 
            // exitSubMenu
            // 
            this.exitSubMenu.Name = "exitSubMenu";
            this.exitSubMenu.Size = new System.Drawing.Size(224, 26);
            this.exitSubMenu.Text = "Exit";
            this.exitSubMenu.Click += new System.EventHandler(this.ExitSubMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // HRMSMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 548);
            this.Controls.Add(this.menuStripEmployeeOperations);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripEmployeeOperations;
            this.Name = "HRMSMenuForm";
            this.Text = "HRMSMenuForm";
            this.menuStripEmployeeOperations.ResumeLayout(false);
            this.menuStripEmployeeOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripEmployeeOperations;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeesSubMenu;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeSubMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitSubMenu;
    }
}