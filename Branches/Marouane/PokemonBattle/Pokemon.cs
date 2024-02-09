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
    abstract class Pokemon
    {
        // Properties with private setters for encapsulation
        public string Name;
        public string Nickname;
        public string Type;
        public string Strength;
        public string Weakness;

        // Constructor to initialize Pokemon properties
        public Pokemon(string name, string nickname, string type, string strength, string weakness)
        {
            this.Name = name;
            this.Nickname = nickname;
            this.Type = type;
            this.Strength = strength;
            this.Weakness = weakness;
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
