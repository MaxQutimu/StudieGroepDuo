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
    internal class Pokeball
    {
        public Pokemon pokemon;
        public bool isOpen;
        public bool used;
        public Pokeball(Pokemon pokemon) {
            this.pokemon = pokemon;
            this.used = false;
        }
        public void Open()
        {
            isOpen = true;
        }

        public void Close()
        {
            isOpen = false;
        }

        public bool IsOpen()
        {
            return isOpen;
        }

    }
}
