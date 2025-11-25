namespace Task_01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox3 = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 9);
            label1.Name = "label1";
            label1.Size = new Size(297, 40);
            label1.TabIndex = 0;
            label1.Text = "Resgistration Form ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 75);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 1;
            label2.Text = "Student Name :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 108);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 2;
            label3.Text = "Student City : ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 144);
            label4.Name = "label4";
            label4.Size = new Size(118, 21);
            label4.TabIndex = 3;
            label4.Text = "Student Gender :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 186);
            label5.Name = "label5";
            label5.Size = new Size(131, 21);
            label5.TabIndex = 4;
            label5.Text = "Student Comment :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(187, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 26);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(188, 142);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 25);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male ";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(266, 143);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 25);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female ";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(185, 174);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(205, 52);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 264);
            label6.Name = "label6";
            label6.Size = new Size(105, 21);
            label6.TabIndex = 10;
            label6.Text = "Student Skills :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Karachi", "Islamabad", "Lahore", "Peshawar", "Quetta", "Multan", "Sukkhur", "" });
            comboBox1.Location = new Point(187, 108);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 29);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "Select";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(186, 249);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 25);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "HTML";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(288, 249);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(53, 25);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "CSS";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged_1;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(288, 280);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(44, 25);
            checkBox3.TabIndex = 15;
            checkBox3.Text = "c#";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged_1;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(186, 280);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(56, 25);
            checkBox4.TabIndex = 14;
            checkBox4.Text = "PHP";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Location = new Point(180, 311);
            button1.Name = "button1";
            button1.Size = new Size(212, 38);
            button1.TabIndex = 16;
            button1.Text = "Register Student ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(192, 0, 0);
            label7.Location = new Point(395, 75);
            label7.Name = "label7";
            label7.Size = new Size(0, 21);
            label7.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(192, 0, 0);
            label8.Location = new Point(398, 111);
            label8.Name = "label8";
            label8.Size = new Size(0, 21);
            label8.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(192, 0, 0);
            label9.Location = new Point(398, 146);
            label9.Name = "label9";
            label9.Size = new Size(0, 21);
            label9.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(192, 0, 0);
            label10.Location = new Point(398, 186);
            label10.Name = "label10";
            label10.Size = new Size(0, 21);
            label10.TabIndex = 20;
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(192, 0, 0);
            label11.Location = new Point(395, 260);
            label11.Name = "label11";
            label11.Size = new Size(0, 21);
            label11.TabIndex = 21;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Location = new Point(48, 318);
            button2.Name = "button2";
            button2.Size = new Size(114, 31);
            button2.TabIndex = 22;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(673, 439);
            Controls.Add(button2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox4);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Resgistration Form ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox3;
        private Label label6;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button2;
    }
}
