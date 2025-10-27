// Абстрактный класс воина
using System.Xml.Linq;
using WinFormsApp1;

internal abstract class Warrior : Person
{
    public int Armor { get; protected set; }

    public Warrior(string name, int level = 1, int armor = 10) : base(name, level)
    {
        Armor = armor;
        MaxHealth = 120 + (level - 1) * 10;
        Health = MaxHealth;
        Damage = 7;
    }

    public void Block()
    {
        Console.WriteLine($"{Name} поднимает щит и блокирует часть урона! 🛡️");
    }

    public override void TakeDamage(int damage)
    {
        int reducedDamage = Math.Max(1, damage - Armor);
        Console.WriteLine($"Броня поглощает часть урона! Входящий урон: {damage} -> {reducedDamage}");
        base.TakeDamage(reducedDamage);
    }
}


// Абстрактный класс лучника
internal abstract class Archer : Person
{
    public int Arrows { get; protected set; }

    public Archer(string name, int level = 1, int arrows = 15) : base(name, level)
    {
        Arrows = arrows;
        MaxHealth = 90 + (level - 1) * 8;
        Health = MaxHealth;
        Damage = 8;
    }

    public void AddArrows(int count)
    {
        Arrows += count;
        Console.WriteLine($"{Name} получил {count} стрел. Теперь всего: {Arrows}");
    }

    public override void Attack(Person target)
    {
        if (Arrows <= 0)
        {
            Console.WriteLine($"{Name} пытается выстрелить, но стрелы закончились!");
            return;
        }

        Arrows--;
        Console.WriteLine($"{Name} выпускает стрелу в {target.Name}! 🏹 Урон: {Damage} (Осталось стрел: {Arrows})");
        target.TakeDamage(Damage);
    }
}



// Абстрактный класс мага
internal abstract class Mage : Person
{
    public int Mana { get; protected set; }
    public int MaxMana { get; protected set; }

    public Mage(string name, int level = 1, int mana = 50) : base(name, level)
    {
        MaxMana = mana + (level - 1) * 5;
        Mana = MaxMana;
        MaxHealth = 80 + (level - 1) * 8;
        Health = MaxHealth;
        Damage = 6;
    }

    public void CastSpell(Person target)
    {
        if (Mana >= 10)
        {
            Mana -= 10;
            int spellDamage = Damage + 15 + Level;
            Console.WriteLine($"{Name} использует магию против {target.Name}! 🔥 Урон: {spellDamage} (Осталось маны: {Mana})");
            target.TakeDamage(spellDamage);
        }
        else
        {
            Console.WriteLine($"{Name} не хватает маны для заклинания!");
        }
    }

    public void RestoreMana(int amount)
    {
        Mana = Math.Min(Mana + amount, MaxMana);
        Console.WriteLine($"{Name} восстановил {amount} маны. Теперь: {Mana}/{MaxMana}");
    }
}
