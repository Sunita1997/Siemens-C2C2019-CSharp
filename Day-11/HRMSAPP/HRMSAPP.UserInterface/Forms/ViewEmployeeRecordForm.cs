using HRMSAPP.Entities;
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
    public partial class ViewEmployeeRecordForm : Form
    {
        private Employee employee;
        public ViewEmployeeRecordForm()
        {
            InitializeComponent();
        }
        public ViewEmployeeRecordForm(Employee employee) : this()
        {
            this.employee = employee;
        }

        private void ViewEmployeeRecord_Load(object sender, EventArgs e)
        {
            if (employee != null)
            {
                groupBoxEmployee.Text += " " + employee.EmployeeName.ToUpper();
                txtId.Text = employee.EmployeeId.ToString();
                txtName.Text = employee.EmployeeName;
                txtSalary.Text = employee.EmployeeSalary.ToString();
                txtLocation.Text = employee.EmployeeLocation;
                txtDepartment.Text = employee.DepartmentInfo.DepartmentName;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            ReloadRecordsForm();
        }
        private void ReloadRecordsForm()
        {
            try
            {
                if (this.MdiParent != null)
                {
                    IEnumerable<Form> forms = this.MdiParent.MdiChildren;
                    Reload(forms);
                }
                else
                {
                    HRMSMenuForm form = Application.OpenForms[nameof(HRMSMenuForm)] as HRMSMenuForm;
                    IEnumerable<Form> forms = form.MdiChildren;
                    Reload(forms);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Reload(IEnumerable<Form> forms)
        {
            try
            {
                var formList = forms.Where(f => f.Name == nameof(EmployeeRecordsForm));
                if (formList != null && formList.Count() > 0)
                {
                    EmployeeRecordsForm recordsForm = formList.First() as EmployeeRecordsForm;
                    recordsForm.Visible = true;
                    recordsForm.LoadEmployees();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
