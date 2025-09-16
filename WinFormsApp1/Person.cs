using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Person
    {
        private string Name;
        private int Level;
        private int health;
        private int damage;
        private int Max_health;


        // создание персонажа
        public Person(string Name, int level = 1)
        {
            this.Name = Name;
            this.Level = level;
            this.health = Max_health;
            damage = 5;
            

        }
        public void take_damage(int damage)
        {
            health = health - damage;
            if (health < 0)
            {
                health = 0;
            }
            Console.WriteLine($"{Name} получает {damage} урона.");
        }

        public void get_health(int value)
        {
            health += value;
            if (health > Max_health)
            {
                health = Max_health;
            }
            Console.WriteLine($"{Name} лечится на {value}");

        }
        public void Level_Up()
        {
            Level++;
            Max_health += 10;
            damage += 5;
            health = Max_health;
            Console.WriteLine($"{Name} повысил уровень до {Level}");
            Console.WriteLine($"теперь у него {Max_health} здоровья и {damage} урона") ;


        }
        public void attack(string Person, string target)
        {
            Console.WriteLine($"{Person} атакует {target}");
        }

    }
}