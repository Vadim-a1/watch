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


    public void RestoreMana(int amount)
    {
        Mana = Math.Min(Mana + amount, MaxMana);
    }
}
