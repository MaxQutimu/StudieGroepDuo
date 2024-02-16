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
    public enum PokemonType
    {
        Water,
        Grass,
        Fire,
    }

    public enum Strength
    {
        Fire,
        Water,
        Grass,
    }

    public enum Weakness
    {
        Fire,
        Grass,
        Water,
    }
    abstract class Pokemon
    {
        // Properties with private setters for encapsulation
        public string _name;
        public string _nickname;
        private PokemonType _type;
        private Strength _strength;
        private Weakness _weakness;

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public string Nickname
        {
            get { return _nickname; }
            private set { _nickname = value; }
        }

        public PokemonType Type
        {
            get { return _type; }
            private set { _type = value; }
        }

        public Strength Strength
        {
            get { return _strength; }
            private set { _strength = value; }
        }

        public Weakness Weakness
        {
            get { return _weakness; }
            private set { _weakness = value; }
        }

        protected Pokemon(string name, string nickname, PokemonType type, Strength strength, Weakness weakness)
        {
            Name = name;
            Nickname = nickname;
            Type = type;
            Strength = strength;
            Weakness = weakness;
        }
        public abstract string battleCry();
        // Method to display Pokemon information
        static void DisplayPokemonInfo(Pokemon pokemon)
        {
            Console.WriteLine("Pokemon Name: " + pokemon.Name);
            Console.WriteLine("   Pokemon Type: " + pokemon.Type);
            Console.WriteLine("   Pokemon Strength: " + pokemon.Strength);
            Console.WriteLine("   Pokemon Weakness: " + pokemon.Weakness);
        }

        // Method to choose player's pokemon name

        static void ChooseName(Pokemon pokemon)
        {
            Console.WriteLine("Choose a name for your pokemon");
            while (true)
            {
                string ChosenName = Console.ReadLine();
                Console.WriteLine("Your chose a name for your pokemon: " + ChosenName);
                Console.WriteLine("Are you sure you want your pokemon to be named: " + ChosenName + " (Yes/No)");
                string ChoiceConfirmation = Console.ReadLine().ToLower();

                if (ChoiceConfirmation == "yes")
                {
                    pokemon.Nickname = ChosenName;
                    break;
                }
                else if (ChoiceConfirmation == "no")
                {
                    Console.WriteLine("Choose a name for your pokemon");
                }
                else
                {
                    Console.WriteLine("Error try again");

                }
            }
        }

    }
    class Squirtle : Pokemon
    {
        public Squirtle(string nickname) : base("Squirtle",nickname,"Water","Fire, Water, Ice , Steel","Electric, Grass") { 
        }

        public override string battleCry()
        {
        return this.Name + " Uses Battle cry: " + this.Nickname;
        }
    } 
    class Bulbasaur : Pokemon
    {
        public Bulbasaur(string nickname) : base("Bulbasaur", nickname,"Grass","Water, Ground, Rock, Grass","Fire,Ice,Flying,Psychic") { 
        }

        public override string battleCry()
        {
        return this.Name + " Uses Battle cry: " + this.Nickname;
        }
    }
    class Charmander : Pokemon
    {
        public Charmander(string nickname) : base("Charmander", nickname,"Fire","Bug, Fairy, Fire, Grass, Ice, Steel","Ground, Rock, Water") { 
        }

        public override string battleCry()
        {
        return this.Name + " Uses Battle cry: " + this.Nickname;
        }
    }
}
