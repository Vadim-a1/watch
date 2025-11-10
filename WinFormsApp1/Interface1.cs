using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public interface IAttackable
    {
        void Attack();
        int Damage { get; }
    }

    public interface IDamageable
    {
        void TakeDamage(int damage);
        int Health { get; }
    }

    public interface IHealable
    {
        void Heal(int amount);
    }

    // Классы реализуют нужные интерфейсы
    public class Warrior : IAttackable, IDamageable
    {
        public int Damage => 10;
        public int Health { get; private set; } = 100;

        public void Attack() => Console.WriteLine("Атакую мечом! ⚔️");
        public void TakeDamage(int damage) => Health -= damage;
    }

    public class Healer : IHealable, IDamageable
    {
        public int Health { get; private set; } = 80;

        public void Heal(int amount) => Console.WriteLine("Исцеляю! ✨");
        public void TakeDamage(int damage) => Health -= damage;
    }

    // Система боя работает с интерфейсами
    public class BattleSystem
    {
        public void PerformAttack(IAttackable attacker, IDamageable target)
        {
            attacker.Attack();
            target.TakeDamage(attacker.Damage);
        }

        public void PerformHeal(IHealable healer, IDamageable target)
        {
            healer.Heal(20);
        }
    }
}