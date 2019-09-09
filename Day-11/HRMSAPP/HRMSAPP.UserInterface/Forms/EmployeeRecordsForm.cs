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
    public partial class EmployeeRecordsForm : Form
    {
        private DepartmentBusinessComponent departmentBusinessComponent;
        private EmployeeBusinessComponent employeeBusinessComponent;

        public EmployeeRecordsForm()
        {
            InitializeComponent();
        }

        private void EmployeeRecordsForm_Load(object sender, EventArgs e)
        {
            dgvEmployees.AutoGenerateColumns = false;
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
            departmentBusinessComponent = new DepartmentBusinessComponent();
            var departments = departmentBusinessComponent.FetchDepartments();
            if (departments != null && departments.Count > 0)
            {
                comboBoxDepartments.DataSource = departments;
                comboBoxDepartments.DisplayMember = "DepartmentName";
            }
            else
                MessageBox.Show("no department records found");
        }

        private void ComboBoxDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadEmployees();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void LoadEmployees()
        {
            var department = (comboBoxDepartments.SelectedItem as Department);
            var selectedId = department.DepartmentId;
            employeeBusinessComponent = new EmployeeBusinessComponent();
            var employees = employeeBusinessComponent.FetchEmployeeByDepartment(selectedId);
            dgvEmployees.DataSource = employees;
        }

       
        private void DgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRowCollection rows = dgvEmployees.Rows;
                DataGridViewRow selectedRow = rows[e.RowIndex];
                DataGridViewCellCollection cells = selectedRow.Cells;

                Employee selectedEmployee = new Employee
                {
                    EmployeeId = (int)(cells["columnId"].Value),
                    EmployeeName = (string)(cells["columnName"].Value),
                    EmployeeSalary = (decimal)(cells["columnSalary"].Value),
                    EmployeeLocation = (string)(cells["columnLocation"].Value),
                    DepartmentId = (comboBoxDepartments.SelectedItem as Department).DepartmentId,
                    DepartmentInfo = comboBoxDepartments.SelectedItem as Department
                };

                DataGridViewColumn column = dgvEmployees.Columns[e.ColumnIndex];

                if (column is DataGridViewButtonColumn)
                {
                    var button = column as DataGridViewButtonColumn;
                    switch (button.HeaderText)
                    {
                        case "UPDATE":
                            UpdateEmployeeRecordForm updateEmployeeRecordForm = new UpdateEmployeeRecordForm(selectedEmployee);
                            this.ShowandHide(updateEmployeeRecordForm);
                            break;

                        case "DELETE":
                            DeleteSelectedEmployee(selectedEmployee.EmployeeId);
                            break;

                        case "SELECT":
                            ViewEmployeeRecordForm viewEmployeeRecordForm
                                = new ViewEmployeeRecordForm(selectedEmployee);
                            this.ShowandHide(viewEmployeeRecordForm);
                            break;

                        default:
                            break;
                    }
                }
                if (column is DataGridViewLinkColumn)
                {
                    DataGridViewLinkColumn link = column as DataGridViewLinkColumn;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ShowandHide(Form form)
        {
            form.Show();
            this.Visible = false;
        }
        private void DeleteSelectedEmployee(int selectedEmployeeId)
        {
            try
            {
                employeeBusinessComponent = new EmployeeBusinessComponent();
                int result = employeeBusinessComponent.RemoveEmployee(selectedEmployeeId);
                if (result > 0)
                {
                    MessageBox.Show($"{result} record deleted succesfully");
                    this.LoadEmployees();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Update(object sender, FormClosedEventArgs e)
        {
            try
            {
                dgvEmployees.DataSource = null;
                LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
