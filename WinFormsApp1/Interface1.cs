using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public interface IDamageable
    {
        int Health { get; }
        int MaxHealth { get; }
        bool IsAlive { get; }
        void TakeDamage(int damage);
        void Heal(int amount);
    }

    // Интерфейс для любого объекта, который может атаковать
    public interface IAttacker
    {
        int AttackDamage { get; }
        void Attack(IDamageable target);
        bool CanAttack { get; }
    }
    public interface Ifighter
    {
        int health { get; }
        int maxhealth { get; }
    }


}