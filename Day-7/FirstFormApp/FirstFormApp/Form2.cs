using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(object data) : this()
        {
            MessageBox.Show($"welcome {(string)data}");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int firstValue = int.Parse(txtFirstValue.Text);
            int secondValue = int.Parse(txtSecondValue.Text);

            int result = firstValue + secondValue;
            txtResult.Text = result.ToString();
        }
    }
}
