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

        private static int powerupAmount;

        /// Construtor
        public Foe(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
            powerupAmount = 0;
        }

        public string GetName()
        {
            return name;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public static int GetPowerupAmount()
        {
            return powerupAmount;
        }

        public void SetName(string name)
        {
            this.name = name.Trim();
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStilltoInflict = -shield;
                shield = 0;
                health -= damageStilltoInflict;
                if (health < 0) health = 0;
            }
        }

        public void PickupPowerUp(PowerUp powerup, float amount)
        {
            if (powerup == PowerUp.Health)
            {
                health += amount;
                if (health > 100)
                {
                    health = 100;
                }
            }

            else if (powerup == PowerUp.Shield)
            {
                shield += amount;
                if (shield > 100)
                {
                    shield = 100;
                }
            }
        }
    }
}