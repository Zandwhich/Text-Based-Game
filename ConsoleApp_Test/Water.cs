/*
 * Author: Alex Zdanowicz
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Test
{
    // The water object that can be consumed by the player
    class Water : Object
    {
        /* Fields */

        // The name of water
        public static readonly string NAME = "water";

        /* Constructors */

        public Water(double value) : base(Water.NAME) { }

        /* Methods */


        public override void Use(object obj)
        {
            throw new NotImplementedException();
        }
    }//end Water
}//end ConsoleApp_Test
