namespace Combo_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] names = ["Select", "Daniyal", "Huzaifa", "Hamza", "Moiz", "Haris", "Zubair", "Hassan", "Haris", "Daud", "Talha"];
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Select");
            comboBox2.Items.Add("Pakistan");
            comboBox2.Items.Add("India");
            comboBox2.Items.Add("Afghanistan");
            comboBox2.Items.Add("Iran");
            comboBox2.Items.Add("Kolkatta");


            comboBox3.Items.AddRange(names);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string state = "";
            state = comboBox2.Text;
            label12.Text = "State Name is  " + state;


        }
        //public string[] dictionary_items = new string [100];
        private void button1_Click(object sender, EventArgs e)
        {
            if (label10.Text != "")
            {
                label10.Text = "";
            }
            if (label11.Text != "")
            {
                label11.Text = "";
            }
            if (textBox1.Text != "")
            {
                comboBox4.Items.Add(textBox1.Text);
                textBox1.Text = "";
                label11.Text = "Items Added Successfully !";
            }
            else
            {
                label10.Text = "Required !";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public string tmp = "";
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmp = comboBox4.Text;
            textBox2.Text = tmp;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fruit = "";
            fruit = comboBox1.Text;
            label12.Text = "Fruit Name is  " +  fruit;

        }
    }
}
