using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.std_name;
            comboBox1.Text = Form1.std_city;
            if (Form1.std_gender == "Male")
            {
                radioButton1.Checked = true;
            }
            if (Form1.std_gender == "Female")
            {
                radioButton2.Checked = true;
            }
            textBox3.Text = Form1.std_comment;
            if (Form1.std_skills_html == "HTML")
            {
                checkBox1.Checked = true;
            }
            if (Form1.std_skills_css == "CSS")
            {
                checkBox2.Checked = true;
            }
            if (Form1.std_skills_php == "PHP")
            {
                checkBox4.Checked = true;
            }
            if (Form1.std_skills_c == "C#")
            {
                checkBox3.Checked = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                Form1 obj1 = new Form1();
                obj1.Show();
                this.Hide();
                
            }    
        }
    }
