using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Test
{
    // The class that defines the player
    class Player
    {
        // The default number of spaces for the inventory
        public static readonly int NUM_INVENTORY_SPACES = 10;

        // The name of the player
        private string name;

        // The health of the player
        private double health;

        // The inventory of the player
        private Inventory inventory;


        // The constructor of the player
        public Player(string name)
        {
            this.name = name;
            this.health = 100;
            this.inventory = new Inventory(Player.NUM_INVENTORY_SPACES);
        }//end Player()
        

        // Returns the name of the player
        public string GetName()
        {
            return this.name;
        }//end GetName()

        // Returns the health of the player
        public double GetHealth()
        {
            return this.health;
        }//end GetHealth()

        // Returns the inventory of the player
        public Inventory GetInventory()
        {
            return this.inventory;
        }//end GetInventory()

        // Returns if the player is dead or not
        public bool IsDead()
        {
            if (this.health <= 0) return true;
            return false;
        }//end IsDead()
    }//end Player
}//end ConsoleApp_Test
