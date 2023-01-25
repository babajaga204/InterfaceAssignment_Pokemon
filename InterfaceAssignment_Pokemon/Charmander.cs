using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment_Pokemon
{
    internal class Charmander : IPokemon
    {
        public int Health { get; set; }

        public Charmander(int health)
        {
            Health = health;
        }

        public void LooseHealth()
        {
            Health -= new Random().Next(0, 21);
        }

        public void Attack(IPokemon opponent)
        {
            Blaze(opponent);
        }

        public void Blaze(IPokemon opponent)
        {
            opponent.LooseHealth();
        }
    }
}
