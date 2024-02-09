using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Battle
    {
       public Trainer trainer1;
       public Trainer trainer2;

        public Battle(Trainer trainer1, Trainer trainer2)
        {
            this.trainer1 = trainer1;
            this.trainer2 = trainer2;
           ElementalBattle();
            
            

        }
        public string ThrowBall(Trainer trainer)
        {
            Random RP = new Random(); // RP stands for Random Pokeball
            int RPI = RP.Next(0, 5); // RPI stands for Random Pokeball Int
            Console.WriteLine(trainer.name + " Throws his pokeball with: " + trainer.belt[RPI].pokemon.Name  + "\n");

            return trainer.belt[RPI].pokemon.Type;

        }
        public void ElementalBattle()
        {
            // Call ThrowBall for both trainers to choose their Pokémon

            string LastWinner = "";
            string pokemon1Type = ThrowBall(trainer1);
            string pokemon2Type = ThrowBall(trainer2);
            for (int i = 0; i < 5; i++)
            {
                if (LastWinner != trainer1.name && LastWinner != "")
                {
                    pokemon1Type = ThrowBall(trainer1);
                }
                if (LastWinner != trainer2.name && LastWinner != "")
                {
                    pokemon2Type = ThrowBall(trainer2);
                }

                if (pokemon1Type != null && pokemon2Type != null)
                {
                    // Determine the winner based on the elemental advantage
                    if ((pokemon1Type == "Fire" && pokemon2Type == "Grass") ||
                        (pokemon1Type == "Grass" && pokemon2Type == "Water") ||
                        (pokemon1Type == "Water" && pokemon2Type == "Fire"))
                    {
                        Console.WriteLine(trainer1.name + " wins the elemental battle!");
                        LastWinner = trainer1.name;


                    }
                    else if ((pokemon2Type == "Fire" && pokemon1Type == "Grass") ||
                             (pokemon2Type == "Grass" && pokemon1Type == "Water") ||
                             (pokemon2Type == "Water" && pokemon1Type == "Fire"))
                    {
                        Console.WriteLine(trainer2.name + " wins the elemental battle!");
                        LastWinner = trainer2.name;
                    }
                    else
                    {
                        Console.WriteLine("It's a tie! No one wins the elemental battle.");
                        LastWinner = "none";
                    }
                }
                

            }
        }
        

    }
}
