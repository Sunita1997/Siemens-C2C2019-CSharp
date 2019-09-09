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
    public partial class AddEmployeeRecordForm : Form
    {
        IDepartmentBusinessComponent departmentBusinessComponent;
        IEmployeeBusinessComponent employeeBusinessComponent;
        public AddEmployeeRecordForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxDepartment.SelectedItem != null)
                {
                    if (MessageBox.Show("Sure to add?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        employeeBusinessComponent
                            = new EmployeeBusinessComponent();
                        int result = employeeBusinessComponent.AddNewEmployee(
                            new Employee
                            {
                                EmployeeName = txtName.Text,
                                EmployeeLocation = txtLocation.Text,
                                EmployeeSalary = decimal.Parse(txtSalary.Text),
                                DepartmentId = (comboBoxDepartment.SelectedItem as Department).DepartmentId
                            });

                        if (result > 0)
                        {
                            MessageBox.Show($"{result} record added successfully");
                        }
                        else
                            MessageBox.Show($"record couldn't be added successfully");
                        
                    }
                    else
                        MessageBox.Show("operation cancelled");

                    ReloadRecordsForm();
                }
                else
                    MessageBox.Show("select department name");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddEmployeeRecordForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDepartments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void LoadDepartments()
        {
            try
            {
                departmentBusinessComponent = new DepartmentBusinessComponent();
                var departments = departmentBusinessComponent.FetchDepartments();
                if (departments != null && departments.Count > 0)
                {
                    comboBoxDepartment.DataSource = departments;
                    comboBoxDepartment.DisplayMember = "DepartmentName";
                }
                else
                    MessageBox.Show("no department records found");
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
                }
                else
                {
                    EmployeeRecordsForm form = new EmployeeRecordsForm();
                    form.Show();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
