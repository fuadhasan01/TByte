using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{



    public class StringManipulation
    {
        static void Main(String[] args)
        {
            int myAge = 42;
            string myName = "Fuad";
            string myJob = "Student";
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hey! It is " + myName + " . I am " + myAge + " I am a " + myJob);

            Console.WriteLine("String Indexing Format");
            Console.WriteLine("Hey! It is {0} . I am {1} I am a {2}", myName, myAge, myJob);

            Console.WriteLine("String Interpolation");
            Console.WriteLine("Hey! It is {myName} . I am {myAge} I am a {myJob}");
        }
    }
}
