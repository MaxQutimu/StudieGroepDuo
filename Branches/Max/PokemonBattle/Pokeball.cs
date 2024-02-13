using System;

namespace PokemonBattle
{
    internal sealed class Pokeball
    {
        private Pokemon _pokemon;
        private bool _isOpen;
        private readonly bool _used;

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
            get { return _used; }
        }

        public Pokeball(Pokemon pokemon)
        {
            _pokemon = pokemon;
            _used = false;
        }

        public void Open()
        {
            if (!_used)
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
