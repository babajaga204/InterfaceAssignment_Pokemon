using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InterfaceAssignment_Pokemon
{
    internal class Magikarp : IPokemon

    {
        public int Health { get; set; }
        public bool IsUseless { get; set; }

        public Magikarp(int health, bool isUseless)
        {
            Health = health;
            IsUseless = isUseless;
        }
        public void LooseHealth()
        {
            Health -= new Random().Next(0, 21);
        }

        public void Attack(IPokemon opponent)
        {
            Splash(opponent);
        }

        public void Splash(IPokemon opponent)
        {
            opponent.LooseHealth();
        }
    }
}
