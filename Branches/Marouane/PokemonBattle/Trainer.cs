using System;
using System.Collections.Generic;

namespace PokemonBattle
{
    internal class Trainer
    {
        private string _name;
        private readonly List<Pokeball> _belt;

        // Constant to replace magic number
        private const int MaxPokeballsOnBelt = 6;

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public List<Pokeball> Belt
        {
            get { return _belt; }
        }

        // Constructor with parameter validation
        public Trainer(string name, List<Pokeball> belt)
        {
            if (belt.Count > MaxPokeballsOnBelt)
            {
                throw new ArgumentException($"The number of pokeballs on the belt cannot exceed {MaxPokeballsOnBelt}.");
            }

            _name = name;
            _belt = belt;
        }
    }
}
