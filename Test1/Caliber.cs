namespace Test1
{
    public class Caliber
    {
        public string Name { get; private set; }
        public double Diameter { get; private set; }
        public double Length { get; private set; }

        public Caliber(string name, double diameter, double length)
        {
            Name = name;
            Diameter = diameter;
            Length = length;
        }
    }
}