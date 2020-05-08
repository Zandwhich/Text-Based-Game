/*
 * Author: Alex Zdanowicz
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Test
{
    // The class that deals with inventories
    class Inventory
    {
        /* Fields */

        // The amount of spaces in this inventory
        private int numSpaces;

        // The array that holds all of the items
        Object[] items;



        /* Constructors */

        // The constructor for the inventory
        public Inventory(int spaces)
        {
            this.numSpaces = spaces;
            this.items = new Object[this.numSpaces];
        }//end Inventory()



        /* Methods */

        // Returns the amount of spaces in the inventory
        public int GetNumSpaces()
        {
            return this.numSpaces;
        }//end GetSpaces()

        // Returns the items as an Object array
        public Object[] GetItems()
        {
            return this.items;
        }//end GetItems()

        // Returns the object at a specific index
        // Returns an out-of-bounds error if the index is out of bounds
        public Object GetObjectAtIndex(int index)
        {
            return this.items[index];
        }//end GetObjectIndex()

        // Removes the object at a specific index
        // Returns an out-of-bounds error if the index is out of bounds
        public void RemoveObjectAtIndex(int index)
        {
            this.items[index] = null;
        }//end RemoveObjectAtIndex()

        // Returns then removes an object at a specific index
        // Returns an out-of-bounds error if the index is out of bounds
        public Object PopObjectAtIndex(int index)
        {
            Object temp = this.GetObjectAtIndex(index);
            this.RemoveObjectAtIndex(index);
            return temp;
        }//end PopObjectAtIndex()

        // Returns the index of a given object in the items list in the inventory
        // Returns -1 if the object is not in the inventory
        public int IndexOfObject(Object obj)
        {
            for (int i = 0; i < this.numSpaces; i++)
            {
                if (this.items[i] == obj) return i;
            }//end for

            return -1;
        }//end IndexOfObject()

        // Removes a given object from the inventory
        // Throws an error if the object doesn't exist (as an out-of-bounds error)
        public void RemoveObject(Object obj)
        {
            this.RemoveObjectAtIndex(this.IndexOfObject(obj));
        }//end RemoveObject()

    }//end Inventory
}//end ConsoleApp_Test
