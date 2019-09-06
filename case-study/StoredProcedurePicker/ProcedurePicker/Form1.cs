using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProcedurePickerLibrary;

namespace ProcedurePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new ProcedurePickerComponent()
                .GetProcedures()
                .ForEach(pi => comboBox1.Items.Add(pi.Name));
            comboBox1.Items.Insert(0, "--select--");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = new ProcedurePickerComponent()
                .GetProcedures()
                .Where(pi => pi.Name == comboBox1.SelectedItem as string)
                .FirstOrDefault()
                .Parameters;
            dataGridView1.DataSource = list;
        }
    }
}
