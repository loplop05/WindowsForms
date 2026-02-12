namespace testForms
{
    partial class frmColorDialog
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnChangeFontColor = new System.Windows.Forms.Button();
            this.btnChangeBoxColor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnChangeFontColor
            // 
            this.btnChangeFontColor.Location = new System.Drawing.Point(120, 153);
            this.btnChangeFontColor.Name = "btnChangeFontColor";
            this.btnChangeFontColor.Size = new System.Drawing.Size(145, 40);
            this.btnChangeFontColor.TabIndex = 0;
            this.btnChangeFontColor.Text = "Change Font Color";
            this.btnChangeFontColor.UseVisualStyleBackColor = true;
            this.btnChangeFontColor.Click += new System.EventHandler(this.btnChangeFontColor_Click);
            // 
            // btnChangeBoxColor
            // 
            this.btnChangeBoxColor.Location = new System.Drawing.Point(310, 153);
            this.btnChangeBoxColor.Name = "btnChangeBoxColor";
            this.btnChangeBoxColor.Size = new System.Drawing.Size(145, 40);
            this.btnChangeBoxColor.TabIndex = 1;
            this.btnChangeBoxColor.Text = "Change Box Color";
            this.btnChangeBoxColor.UseVisualStyleBackColor = true;
            this.btnChangeBoxColor.Click += new System.EventHandler(this.btnChangeBoxColor_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(174, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 34);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Change Font";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save As Dialog";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmColorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 642);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnChangeBoxColor);
            this.Controls.Add(this.btnChangeFontColor);
            this.Name = "frmColorDialog";
            this.Text = "frmColorDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnChangeFontColor;
        private System.Windows.Forms.Button btnChangeBoxColor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}