using System;
using System.Collections.Generic;
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
    }//end Object
}//end ConsoleApp_Test
