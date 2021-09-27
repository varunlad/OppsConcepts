using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPSPracticeProblems
{
    public class program
    {
        // private variables declared
        // these can only be accessed by
        // public methods of class
        private String studentName;
        private int studentAge;

        // using accessors to get and 
        // set the value of studentName
        public String Name { get; set; }
        // using accessors to get and 
        // set the value of studentAge
        public int Age { get; set; }
        // Driver Class
        class GFG
        {
            // Main Method
            static public void Main()
            {

                // creating object
                program obj = new program();

                // calls set accessor of the property Name, 
                // and pass "Varun" as value of the 
                // standard field 'value'
                obj.Name = "Varun";

                // calls set accessor of the property Age, 
                // and pass "21" as value of the 
                // standard field 'value'
                obj.Age = 21;

                // Displaying values of the variables
                Console.WriteLine("Name: " + obj.Name);
                Console.WriteLine("Age: " + obj.Age);
            }
        }
    }
}