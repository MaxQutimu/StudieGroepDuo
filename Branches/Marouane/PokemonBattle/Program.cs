//////////////////////////////////
// Date 02.2024                 //
// Author Maksymilian Ratajczak //
// Pokemon Battle Game          //
//////////////////////////////////

using System;
using PokemonBattle;
using static System.Net.Mime.MediaTypeNames;

class PokemonBattleProgram
{
    static void Main(string[] args)
    {
        // Create instances of Pokemon using constructor
        Charmander charmander_Flamey = new Charmander("Flamey dude");
        Bulbasaur bulbasaur_Grassy = new Bulbasaur("Grassy dude");
        Squirtle Squirtle_watery = new Squirtle("Wet dude");

        // Create instances of Pokeball using constructor
        Pokeball Flamey_pokeball = new Pokeball(charmander_Flamey);
        Pokeball Grassy_pokeball = new Pokeball(bulbasaur_Grassy);
        Pokeball Wet_pokeball = new Pokeball(Squirtle_watery);

        // Create a List
        List<Pokeball> belt = new List<Pokeball>();

        // Add pokeballs to list
        for (int i = 0; i < 2; i++)
        {
            belt.Add(Flamey_pokeball);
            belt.Add(Grassy_pokeball);
            belt.Add(Wet_pokeball);
        }

        // Create instances of Trainers using constructor
        Trainer TrainerOne = new Trainer("", belt);
        Trainer TrainerTwo = new Trainer("", belt);
        // Giving names to trainers
        Console.WriteLine("Giva a name to first trainer");
        TrainerOne.name = Console.ReadLine();
        Console.WriteLine("Giva a name to second trainer");
        TrainerTwo.name = Console.ReadLine();

        Battle battleOne = new Battle(TrainerOne, TrainerTwo);

      
       
    }
}


