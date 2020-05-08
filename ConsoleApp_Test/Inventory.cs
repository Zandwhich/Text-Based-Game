using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Test
{
    // The class that deals with inventories
    class Inventory
    {

        // The amount of spaces in this inventory
        private int spaces;

        // The array that holds all of the items
        Object[] items;


        // The constructor for the inventory
        public Inventory(int spaces)
        {
            this.spaces = spaces;
            this.items = new Object[this.spaces];
        }//end Inventory()


        // Returns the amount of spaces in the inventory
        public int GetSpaces()
        {
            return this.spaces;
        }//end GetSpaces()
    }//end Inventory
}//end ConsoleApp_Test
