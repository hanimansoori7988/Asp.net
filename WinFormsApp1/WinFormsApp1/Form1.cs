using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            DataTable table = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("Student Name ", typeof(string));
            table.Columns.Add("Student Gender ", typeof(string));
            //table.Columns.Add("Student City ", typeof(string));
            table.Columns.Add("Student Age", typeof(int));
            table.Columns.Add("Student Fees ", typeof(int));


            dataGridView1.DataSource = table;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataTable table = new DataTable();
            //table.Columns.Add("id", typeof(int));
            //table.Columns.Add("Student Name ", typeof(string));
            //table.Columns.Add("Student Gender ", typeof(string));
            ////table.Columns.Add("Student City ", typeof(string));
            //table.Columns.Add("Student Age", typeof(int));
            //table.Columns.Add("Student Fees ", typeof(int));


            //dataGridView1.DataSource = table;

            if (textBox3.Text == "")
            {
                label8.Text = "Student Id is Required .";
            }
            if (textBox1.Text == "")
            {
                label9.Text = "Student Name is Required .";
            }
            if (textBox2.Text == "")
            {
                label10.Text = "Student Gender is Required .";
            }
            if (textBox4.Text == "")
            {
                label11.Text = "Student Age is Required .";
            }
            if (textBox5.Text == "")
            {
                label12.Text = "Student fees is Required .";
            }
            if (label8.Text == "" && label9.Text == "" && label10.Text == "" && label11.Text == "" && label12.Text == "")
            {
                table.Rows.Add(textBox3.Text, textBox1.Text, textBox2.Text, textBox4.Text, textBox5.Text);
                dataGridView1.DataSource = table;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                  

            }
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                label8.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label9.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                label10.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                label11.Text = "";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                label12.Text = "";
            }
        }
    }
}
