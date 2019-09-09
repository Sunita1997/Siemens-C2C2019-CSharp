using HRMSAPP.BusinessLayer.Contract;
using HRMSAPP.BusinessLayer.Implementation;
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
    public partial class UpdateEmployeeRecordForm : Form
    {
        private Employee employee;
        private IEmployeeBusinessComponent employeeBusinessComponent;
        private IDepartmentBusinessComponent departmentBusinessComponent;

        public UpdateEmployeeRecordForm()
        {
            InitializeComponent();
        }
        public UpdateEmployeeRecordForm(Employee employee) : this()
        {
            this.employee = employee;
        }

        private void UpdateEmployeeRecordForm_Load(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            comboBoxDepartment.Enabled = true;

            try
            {
                departmentBusinessComponent = new DepartmentBusinessComponent();
                var allDepartments = departmentBusinessComponent.FetchDepartments();
                comboBoxDepartment.DataSource
                    = allDepartments
                    .Where(d => !d.DepartmentName.Equals(employee.DepartmentInfo.DepartmentName))
                    .ToList<Department>();
                comboBoxDepartment.DisplayMember = "DepartmentName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ComboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                employee.DepartmentInfo.DepartmentName = (comboBoxDepartment.SelectedItem as Department).DepartmentName;
                txtDepartment.Text = employee.DepartmentInfo.DepartmentName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = comboBoxDepartment.SelectedItem;
                employeeBusinessComponent = new EmployeeBusinessComponent();
                int result = employeeBusinessComponent
                    .UpdateEmployee(new Employee
                    {
                        EmployeeId = int.Parse(txtId.Text),
                        EmployeeName = txtName.Text,
                        EmployeeSalary = decimal.Parse(txtSalary.Text),
                        EmployeeLocation = txtLocation.Text,
                        DepartmentId = comboBoxDepartment.SelectedItem != null ? (comboBoxDepartment.SelectedItem as Department).DepartmentId : employee.DepartmentId
                    });

                MessageBox.Show(result > 0 ? $"{result} updated successfully" : "record updation failed");

                ReloadRecordsForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
