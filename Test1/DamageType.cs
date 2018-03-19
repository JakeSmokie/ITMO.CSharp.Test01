using System;

namespace Test1
{
    [Flags]
    public enum DamageType : int
    {
        HighExplosive = 1 << 0,
        Tracing = 1 << 1,
        Mine = 1 << 2,
        ArmourPiercing = 1 << 3,
        AntiTank = 1 << 4,
        Shrapnel = 1 << 5,
        Chemical = 1 << 6
    }
}