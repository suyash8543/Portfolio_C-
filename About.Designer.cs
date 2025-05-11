namespace portfolio_C_
{
    partial class About
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
            label1 = new Label();
            label3 = new Label();
            label11 = new Label();
            label12 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Chartreuse;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(214, 50);
            label2.TabIndex = 5;
            label2.Text = "ABOUT ME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(13, 110);
            label1.Name = "label1";
            label1.Size = new Size(1156, 35);
            label1.TabIndex = 6;
            label1.Text = "Hello! I'm a passionate and dedicated software developer currently on a journey to expand my skills in ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(13, 274);
            label3.Name = "label3";
            label3.Size = new Size(1191, 35);
            label3.TabIndex = 7;
            label3.Text = " which is enabling me to build robust and scalable web services that can interact with various applications.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.LightSlateGray;
            label11.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(540, 352);
            label11.Name = "label11";
            label11.Size = new Size(65, 31);
            label11.TabIndex = 9;
            label11.Text = "Back";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(1174, 0);
            label12.Name = "label12";
            label12.Size = new Size(38, 41);
            label12.TabIndex = 15;
            label12.Text = "X";
            label12.Click += label12_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(13, 162);
            label5.Name = "label5";
            label5.Size = new Size(1184, 35);
            label5.TabIndex = 16;
            label5.Text = "programming and software development. I am actively learning C# and  diving deep into DSA using C++.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(9, 219);
            label6.Name = "label6";
            label6.Size = new Size(1184, 35);
            label6.TabIndex = 17;
            label6.Text = " I have been working with Windows Forms to create desktop applications and into Web API development.";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1211, 392);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label11;
        private Label label12;
        private Label label5;
        private Label label6;
    }
}