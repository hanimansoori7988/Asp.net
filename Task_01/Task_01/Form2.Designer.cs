namespace Task_01
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
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox3 = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(318, 289);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(46, 25);
            checkBox3.TabIndex = 30;
            checkBox3.Text = "C#";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(216, 289);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(56, 25);
            checkBox4.TabIndex = 29;
            checkBox4.Text = "PHP";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(318, 258);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(53, 25);
            checkBox2.TabIndex = 28;
            checkBox2.Text = "CSS";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(216, 258);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 25);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "HTML";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Karachi", "Islamabad", "Lahore", "Peshawar", "Quetta", "Multan", "Sukkhur", "" });
            comboBox1.Location = new Point(217, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 29);
            comboBox1.TabIndex = 26;
            comboBox1.Text = "Select";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 273);
            label6.Name = "label6";
            label6.Size = new Size(105, 21);
            label6.TabIndex = 25;
            label6.Text = "Student Skills :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(215, 183);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(205, 52);
            textBox3.TabIndex = 24;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(296, 152);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 25);
            radioButton2.TabIndex = 23;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(218, 151);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 25);
            radioButton1.TabIndex = 22;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(217, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 26);
            textBox1.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 195);
            label5.Name = "label5";
            label5.Size = new Size(131, 21);
            label5.TabIndex = 20;
            label5.Text = "Student Comment :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 153);
            label4.Name = "label4";
            label4.Size = new Size(118, 21);
            label4.TabIndex = 19;
            label4.Text = "Student Gender :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 117);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 18;
            label3.Text = "Student City : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 84);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 17;
            label2.Text = "Student Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 18);
            label1.Name = "label1";
            label1.Size = new Size(353, 40);
            label1.TabIndex = 16;
            label1.Text = "Show Students Records ";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Location = new Point(40, 17);
            button1.Name = "button1";
            button1.Size = new Size(83, 41);
            button1.TabIndex = 31;
            button1.Text = "Back ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(605, 441);
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
            Name = "Form2";
            Text = "Show Student Records ";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox textBox3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}