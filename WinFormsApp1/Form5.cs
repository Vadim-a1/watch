using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal partial class Form5 : Form
    {
        private SquadManager squadManager = new SquadManager();
        private Random _rand = new Random();

        public Form5()
        {
            InitializeComponent();

            comboType.Items.Add("Warrior");
            comboType.Items.Add("Archer");
            comboType.SelectedIndex = 0;

            RefreshSquadList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите имя персонажа!");
                return;
            }

            int level = (int)numLevel.Value; // Получаем уровень из NumericUpDown

            Person person;
            if (comboType.SelectedItem.ToString() == "Warrior")
                person = new ConcreteWarrior(name, level);
            else
                person = new Archer(name, level);

            squadManager.AddPerson(person);
            RefreshSquadList();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            // Простая рандомизация имени
            string[] prefixes = { "Ar", "Bel", "Cor", "Dor", "Eli", "Fin", "Gor", "Hal" };
            string[] suffixes = { "on", "en", "ar", "is", "us", "a", "or", "ik" };

            string name = prefixes[_rand.Next(prefixes.Length)] + suffixes[_rand.Next(suffixes.Length)];
            int level = _rand.Next(1, 21); // уровень от 1 до 20

            txtName.Text = name;
            numLevel.Value = level;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите имя для удаления!");
                return;
            }

            squadManager.RemovePerson(name);
            RefreshSquadList();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            squadManager.SortByLevel();
            RefreshSquadList();
        }



        private void RefreshSquadList()
        {
            listSquad.Items.Clear();
            foreach (var person in squadManager.GetSquad())
            {
                listSquad.Items.Add($"{person.Name} (Тип: {person.GetType().Name}, Уровень: {person.Level}, Здоровье: {person.Health})");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fight = new fight();
            fight.Show();
            this.Hide();
        }
    }

    internal class ConcreteWarrior : Warrior
    {
        public ConcreteWarrior(string name, int level = 1) : base(name, level) { }

        public override void UseSpecialAbility()
        {
            // Реализация специальной способности воина
        }

        public override void TakeDamage(int damage)
        {
            Health = Math.Max(Health - damage, 0);
        }

        public override void Attack(IDamageable target)
        {
            target.TakeDamage(Damage);
        }
    }

    internal class Archer : Person
    {
        public Archer(string name, int level = 1) : base(name, level)
        {
            MaxHealth = 100 + (level - 1) * 8;
            Health = MaxHealth;
            Damage = 5;
        }

        public override void UseSpecialAbility()
        {
            // Реализация специальной способности лучника
        }

        public override void TakeDamage(int damage)
        {
            Health = Math.Max(Health - damage, 0);
        }

        public override void Attack(IDamageable target)
        {
            target.TakeDamage(Damage);
        }
    }
}
