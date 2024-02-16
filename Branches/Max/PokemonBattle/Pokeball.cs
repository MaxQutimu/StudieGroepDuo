using System;

namespace PokemonBattle
{
    class Pokeball
    {
        private Pokemon _pokemon;
        private bool _isOpen;
        internal bool used;

        public Pokemon Pokemon
        {
            get { return _pokemon; }
        }

        public bool IsOpen
        {
            get { return _isOpen; }
        }

        public bool Used
        {
            get { return used; }
        }

        public Pokeball(Pokemon pokemon)
        {
            _pokemon = pokemon;
            used = false;
        }

        public void Open()
        {
            if (!used)
            {
                _isOpen = true;
            }
            else
            {
                Console.WriteLine("Cannot open a used pokeball.");
            }
        }

        public void Close()
        {
            _isOpen = false;
        }
    }
}
