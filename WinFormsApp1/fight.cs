using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class fight : Form
    {
        private int enemyHealth = 100;
        private int enemyMaxHealth = 100;

        private int myHealth = 150;
        private int myMaxHealth = 150;

        public fight()
        {
            InitializeComponent();
            buttonDamage.Click += buttonDamage_Click;
            this.Load += fight_Load;
        }

        private void fight_Load(object sender, EventArgs e)
        {
            progressBarHealth.Minimum = 0;
            progressBarHealth.Maximum = enemyMaxHealth;
            SetProgressSafe(progressBarHealth, enemyHealth);

            progressBarMy.Minimum = 0;
            progressBarMy.Maximum = myMaxHealth;
            SetProgressSafe(progressBarMy, myHealth);
        }

        private void buttonDamage_Click(object sender, EventArgs e)
        {
            // Враг
            enemyHealth -= 10;
            enemyHealth = Math.Max(0, enemyHealth);
            SetProgressSafe(progressBarHealth, enemyHealth);

            // Игрок
            myHealth -= 10;
            myHealth = Math.Max(0, myHealth);
            SetProgressSafe(progressBarMy, myHealth);
            CheckVictory();
        }


        private void CheckVictory()
        {
            if (enemyHealth <= 0 && myHealth > 0)
            {
                textBox1.Text = "VICTORY!";
                buttonDamage.Enabled = false; // Отключаем кнопку после победы
            }
            
        }
        

        private void SetProgressSafe(ProgressBar bar, int value)
        {
            if (value < bar.Minimum) value = bar.Minimum;
            if (value > bar.Maximum) value = bar.Maximum;

            // Обходим баг WinForms, когда Value = Maximum
            if (value == bar.Maximum && value != bar.Minimum)
                value -= 1;

            bar.Value = value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fight_Load_1(object sender, EventArgs e)
        {

        }
    }
}