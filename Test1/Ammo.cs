using System;

namespace Test1
{
    public class Ammo : IEquatable<Ammo>, IComparable<Ammo>
    {
        public string Name { get; private set; }
        public Caliber Caliber { get; private set; }
        public ArmyType ArmyType { get; private set; }
        public DamageType DamageType { get; private set; }
        public bool IsFake { get; private set; }

        public Ammo(string name, Caliber caliber, ArmyType armyType, DamageType damageType, bool isFake)
        {
            Name = name;
            Caliber = caliber;
            ArmyType = armyType;
            DamageType = damageType;
            IsFake = isFake;
        }

        public bool Equals(Ammo other)
        {
            return Caliber.Equals(other.Caliber) &&
                    DamageType.Equals(other.DamageType) &&
                    IsFake == other.IsFake;
        }

        public override string ToString() => Name;

        public int CompareTo(Ammo other)
        {
            if (Equals(other))
            {
                return 0;
            }

            if (Caliber.Diameter < other.Caliber.Diameter)
            {
                return -1;
            }

            return 1;
        }
    }
}
