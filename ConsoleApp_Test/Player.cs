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


        // The constructor of the player
        public Player(string name)
        {
            this.name = name;
        }//end Player()
        

        // Returns the name of the player
        public string getName()
        {
            return this.name;
        }//end getName()
    }//end Player
}//end ConsoleApp_Test
