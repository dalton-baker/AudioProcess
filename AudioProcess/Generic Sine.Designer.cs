namespace AudioProcess
{
    partial class Generic_Sine
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
            this.amplitude = new System.Windows.Forms.TextBox();
            this.freq1 = new System.Windows.Forms.TextBox();
            this.freq2 = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFreq2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amplitude
            // 
            this.amplitude.Location = new System.Drawing.Point(108, 4);
            this.amplitude.Name = "amplitude";
            this.amplitude.Size = new System.Drawing.Size(100, 20);
            this.amplitude.TabIndex = 4;
            // 
            // freq1
            // 
            this.freq1.Location = new System.Drawing.Point(108, 30);
            this.freq1.Name = "freq1";
            this.freq1.Size = new System.Drawing.Size(100, 20);
            this.freq1.TabIndex = 5;
            // 
            // freq2
            // 
            this.freq2.Location = new System.Drawing.Point(108, 56);
            this.freq2.Name = "freq2";
            this.freq2.Size = new System.Drawing.Size(100, 20);
            this.freq2.TabIndex = 6;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(52, 121);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(133, 121);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Amplitude:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Frequency 1:";
            // 
            // lblFreq2
            // 
            this.lblFreq2.AutoSize = true;
            this.lblFreq2.Location = new System.Drawing.Point(33, 59);
            this.lblFreq2.Name = "lblFreq2";
            this.lblFreq2.Size = new System.Drawing.Size(69, 13);
            this.lblFreq2.TabIndex = 14;
            this.lblFreq2.Text = "Frequency 2:";
            // 
            // Generic_Sine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 150);
            this.Controls.Add(this.lblFreq2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.freq2);
            this.Controls.Add(this.freq1);
            this.Controls.Add(this.amplitude);
            this.Name = "Generic_Sine";
            this.Text = "Parameter Sine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox amplitude;
        private System.Windows.Forms.TextBox freq1;
        private System.Windows.Forms.TextBox freq2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFreq2;
    }
}