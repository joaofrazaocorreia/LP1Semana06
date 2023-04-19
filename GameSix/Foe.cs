using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSix
{
    public class Foe
    {
        private string name;
        private float health;
        private float shield;

        /// Construtor
        public Foe(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }
    }
}