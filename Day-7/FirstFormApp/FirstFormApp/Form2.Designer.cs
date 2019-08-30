namespace FirstFormApp
{
    partial class Form2
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.txtFirstValue = new System.Windows.Forms.TextBox();
            this.txtSecondValue = new System.Windows.Forms.TextBox();
            this.lblSecondValue = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.ForeColor = System.Drawing.Color.Black;
            this.lblFirst.Location = new System.Drawing.Point(99, 53);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(145, 20);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "Enter First Value: ";
            // 
            // txtFirstValue
            // 
            this.txtFirstValue.Location = new System.Drawing.Point(273, 47);
            this.txtFirstValue.Name = "txtFirstValue";
            this.txtFirstValue.Size = new System.Drawing.Size(270, 22);
            this.txtFirstValue.TabIndex = 1;
            // 
            // txtSecondValue
            // 
            this.txtSecondValue.Location = new System.Drawing.Point(273, 113);
            this.txtSecondValue.Name = "txtSecondValue";
            this.txtSecondValue.Size = new System.Drawing.Size(270, 22);
            this.txtSecondValue.TabIndex = 3;
            // 
            // lblSecondValue
            // 
            this.lblSecondValue.AutoSize = true;
            this.lblSecondValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondValue.ForeColor = System.Drawing.Color.Black;
            this.lblSecondValue.Location = new System.Drawing.Point(99, 119);
            this.lblSecondValue.Name = "lblSecondValue";
            this.lblSecondValue.Size = new System.Drawing.Size(167, 20);
            this.lblSecondValue.TabIndex = 2;
            this.lblSecondValue.Text = "Enter Second Value: ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(273, 190);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(179, 57);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResult.Location = new System.Drawing.Point(273, 291);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(270, 22);
            this.txtResult.TabIndex = 6;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(99, 297);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(67, 20);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1044, 554);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSecondValue);
            this.Controls.Add(this.lblSecondValue);
            this.Controls.Add(this.txtFirstValue);
            this.Controls.Add(this.lblFirst);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox txtFirstValue;
        private System.Windows.Forms.TextBox txtSecondValue;
        private System.Windows.Forms.Label lblSecondValue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
    }
}