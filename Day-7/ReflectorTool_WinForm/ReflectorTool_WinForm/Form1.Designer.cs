namespace ReflectorTool_WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnLoadClasses = new System.Windows.Forms.Button();
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.groupBoxClasses = new System.Windows.Forms.GroupBox();
            this.btnGetProperties = new System.Windows.Forms.Button();
            this.dataGridViewProperties = new System.Windows.Forms.DataGridView();
            this.listBoxClasses = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxFile.SuspendLayout();
            this.groupBoxClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(6, 30);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(184, 45);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select a File:";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.AllowDrop = true;
            this.txtFilePath.Location = new System.Drawing.Point(207, 35);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(454, 40);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnLoadClasses
            // 
            this.btnLoadClasses.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLoadClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadClasses.Location = new System.Drawing.Point(50, 25);
            this.btnLoadClasses.Name = "btnLoadClasses";
            this.btnLoadClasses.Size = new System.Drawing.Size(211, 38);
            this.btnLoadClasses.TabIndex = 2;
            this.btnLoadClasses.Text = "Load Class Names";
            this.btnLoadClasses.UseVisualStyleBackColor = false;
            this.btnLoadClasses.Click += new System.EventHandler(this.btnLoadClasses_Click);
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBoxFile.Controls.Add(this.btnSelectFile);
            this.groupBoxFile.Controls.Add(this.txtFilePath);
            this.groupBoxFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFile.Location = new System.Drawing.Point(119, 36);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Size = new System.Drawing.Size(694, 98);
            this.groupBoxFile.TabIndex = 3;
            this.groupBoxFile.TabStop = false;
            this.groupBoxFile.Text = "Pick up a File:";
            // 
            // groupBoxClasses
            // 
            this.groupBoxClasses.Controls.Add(this.btnGetProperties);
            this.groupBoxClasses.Controls.Add(this.dataGridViewProperties);
            this.groupBoxClasses.Controls.Add(this.listBoxClasses);
            this.groupBoxClasses.Controls.Add(this.btnLoadClasses);
            this.groupBoxClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxClasses.Location = new System.Drawing.Point(69, 217);
            this.groupBoxClasses.Name = "groupBoxClasses";
            this.groupBoxClasses.Size = new System.Drawing.Size(950, 402);
            this.groupBoxClasses.TabIndex = 4;
            this.groupBoxClasses.TabStop = false;
            this.groupBoxClasses.Text = "Class Names:";
            // 
            // btnGetProperties
            // 
            this.btnGetProperties.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGetProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetProperties.Location = new System.Drawing.Point(298, 142);
            this.btnGetProperties.Name = "btnGetProperties";
            this.btnGetProperties.Size = new System.Drawing.Size(169, 54);
            this.btnGetProperties.TabIndex = 5;
            this.btnGetProperties.Text = "Properties =>";
            this.btnGetProperties.UseVisualStyleBackColor = false;
            this.btnGetProperties.Click += new System.EventHandler(this.btnGetProperties_Click);
            // 
            // dataGridViewProperties
            // 
            this.dataGridViewProperties.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProperties.Location = new System.Drawing.Point(504, 25);
            this.dataGridViewProperties.Name = "dataGridViewProperties";
            this.dataGridViewProperties.RowTemplate.Height = 24;
            this.dataGridViewProperties.Size = new System.Drawing.Size(341, 371);
            this.dataGridViewProperties.TabIndex = 4;
            // 
            // listBoxClasses
            // 
            this.listBoxClasses.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBoxClasses.FormattingEnabled = true;
            this.listBoxClasses.ItemHeight = 20;
            this.listBoxClasses.Location = new System.Drawing.Point(23, 83);
            this.listBoxClasses.Name = "listBoxClasses";
            this.listBoxClasses.Size = new System.Drawing.Size(269, 224);
            this.listBoxClasses.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 652);
            this.Controls.Add(this.groupBoxClasses);
            this.Controls.Add(this.groupBoxFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxFile.ResumeLayout(false);
            this.groupBoxFile.PerformLayout();
            this.groupBoxClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnLoadClasses;
        private System.Windows.Forms.GroupBox groupBoxFile;
        private System.Windows.Forms.GroupBox groupBoxClasses;
        private System.Windows.Forms.DataGridView dataGridViewProperties;
        private System.Windows.Forms.ListBox listBoxClasses;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGetProperties;
    }
}

