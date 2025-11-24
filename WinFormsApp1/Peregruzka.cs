using System;

namespace GameExample
{
    class Weapon
    {
        
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Damage { get; set; }

        
        public Weapon(string name, double weight, int damage)
        {
            Name = name;
            Weight = weight;
            Damage = damage;
        }

        // Перегрузка операторов сравнения по урону
        public static bool operator >(Weapon w1, Weapon w2)
        {
            return w1.Damage > w2.Damage;
        }

        public static bool operator <(Weapon w1, Weapon w2)
        {
            return w1.Damage < w2.Damage;
        }

        public static bool operator >=(Weapon w1, Weapon w2)
        {
            return w1.Damage >= w2.Damage;
        }

        public static bool operator <=(Weapon w1, Weapon w2)
        {
            return w1.Damage <= w2.Damage;
        }

        public static bool operator ==(Weapon w1, Weapon w2)
        {
            
            if (ReferenceEquals(w1, null) && ReferenceEquals(w2, null)) return true;
            if (ReferenceEquals(w1, null) || ReferenceEquals(w2, null)) return false;

            return w1.Damage == w2.Damage;
        }

        public static bool operator !=(Weapon w1, Weapon w2)
        {
            return !(w1 == w2);
        }

        //
        public override bool Equals(object obj)
        {
            if (obj is Weapon other)
                return this.Damage == other.Damage;
            return false;
        }

        public override int GetHashCode()   
        {
            return Damage.GetHashCode();
        }

        
        public static implicit operator double(Weapon w)
        {
            return w.Weight;
        }

        
        public override string ToString()
        {
            return $"{Name} (Вес: {Weight}, Урон: {Damage})";
        }
    }

    
}