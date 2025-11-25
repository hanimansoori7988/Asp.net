namespace Task_01
{
    public partial class Form1 : Form
    {
        public static string std_name = "";
        public static string std_city = "";
        public static string std_gender = "";
        public static string std_comment = "";
        public static string std_skills_html = "";
        public static string std_skills_css = "";
        public static string std_skills_php = "";
        public static string std_skills_c = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label7.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label7.Text = "Student Name is Required.";
            }
            if (textBox3.Text == "")
            {
                label10.Text = "Student Comment is Required.";
            }
            if (comboBox1.Text == "Select")
            {
                label8.Text = "Student City is Required.";
            }

            if (radioButton1.Checked == true)
            {
                label9.Text = "";
            }
            else if (radioButton2.Checked == true)
            {
                label9.Text = "";
            }
            else
            {
                label9.Text = "Student Gender is Required.";
            }
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked)
            {

            }
            else
            {
                label11.Text = "Student Skills Are Required ";
            }
            if (label7.Text == "" && label8.Text == "" && label9.Text == "" && label10.Text == "" && label11.Text == "")
            {

                std_name = textBox1.Text;
                std_city = comboBox1.Text;
                if (radioButton1.Checked == true)
                {
                    std_gender = "Male";
                }
                else if (radioButton2.Checked == true)
                {
                    std_gender = "Female";
                }
                std_comment = textBox3.Text;
                if (checkBox1.Checked == true)
                {
                    std_skills_html = "HTML";
                }
                if (checkBox2.Checked == true)
                {
                    std_skills_css = "CSS";
                }
                if (checkBox3.Checked == true)
                {
                    std_skills_c = "C#";
                }
                if (checkBox4.Checked == true)
                {
                    std_skills_php = "PHP";
                }
                    Form2 obj = new Form2();
                    obj.Show();
                    this.Hide();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = "";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = "";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = "";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = "";
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            label11.Text = "";
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            label11.Text = "";
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            label11.Text = "";
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            label11.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {




            textBox1.Text = "";
            comboBox1.Text = "Select";
            radioButton2.Checked = false;
            radioButton1.Checked = false;
            textBox3.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }
    }
}
