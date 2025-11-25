namespace Student_Form
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 42);
            label1.Name = "label1";
            label1.Size = new Size(101, 17);
            label1.TabIndex = 0;
            label1.Text = "Student Name :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 37);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Student Name ";
            textBox1.Size = new Size(200, 25);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(160, 68);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter Father Name ";
            textBox2.Size = new Size(200, 25);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 73);
            label2.Name = "label2";
            label2.Size = new Size(93, 17);
            label2.TabIndex = 2;
            label2.Text = "Father Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 104);
            label3.Name = "label3";
            label3.Size = new Size(109, 17);
            label3.TabIndex = 4;
            label3.Text = "Student Gender :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 139);
            label4.Name = "label4";
            label4.Size = new Size(90, 17);
            label4.TabIndex = 5;
            label4.Text = "Student City :";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(161, 107);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 21);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "  Male ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(256, 107);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 21);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = " Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Karachi", "Islamabad", "Lahore", "Peshawar", "Sukkhur", "Jhelum" });
            comboBox1.Location = new Point(160, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 25);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "Select";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(34, 174);
            button1.Name = "button1";
            button1.Size = new Size(322, 33);
            button1.TabIndex = 9;
            button1.Text = "Register Student ";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(526, 465);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Form1";
            Text = "Student Registartion ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox1;
        private Button button1;
    }
}
