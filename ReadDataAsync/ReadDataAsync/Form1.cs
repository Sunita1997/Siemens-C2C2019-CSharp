using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadDataAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                txtFilePath.Text = filePath;
            }
        }
    }
}
