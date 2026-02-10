namespace testForms
{
    partial class chkRadioGrp
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSmall = new System.Windows.Forms.RadioButton();
            this.btnMedium = new System.Windows.Forms.RadioButton();
            this.btnLarge = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbShowSize = new System.Windows.Forms.Button();
            this.gbCrust.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(69, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(221, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Do you want to receive Emails ? ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.AutoSize = true;
            this.btnSmall.Location = new System.Drawing.Point(86, 21);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(62, 20);
            this.btnSmall.TabIndex = 2;
            this.btnSmall.TabStop = true;
            this.btnSmall.Text = "Small";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnMedium
            // 
            this.btnMedium.AutoSize = true;
            this.btnMedium.Location = new System.Drawing.Point(85, 62);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(76, 20);
            this.btnMedium.TabIndex = 3;
            this.btnMedium.TabStop = true;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            // 
            // btnLarge
            // 
            this.btnLarge.AutoSize = true;
            this.btnLarge.Location = new System.Drawing.Point(85, 106);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(63, 20);
            this.btnLarge.TabIndex = 4;
            this.btnLarge.TabStop = true;
            this.btnLarge.Text = "Large";
            this.btnLarge.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(69, 64);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 20);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Thick";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(69, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 20);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Thin";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.radioButton2);
            this.gbCrust.Controls.Add(this.radioButton1);
            this.gbCrust.Location = new System.Drawing.Point(614, 151);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(220, 131);
            this.gbCrust.TabIndex = 8;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.btnSmall);
            this.gbSize.Controls.Add(this.btnMedium);
            this.gbSize.Controls.Add(this.button2);
            this.gbSize.Controls.Add(this.btnLarge);
            this.gbSize.Location = new System.Drawing.Point(323, 151);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(221, 206);
            this.gbSize.TabIndex = 9;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // gbShowSize
            // 
            this.gbShowSize.Location = new System.Drawing.Point(391, 383);
            this.gbShowSize.Name = "gbShowSize";
            this.gbShowSize.Size = new System.Drawing.Size(103, 32);
            this.gbShowSize.TabIndex = 6;
            this.gbShowSize.Text = "ShowSize";
            this.gbShowSize.UseVisualStyleBackColor = true;
            this.gbShowSize.Click += new System.EventHandler(this.gbShowSize_Click);
            // 
            // chkRadioGrp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 574);
            this.Controls.Add(this.gbShowSize);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Name = "chkRadioGrp";
            this.Text = "chkRadioGrp";
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton btnSmall;
        private System.Windows.Forms.RadioButton btnMedium;
        private System.Windows.Forms.RadioButton btnLarge;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.Button gbShowSize;
    }
}