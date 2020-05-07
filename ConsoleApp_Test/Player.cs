using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Test
{
    // The class that defines the player
    class Player
    {

        // The name of the player
        private string name;

        // The health of the player
        private double health;


        // The constructor of the player
        public Player(string name)
        {
            this.name = name;
            this.health = 100;
        }//end Player()
        

        // Returns the name of the player
        public string getName()
        {
            return this.name;
        }//end getName()

        // Returns the health of the player
        public double getHealth()
        {
            return this.health;
        }//end getHealth()

        // Returns if the player is dead or not
        public bool isDead()
        {
            if (this.health <= 0) return true;
            return false;
        }//end isDead()
    }//end Player
}//end ConsoleApp_Test
