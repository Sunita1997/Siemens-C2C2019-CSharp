using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifferentControls
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private Form1 form1;
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form1 == null)
                form1 = new Form1();

            form1.MdiParent = this;
            form1.Show();
        }
    }
}
