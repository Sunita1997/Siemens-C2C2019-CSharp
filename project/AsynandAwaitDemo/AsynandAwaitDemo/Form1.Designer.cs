namespace AsynandAwaitDemo
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
            this.cmdSync = new System.Windows.Forms.Button();
            this.cmdAsync = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.cmdParallelAsync = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // cmdSync
            // 
            this.cmdSync.Location = new System.Drawing.Point(167, 46);
            this.cmdSync.Name = "cmdSync";
            this.cmdSync.Size = new System.Drawing.Size(186, 42);
            this.cmdSync.TabIndex = 0;
            this.cmdSync.Text = "Synchronous Execution";
            this.cmdSync.UseVisualStyleBackColor = true;
            this.cmdSync.Click += new System.EventHandler(this.cmdSync_Click);
            // 
            // cmdAsync
            // 
            this.cmdAsync.Location = new System.Drawing.Point(720, 12);
            this.cmdAsync.Name = "cmdAsync";
            this.cmdAsync.Size = new System.Drawing.Size(168, 42);
            this.cmdAsync.TabIndex = 1;
            this.cmdAsync.Text = "Asynchronous Execution";
            this.cmdAsync.UseVisualStyleBackColor = true;
            this.cmdAsync.Click += new System.EventHandler(this.cmdAsync_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(75, 110);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(474, 336);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(582, 110);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(474, 336);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(1085, 110);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(474, 336);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "";
            // 
            // cmdParallelAsync
            // 
            this.cmdParallelAsync.Location = new System.Drawing.Point(1266, 46);
            this.cmdParallelAsync.Name = "cmdParallelAsync";
            this.cmdParallelAsync.Size = new System.Drawing.Size(168, 42);
            this.cmdParallelAsync.TabIndex = 4;
            this.cmdParallelAsync.Text = "Parallel Asynchronous Execution";
            this.cmdParallelAsync.UseVisualStyleBackColor = true;
            this.cmdParallelAsync.Click += new System.EventHandler(this.cmdParallelAsync_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(582, 64);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(474, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 518);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.cmdParallelAsync);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cmdAsync);
            this.Controls.Add(this.cmdSync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSync;
        private System.Windows.Forms.Button cmdAsync;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button cmdParallelAsync;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

