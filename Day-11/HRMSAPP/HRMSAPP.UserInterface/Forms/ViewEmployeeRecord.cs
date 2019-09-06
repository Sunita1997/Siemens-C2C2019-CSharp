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
    public partial class ViewEmployeeRecord : Form
    {
        private Employee employee;
        public ViewEmployeeRecord()
        {
            InitializeComponent();
        }
        public ViewEmployeeRecord(Employee employee) : this()
        {
            this.employee = employee;
        }

        private void ViewEmployeeRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
