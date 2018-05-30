using System;
using System.Collections.Generic;

namespace Test1
{
    public class Ammo : IComparable<Ammo>, IComparable
    {
        public string Name { get; }
        public Caliber Caliber { get; }
        public ArmyType ArmyType { get; }
        public DamageType DamageType { get; }
        public bool IsFake { get; }

        public Ammo(string name, Caliber caliber, ArmyType armyType, DamageType damageType, bool isFake)
        {
            Name = name;
            Caliber = caliber;
            ArmyType = armyType;
            DamageType = damageType;
            IsFake = isFake;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Caliber)}: {Caliber}, {nameof(ArmyType)}: {ArmyType}, {nameof(DamageType)}: {DamageType}, {nameof(IsFake)}: {IsFake}";
        }

        protected bool Equals(Ammo other)
        {
            return string.Equals(Name, other.Name) && Equals(Caliber, other.Caliber) && ArmyType == other.ArmyType && DamageType == other.DamageType && IsFake == other.IsFake;
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Ammo) obj);
        }

        public int CompareTo(Ammo other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (other is null) return 1;
            return Comparer<Caliber>.Default.Compare(Caliber, other.Caliber);
        }

        public int CompareTo(object obj)
        {
            if (ReferenceEquals(null, obj)) return 1;
            if (ReferenceEquals(this, obj)) return 0;
            if (!(obj is Ammo)) throw new ArgumentException($"Object must be of type {nameof(Ammo)}");
            return CompareTo((Ammo) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Caliber != null ? Caliber.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int) ArmyType;
                hashCode = (hashCode * 397) ^ (int) DamageType;
                hashCode = (hashCode * 397) ^ IsFake.GetHashCode();
                return hashCode;
            }
        }
    }
}
