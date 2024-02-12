using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Arena
    {
        static int Rounds = 0;
        static int Battles = 0;
        public Trainer trainer1;
        public Trainer trainer2;
        public void ArenaBattle(Trainer trainer1, Trainer trainer2)  
        {
            this.trainer1 = trainer1;
            this.trainer2 = trainer2;
            Battle battleOne = new Battle(trainer1, trainer2);
            
        }
        

        public static int RoundUp()
        {
            Rounds ++;
            return Rounds;
        }
        public static int BattlesUp() {
            Battles++;
            return Battles;
        }
    }
    
}
