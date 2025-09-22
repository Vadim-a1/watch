using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderSize = 0;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent; // Прозрачный фон при наведении
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent; // Прозрачный фон при нажатии

            button2.FlatStyle = FlatStyle.Flat; // Плоский стиль кнопки
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent; // Прозрачный фон при наведении
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent; // Прозрачный фон при нажатии
            
            button1.FlatStyle = FlatStyle.Flat; // Плоский стиль кнопки

            Form3 f3 = new Form3();   // создаём вторую форму
            f3.Show();                // показываем её
            this.Hide();              // скрываем текущую (Form1)

        }

        private void label1_Click(object sender, EventArgs e)
        {
            



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
