/*
 * Author: Alex Zdanowicz
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Test
{
    // The generic people found throughout the game.
    // The Player object extends this person
    abstract class Person
    {
        /* Fields */

        // The name of the person
        private string name;

        // The health of the person
        private double health;

        // The maximum health of this person
        private double health_max;

        // The minimum health of this person
        private double health_min;

        // The level of hunger the person feels
        private double hunger;

        // The maximum level of hunger of this person
        private double hunger_max;

        // The minimum level of hunger of this person
        private double hunger_min;

        // The inventory of the person
        private Inventory inventory;

        
        /* Constructors */

        public Person(string name, double health, double health_max, double health_min, double hunger, double hunger_max, double hunger_min, int inventory_size)
        {
            this.name = name;
            this.health = health;
            this.health_max = health_max;
            this.health_min = health_min;
            this.hunger = hunger;
            this.hunger_max = hunger_max;
            this.hunger_min = hunger_min;
            this.inventory = new Inventory(inventory_size);
        }//end Person()

        
        /* Methods */

        // Returns the name of the person
        public string GetName()
        {
            return this.name;
        }//end GetName()

        // Returns the health of the person
        public double GetHealth()
        {
            return this.health;
        }//end GetHealth()

        // Returns the max health of this person
        public double GetHealth_Max()
        {
            return this.health_max;
        }//end GetHealth_Max()

        // Returns the minimum health of this person
        public double GetHealth_Min()
        {
            return this.health_min;
        }//end GetHealth_Min()

        // Returns the level of hunger of this person
        public double GetHunger()
        {
            return this.hunger;
        }//end GetHunger()

        // Returns the maximum level of hunger for this person
        public double GetHunger_Max()
        {
            return this.hunger_max;
        }//end GetHunger_Max()

        // Returns the minimum level of hunger for this person
        public double GetHunger_Min()
        {
            return this.hunger_min;
        }//end GetHunger_Min()

        // Returns the inventory of this person
        public Inventory GetInventory()
        {
            return this.inventory;
        }//end GetInventory()


        // Returns if this perosn is dead or not (their health is equal to or below their minimum health)
        public bool IsDead()
        {
            return this.health <= this.health_min;
        }//end IsDead()
    }//end Person
}//end ConsoleApp_Test
