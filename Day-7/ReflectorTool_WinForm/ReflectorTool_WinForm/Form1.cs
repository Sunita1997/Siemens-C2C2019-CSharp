using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectorTool_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
            }
        }

        private Assembly assembly;
        private void btnLoadClasses_Click(object sender, EventArgs e)
        {
            listBoxClasses.Items.Clear();
            if (txtFilePath.Text != string.Empty)
            {
                assembly = Assembly.LoadFile(txtFilePath.Text);
                Type[] allTypes = assembly.GetTypes();
                //List<Type> classTypes = new List<Type>();
                foreach (Type type in allTypes)
                {
                    if (type.IsClass)
                    {
                        //classTypes.Add(type);
                        listBoxClasses.Items.Add(type.FullName);
                    }
                }
                //if (classTypes.Count > 0)
                //{
                //    listBoxClasses.DataSource = classTypes;
                //    listBoxClasses.DisplayMember = "FullName";
                //}
            }
        }

        private void btnGetProperties_Click(object sender, EventArgs e)
        {
            dataGridViewProperties.DataSource = null;
            if (listBoxClasses.Items != null && listBoxClasses.Items.Count > 0 && assembly != null)
            {
                //Type clsType = assembly.GetType((listBoxClasses.SelectedItem as Type).Name);
                Type clsType = assembly.GetType(listBoxClasses.SelectedItem as string);

                PropertyInfo[] allProperties = clsType.GetProperties();
                if (allProperties != null && allProperties.Length > 0)
                {
                    List<PropertyMetadata> properties = new List<PropertyMetadata>();
                    foreach (PropertyInfo property in allProperties)
                    {
                        properties.Add(new PropertyMetadata
                        {
                            Name = property.Name,
                            DataType = property.PropertyType.Name
                        });
                    }
                    dataGridViewProperties.DataSource = properties;
                }
            }
        }
    }
}
