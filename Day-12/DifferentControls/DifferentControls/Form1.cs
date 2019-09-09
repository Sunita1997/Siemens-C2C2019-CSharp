using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifferentControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = saveFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                StreamWriter writer = new StreamWriter(path, true);
                string data = richTextBox1.Text;
                writer.WriteLine(data);
                writer.Flush();
                writer.Close();
            }
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    Form2 form2 = new Form2();

        //    //Modeless dialog box
        //    //form2.Show();

        //    //Modal dialog box
        //    form2.ShowDialog();
        //}
    }
}
