namespace WinFormsApp1
{
    // Абстрактный базовый класс
    internal abstract class Person
    {
        public string Name { get; protected set; }
        public int Level { get; protected set; }
        public int Health { get; protected set; }
        public int MaxHealth { get; protected set; }
        public int Damage { get; protected set; }

        public Person(string name, int level)
        {
            Name = name;
            Level = level;
        }

        public void Heal(int amount)
        {
            Health = Math.Min(MaxHealth, Health + amount);
        }

        // Абстрактный метод - должен быть реализован в наследниках
        public abstract void UseSpecialAbility();
        public abstract void TakeDamage(int damage);
        public abstract void Attack(IDamageable target);
    }
}