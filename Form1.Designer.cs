namespace payroll_with_overtime
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGrosspay = new System.Windows.Forms.Label();
            this.txtHoursworked = new System.Windows.Forms.TextBox();
            this.textHourlypayrate = new System.Windows.Forms.TextBox();
            this.Grosspay = new System.Windows.Forms.TextBox();
            this.txtcalculatecrosspay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hours worked";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hourly pay rate";
            // 
            // txtGrosspay
            // 
            this.txtGrosspay.AutoSize = true;
            this.txtGrosspay.Location = new System.Drawing.Point(58, 129);
            this.txtGrosspay.Name = "txtGrosspay";
            this.txtGrosspay.Size = new System.Drawing.Size(78, 20);
            this.txtGrosspay.TabIndex = 2;
            this.txtGrosspay.Text = "GrossPay";
            this.txtGrosspay.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtHoursworked
            // 
            this.txtHoursworked.Location = new System.Drawing.Point(382, 32);
            this.txtHoursworked.Name = "txtHoursworked";
            this.txtHoursworked.Size = new System.Drawing.Size(187, 26);
            this.txtHoursworked.TabIndex = 3;
            // 
            // textHourlypayrate
            // 
            this.textHourlypayrate.Location = new System.Drawing.Point(382, 78);
            this.textHourlypayrate.Name = "textHourlypayrate";
            this.textHourlypayrate.Size = new System.Drawing.Size(187, 26);
            this.textHourlypayrate.TabIndex = 4;
            // 
            // Grosspay
            // 
            this.Grosspay.Location = new System.Drawing.Point(365, 129);
            this.Grosspay.Name = "Grosspay";
            this.Grosspay.Size = new System.Drawing.Size(204, 26);
            this.Grosspay.TabIndex = 5;
            // 
            // txtcalculatecrosspay
            // 
            this.txtcalculatecrosspay.Location = new System.Drawing.Point(150, 293);
            this.txtcalculatecrosspay.Name = "txtcalculatecrosspay";
            this.txtcalculatecrosspay.Size = new System.Drawing.Size(135, 68);
            this.txtcalculatecrosspay.TabIndex = 6;
            this.txtcalculatecrosspay.Text = "calculate crosspay";
            this.txtcalculatecrosspay.UseVisualStyleBackColor = true;
            this.txtcalculatecrosspay.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 48);
            this.button3.TabIndex = 8;
            this.button3.Text = "clear";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtcalculatecrosspay);
            this.Controls.Add(this.Grosspay);
            this.Controls.Add(this.textHourlypayrate);
            this.Controls.Add(this.txtHoursworked);
            this.Controls.Add(this.txtGrosspay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtGrosspay;
        private System.Windows.Forms.TextBox txtHoursworked;
        private System.Windows.Forms.TextBox textHourlypayrate;
        private System.Windows.Forms.TextBox Grosspay;
        private System.Windows.Forms.Button txtcalculatecrosspay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

