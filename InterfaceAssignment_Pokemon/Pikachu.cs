using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment_Pokemon
{
    internal class Pikachu : IPokemon
    {
        public int Health { get; set; }

        public Pikachu(int health)
        {
            Health = health;
        }

        public void LooseHealth()
        {
            Health -= new Random().Next(0, 21);
        }
        public void Attack(IPokemon opponent)
        {
            Zap(opponent);
        }
        public void Zap(IPokemon opponent)
        {
            opponent.LooseHealth();
        }
    }
}
