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

            int RPI = RP.Next(0, trainer.Belt.Count); // Use RP for random number generation

            // Find an unused Pokeball
            while (trainer.Belt[RPI].Used)
            {
                RPI = RP.Next(0, trainer.Belt.Count);
            }

            // Mark the Pokeball as used
            trainer.Belt[RPI].used = true;

            Console.WriteLine(trainer.Name + " Throws his pokeball with: " + trainer.Belt[RPI].Pokemon.Name + "\n");


            return (Pokemon)trainer.Belt[RPI].Pokemon;

        }
        public void ElementalBattle()
        {
            // Call ThrowBall for both trainers to choose their Pokémon
            Console.WriteLine("Battle: " + Arena.BattlesUp());

            string LastWinner = "";
            Pokemon pokemon1 = ThrowBall(trainer1);
            Pokemon pokemon2 = ThrowBall(trainer2);
            bool tie = false;
           

            while (!trainer1.Belt.All(p => p.Used) && !trainer2.Belt.All(p => p.Used)){
                Console.WriteLine("Round: " + Arena.RoundUp());
   
                if (tie == true){
                    if(LastWinner != trainer1.Name)
                    {
                        pokemon2 = ThrowBall(trainer2);
                        LastWinner = trainer1.Name;
                        tie = false;

                    }
                    else if (LastWinner != trainer2.Name)
                    {
                        pokemon1 = ThrowBall(trainer1);
                        LastWinner = trainer2.Name;
                        tie = false;

                    }
                }
                else if (LastWinner != trainer1.Name && LastWinner != "")
                {
                    pokemon1 = ThrowBall(trainer1);

                }
                else if (LastWinner != trainer2.Name && LastWinner != "")
                {
                    pokemon2 = ThrowBall(trainer2);
                }
                
                    Console.WriteLine("Pokemons on board : Trainer's " + trainer1.Name + " pokemon : " + pokemon1.Name + " Trainer's " + trainer2.Name + " Pokemon : " + pokemon2.Name + "\n");
                    // Determine the winner based on the elemental advantage
                    if ((pokemon1.Type == PokemonType.Fire && pokemon2.Type == PokemonType.Grass)  ||
                        (pokemon1.Type == PokemonType.Grass && pokemon2.Type == PokemonType.Water) ||
                        (pokemon1.Type == PokemonType.Water && pokemon2.Type == PokemonType.Fire))
                    {
                        Console.WriteLine(trainer1.Name + " wins the elemental battle!");
                        LastWinner = trainer1.Name;


                    }
                    else if ((pokemon2.Type == PokemonType.Fire && pokemon1.Type == PokemonType.Grass) ||
                             (pokemon2.Type == PokemonType.Grass && pokemon1.Type == PokemonType.Water) ||
                             (pokemon2.Type == PokemonType.Water && pokemon1.Type == PokemonType.Fire))
                    {
                        Console.WriteLine(trainer2.Name + " wins the elemental battle!");
                        LastWinner = trainer2.Name;
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


