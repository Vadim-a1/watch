using System;
using System.Windows.Forms;
using System.Media;
namespace WinFormsApp1
{
    public partial class fight : Form
    {
        // Используем интерфейс вместо конкретных классов
        private Ifighter enemy;
        private Ifighter player;

        private int enemyHealth = 100;
        private int enemyMaxHealth = 100;
        private int myHealth = 150;
        private int myMaxHealth = 150;

        public fight()
        {
            InitializeComponent();

            // Создаем бойцов через интерфейс
            enemy = new SimpleEnemy();
            player = new SimplePlayer();

            buttonDamage.Click += buttonDamage_Click;
            this.Load += fight_Load;
        }

        private void fight_Load(object sender, EventArgs e)
        {
            progressBarHealth.Minimum = 0;
            progressBarHealth.Maximum = enemy.maxhealth;
            SetProgressSafe(progressBarHealth, enemy.health);

            progressBarMy.Minimum = 0;
            progressBarMy.Maximum = player.maxhealth;
            SetProgressSafe(progressBarMy, player.health);
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

                buttonDamage.Enabled = false;
                label1.Size = new Size(120, 30);
                label1.ForeColor = Color.Red;
                label1.TextAlign = ContentAlignment.TopLeft;
                label1.Text = " VICTORY!";
                SoundPlayer victory = new SoundPlayer(@"C:\Users\Вадим\Downloads\the-sound-of-victory-winning.wav");
                victory.Play();
            }
        }

        private void SetProgressSafe(ProgressBar bar, int value)
        {
            if (value < bar.Minimum) value = bar.Minimum;
            if (value > bar.Maximum) value = bar.Maximum;

            if (value == bar.Maximum && value != bar.Minimum)
                value -= 1;

            bar.Value = value;
        }

        private void fight_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonDamage_Click_1(object sender, EventArgs e)
        {
            SoundPlayer hit = new SoundPlayer(@"C:\Users\Вадим\Downloads\impact-sound.wav");
            hit.Play();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fight = new fight();
            fight.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

    // Простые классы, которые реализуют интерфейс
    public class SimpleEnemy : Ifighter
    {
        public int health => 100;
        public int maxhealth => 100;
        public string name => "Enemy";
    }

    public class SimplePlayer : Ifighter
    {
        public int health => 150;
        public int maxhealth => 150;
        public string name => "Player";
    }
}