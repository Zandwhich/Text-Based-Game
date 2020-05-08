/*
 * Author: Alex Zdanowicz
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Test
{
    // The class that defines the player
    class Player : Person
    {
        // The default number of spaces for the inventory
        public static readonly int NUM_INVENTORY_SPACES = 10;

        // The maximum amount of health for the player
        public static readonly double HEALTH_MAX = 100;

        // The minimum amount of health for the player
        public static readonly double HEALTH_MIN = 0;

        // The maximum amount of hunger for the player
        public static readonly double HUNGER_MAX = 100;

        // The minimum amount of hunger for the player
        public static readonly double HUNGER_MIN = 100;


        // The constructor of the player
        public Player(string name) : base(name, HEALTH_MAX, HEALTH_MAX, HEALTH_MIN, HUNGER_MAX, HUNGER_MAX, HUNGER_MIN, NUM_INVENTORY_SPACES) { }
    }//end Player
}//end ConsoleApp_Test
