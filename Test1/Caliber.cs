using System;

namespace Test1
{
    public class Caliber : IComparable<Caliber>, IComparable
    {
        public string Name { get; }
        public double Diameter { get; }
        public double Length { get; }

        public Caliber(string name, double diameter, double length)
        {
            Name = name;
            Diameter = diameter;
            Length = length;
        }

        public int CompareTo(Caliber other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (other is null) return 1;
            return Diameter.CompareTo(other.Diameter);
        }

        public int CompareTo(object obj)
        {
            if (obj is null) return 1;
            if (ReferenceEquals(this, obj)) return 0;
            if (!(obj is Caliber)) throw new ArgumentException($"Object must be of type {nameof(Caliber)}");
            return CompareTo((Caliber) obj);
        }
    }
}