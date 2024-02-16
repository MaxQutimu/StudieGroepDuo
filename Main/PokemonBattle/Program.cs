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

        // Giving names to trainers
        Console.WriteLine("Giva a name to first trainer");
        string NameOne = Console.ReadLine();
        Console.WriteLine("Giva a name to second trainer");
        string NameTwo = Console.ReadLine();
        // Create instances of Trainers using constructor
        Trainer TrainerOne = new Trainer(NameOne, belt1);
        Trainer TrainerTwo = new Trainer(NameTwo, belt2);
       
        
        Arena arena = new Arena();
        arena.ArenaBattle(TrainerOne, TrainerTwo);



    }
}


