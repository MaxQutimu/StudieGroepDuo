//////////////////////////////////
// Date 02.2024                 //
// Author Maksymilian Ratajczak //
// Pokemon Battle Game          //
//////////////////////////////////

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
        private Random RP = new Random();
        public Battle(Trainer trainer1, Trainer trainer2)
        {

            this.trainer1 = trainer1;
            this.trainer2 = trainer2;
            ElementalBattle();



        }
        public Pokemon ThrowBall(Trainer trainer)
        {

            int RPI = RP.Next(0, trainer.belt.Count); // Use RP for random number generation

            // Find an unused Pokeball
            while (trainer.belt[RPI].used)
            {
                RPI = RP.Next(0, trainer.belt.Count);
            }

            // Mark the Pokeball as used
            trainer.belt[RPI].used = true;

            Console.WriteLine(trainer.name + " Throws his pokeball with: " + trainer.belt[RPI].pokemon.Name + "\n");

            return trainer.belt[RPI].pokemon;

        }
        public void ElementalBattle()
        {
            // Call ThrowBall for both trainers to choose their Pokémon
            Console.WriteLine("Battle: " + Arena.BattlesUp());

            string LastWinner = "";
            Pokemon pokemon1 = ThrowBall(trainer1);
            Pokemon pokemon2 = ThrowBall(trainer2);
            bool tie = false;
           

            while (!trainer1.belt.All(p => p.used) && !trainer2.belt.All(p => p.used)){
                Console.WriteLine("Round: " + Arena.RoundUp());
                if (tie == true){
                    if(LastWinner != trainer1.name)
                    {
                        pokemon2 = ThrowBall(trainer2);
                        LastWinner = trainer1.name;
                        tie = false;

                    }
                    else if (LastWinner != trainer2.name)
                    {
                        pokemon1 = ThrowBall(trainer1);
                        LastWinner = trainer2.name;
                        tie = false;

                    }
                }
                else if (LastWinner != trainer1.name && LastWinner != "")
                {
                    pokemon1 = ThrowBall(trainer1);

                }
                else if (LastWinner != trainer2.name && LastWinner != "")
                {
                    pokemon2 = ThrowBall(trainer2);
                }
                if (pokemon1 != null && pokemon2 != null)
                {
                    Console.WriteLine("Pokemons on board : Trainer's " + trainer1.name + " pokemon : " + pokemon1.Name + " Trainer's " + trainer2.name + " Pokemon : " + pokemon2.Name + "\n");
                    // Determine the winner based on the elemental advantage
                    if ((pokemon1.Type == "Fire" && pokemon2.Type == "Grass") ||
                        (pokemon1.Type == "Grass" && pokemon2.Type == "Water") ||
                        (pokemon1.Type == "Water" && pokemon2.Type == "Fire"))
                    {
                        Console.WriteLine(trainer1.name + " wins the elemental battle!");
                        LastWinner = trainer1.name;


                    }
                    else if ((pokemon2.Type == "Fire" && pokemon1.Type == "Grass") ||
                             (pokemon2.Type == "Grass" && pokemon1.Type == "Water") ||
                             (pokemon2.Type == "Water" && pokemon1.Type == "Fire"))
                    {
                        Console.WriteLine(trainer2.name + " wins the elemental battle!");
                        LastWinner = trainer2.name;
                    }
                    else
                    {
                        Console.WriteLine("It's a tie! No one wins the elemental battle.");
                        tie = true;
                        
                   
                    }
                }
            }
            }
        }
    }


