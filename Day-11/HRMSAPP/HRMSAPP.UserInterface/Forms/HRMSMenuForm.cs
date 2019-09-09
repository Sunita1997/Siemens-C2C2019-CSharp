using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSAPP.UserInterface.Forms
{
    public partial class HRMSMenuForm : Form
    {
        public HRMSMenuForm()
        {
            InitializeComponent();
        }

        private void ViewEmployeesSubMenu_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeRecordsForm viewForm = new EmployeeRecordsForm ();
                viewForm.MdiParent = this;
                viewForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddEmployeeSubMenu_Click(object sender, EventArgs e)
        {
            try
            {
                AddEmployeeRecordForm form = new AddEmployeeRecordForm();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ExitSubMenu_Click(object sender, EventArgs e)
        {
            var forms = Application.OpenForms;
            foreach (Form item in forms)
            {
                item.Close();
            }
            Application.Exit();
        }
    }
}
