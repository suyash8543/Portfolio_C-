namespace portfolio_C_
{
    partial class Education
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
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Chartreuse;
            label2.Location = new Point(27, 23);
            label2.Name = "label2";
            label2.Size = new Size(233, 50);
            label2.TabIndex = 3;
            label2.Text = "EDUCATION";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSlateGray;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(9, 100);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 167);
            panel1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSlateGray;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(18, 103);
            label4.Name = "label4";
            label4.Size = new Size(85, 35);
            label4.TabIndex = 2;
            label4.Text = "IMSEC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSlateGray;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(18, 55);
            label3.Name = "label3";
            label3.Size = new Size(173, 35);
            label3.TabIndex = 1;
            label3.Text = "2023 - Present";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.InactiveCaption;
            label1.Location = new Point(18, 11);
            label1.Name = "label1";
            label1.Size = new Size(410, 35);
            label1.TabIndex = 0;
            label1.Text = "COMPUTER SCIENCE ENGINEERING";
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(9, 284);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 184);
            panel2.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightSlateGray;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(18, 114);
            label8.Name = "label8";
            label8.Size = new Size(323, 35);
            label8.TabIndex = 3;
            label8.Text = "LUCKNOW PUBLIC SCHOOL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightSlateGray;
            label7.Font = new Font("Segoe UI", 15F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(18, 68);
            label7.Name = "label7";
            label7.Size = new Size(143, 35);
            label7.TabIndex = 2;
            label7.Text = "2018 - 2022";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = SystemColors.InactiveCaption;
            label6.Location = new Point(18, 18);
            label6.Name = "label6";
            label6.Size = new Size(252, 35);
            label6.TabIndex = 1;
            label6.Text = "High School Diploma";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(988, -3);
            label10.Name = "label10";
            label10.Size = new Size(38, 41);
            label10.TabIndex = 13;
            label10.Text = "X";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.LightSlateGray;
            label11.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(454, 479);
            label11.Name = "label11";
            label11.Size = new Size(65, 31);
            label11.TabIndex = 4;
            label11.Text = "Back";
            label11.Click += label11_Click;
            // 
            // Education
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1021, 519);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Education";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Education";
            Load += Education_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label10;
        private Label label11;
    }
}