//////////////////////////////////
// Date 02.2024                 //
// Author Maksymilian Ratajczak //
// Pokemon Battle Game          //
//////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Trainer
    {
        public string name;
        public List<Pokeball> belt;

        public Trainer(string name, List<Pokeball> belt)
        {
            this.name = name;
            this.belt = belt;
        }
    }
}
