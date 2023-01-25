using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment_Pokemon
{
    internal interface IPokemon
    {
        int Health { get; set; }
        void LooseHealth();
        void Attack(IPokemon opponent);
    }
}
