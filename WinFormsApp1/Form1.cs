namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Person person1;
        public Form1()
        {
            InitializeComponent();
            person1 = new Person("MARIO");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("press the name");
            }
            else
            {
                groupBox1.Text = "name:"+textBox1.Text + "\n" +"lvl:"+textBox2.Text +"\n" + "hp:"+textBox3.Text + "\n"+ "damage:" + textBox4.Text;

            }
            








        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
