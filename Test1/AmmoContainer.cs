using System;
using System.Collections;
using System.Collections.Generic;

namespace Test1
{
    class AmmoContainer : IEnumerable
    {
        private List<Ammo> warehouse;

        public void Add(Ammo ammo)
        {
            warehouse.Add(ammo);
        }
        public void Remove(Ammo ammo)
        {
            warehouse.Remove(ammo);
        }
        public List<Ammo> Search(string name)
        {
            return warehouse.FindAll(a => a.Name == name);
        }
        public List<Ammo> Search(Caliber caliber)
        {
            return warehouse.FindAll(a => a.Caliber.Equals(caliber));
        }
        public List<Ammo> Search(DamageType damageType)
        {
            return warehouse.FindAll(a => a.DamageType == damageType);
        }
        public void Sort()
        {
            warehouse.Sort();
        }

        public IEnumerator GetEnumerator()
        {
            return warehouse.GetEnumerator();
        }
    }
}
