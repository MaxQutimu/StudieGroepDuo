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

       
        // Create a List
        List<Pokeball> belt1 = new List<Pokeball>
        {
            new Pokeball(charmander_Flamey),
            new Pokeball(bulbasaur_Grassy),
            new Pokeball(Squirtle_watery),
            new Pokeball(charmander_Flamey),
            new Pokeball(bulbasaur_Grassy),
            new Pokeball(Squirtle_watery)
        };

        List<Pokeball> belt2 = new List<Pokeball>
        {
            new Pokeball(charmander_Flamey),
            new Pokeball(bulbasaur_Grassy),
            new Pokeball(Squirtle_watery),
            new Pokeball(charmander_Flamey),
            new Pokeball(bulbasaur_Grassy),
            new Pokeball(Squirtle_watery)
        };

        // Create instances of Trainers using constructor
        Trainer TrainerOne = new Trainer("", belt1);
        Trainer TrainerTwo = new Trainer("", belt2);
       
        // Giving names to trainers
        Console.WriteLine("Giva a name to first trainer");
        TrainerOne.name = Console.ReadLine();
        Console.WriteLine("Giva a name to second trainer");
        TrainerTwo.name = Console.ReadLine();

        Battle battleOne = new Battle(TrainerOne, TrainerTwo);

      
       
    }
}


