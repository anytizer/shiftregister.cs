namespace ShiftRegisters.cs
{
    partial class Breadboard
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shiftRegister8 = new ShiftRegisters.cs.ShiftRegister();
            this.shiftRegister7 = new ShiftRegisters.cs.ShiftRegister();
            this.shiftRegister6 = new ShiftRegisters.cs.ShiftRegister();
            this.shiftRegister5 = new ShiftRegisters.cs.ShiftRegister();
            this.shiftRegister4 = new ShiftRegisters.cs.ShiftRegister();
            this.shiftRegister3 = new ShiftRegisters.cs.ShiftRegister();
            this.shiftRegister2 = new ShiftRegisters.cs.ShiftRegister();
            this.shiftRegister1 = new ShiftRegisters.cs.ShiftRegister();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(10, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(46, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(82, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(476, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "On";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(512, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 6;
            this.button5.Text = "Off";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Impediance (Set all)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Shift Register Clock";
            // 
            // shiftRegister8
            // 
            this.shiftRegister8.Location = new System.Drawing.Point(308, 186);
            this.shiftRegister8.Name = "shiftRegister8";
            this.shiftRegister8.Size = new System.Drawing.Size(289, 38);
            this.shiftRegister8.TabIndex = 15;
            // 
            // shiftRegister7
            // 
            this.shiftRegister7.Location = new System.Drawing.Point(3, 186);
            this.shiftRegister7.Name = "shiftRegister7";
            this.shiftRegister7.Size = new System.Drawing.Size(289, 38);
            this.shiftRegister7.TabIndex = 14;
            // 
            // shiftRegister6
            // 
            this.shiftRegister6.Location = new System.Drawing.Point(308, 129);
            this.shiftRegister6.Name = "shiftRegister6";
            this.shiftRegister6.Size = new System.Drawing.Size(289, 38);
            this.shiftRegister6.TabIndex = 13;
            // 
            // shiftRegister5
            // 
            this.shiftRegister5.Location = new System.Drawing.Point(3, 129);
            this.shiftRegister5.Name = "shiftRegister5";
            this.shiftRegister5.Size = new System.Drawing.Size(289, 38);
            this.shiftRegister5.TabIndex = 12;
            // 
            // shiftRegister4
            // 
            this.shiftRegister4.Location = new System.Drawing.Point(308, 71);
            this.shiftRegister4.Name = "shiftRegister4";
            this.shiftRegister4.Size = new System.Drawing.Size(289, 38);
            this.shiftRegister4.TabIndex = 11;
            // 
            // shiftRegister3
            // 
            this.shiftRegister3.Location = new System.Drawing.Point(3, 71);
            this.shiftRegister3.Name = "shiftRegister3";
            this.shiftRegister3.Size = new System.Drawing.Size(289, 38);
            this.shiftRegister3.TabIndex = 10;
            // 
            // shiftRegister2
            // 
            this.shiftRegister2.Location = new System.Drawing.Point(308, 12);
            this.shiftRegister2.Name = "shiftRegister2";
            this.shiftRegister2.Size = new System.Drawing.Size(289, 38);
            this.shiftRegister2.TabIndex = 9;
            // 
            // shiftRegister1
            // 
            this.shiftRegister1.Location = new System.Drawing.Point(3, 12);
            this.shiftRegister1.Name = "shiftRegister1";
            this.shiftRegister1.Size = new System.Drawing.Size(289, 38);
            this.shiftRegister1.TabIndex = 2;
            // 
            // Breadboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 300);
            this.Controls.Add(this.shiftRegister8);
            this.Controls.Add(this.shiftRegister7);
            this.Controls.Add(this.shiftRegister6);
            this.Controls.Add(this.shiftRegister5);
            this.Controls.Add(this.shiftRegister4);
            this.Controls.Add(this.shiftRegister3);
            this.Controls.Add(this.shiftRegister2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.shiftRegister1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Breadboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shift Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private ShiftRegister shiftRegister1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ShiftRegister shiftRegister2;
        private ShiftRegister shiftRegister3;
        private ShiftRegister shiftRegister4;
        private ShiftRegister shiftRegister5;
        private ShiftRegister shiftRegister6;
        private ShiftRegister shiftRegister7;
        private ShiftRegister shiftRegister8;
    }
}

