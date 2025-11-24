using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal partial class Form5 : Form
    {
        private SquadManager squadManager = new SquadManager();

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

            Person person;
            if (comboType.SelectedItem.ToString() == "Warrior")
                person = new ConcreteWarrior(name);
            else
                person = new Archer(name);

            squadManager.AddPerson(person);
            RefreshSquadList();
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string type = comboType.SelectedItem.ToString();

            if (type == "Warrior")
                squadManager.FilterByType<ConcreteWarrior>();
            else
                squadManager.FilterByType<Archer>();
        }

        private void RefreshSquadList()
        {
            listSquad.Items.Clear();
            foreach (var person in squadManager.GetSquad())
            {
                listSquad.Items.Add($"{person.Name} (Тип: {person.GetType().Name}, Уровень: {person.Level}, Здоровье: {person.Health})");
            }
        }
    }

    internal class ConcreteWarrior : Warrior
    {
        public ConcreteWarrior(string name) : base(name) { }

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
