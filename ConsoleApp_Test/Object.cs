/*
 * Author: Alex Zdanowicz
 */

using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ConsoleApp_Test
{
    // The generic object that can be placed in inventories and used
    abstract class Object
    {

        // The name of the object
        private string name;

        // The value of the object
        private double value;


        // The constructor for the object
        public Object(string name)
        {
            this.name = name;
        }//end Object()


        // Returns the name of the object
        public string GetName()
        {
            return this.name;
        }//end GetName()

        // Returns the value of the object
        public double GetValue()
        {
            return this.value;
        }//end GetValue()

        // Checks to see if this Object and another Objects have variables with the same values
        public bool Equals(Object obj)
        {
            return this.name.Equals(obj.GetName()) && this.value == obj.GetValue();
        }//end Equals()

        // The generic 'Use' method for the object
        // The object that is passed in is the item that the item is "used on"
        abstract public void Use(object obj);
    }//end Object
}//end ConsoleApp_Test
