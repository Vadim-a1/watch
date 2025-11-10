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
        public bool IsAlive => Health > 0;

        public Person(string name, int level = 1)
        {
            Name = name;
            Level = level;
        }

        // Абстрактный метод - должен быть реализован в наследниках
        public abstract void UseSpecialAbility();

        // Виртуальный метод - может быть переопределен в наследниках
        public virtual void TakeDamage(int damage)
        {
            Health = Math.Max(0, Health - damage);

            
        }

        public virtual void Attack(Person target)
        {
            target.TakeDamage(Damage);
        }

        public void Heal(int amount)
        {
            Health = Math.Min(MaxHealth, Health + amount);
        }
    }
}