using System;

namespace Playing_With_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Chaz";
            int myAge = 31;
            char myLetter = 'B';
            bool isMarried = true;
            double isHappy = 100.00;
            decimal exactAge = 31.78m;


            Console.WriteLine($"My name is {myName}. I am {myAge}. My favorite letter is {myLetter}. It is {isMarried}, I am married. I am {isHappy} percent happy. My exact age is {exactAge}.");

        }
    }
}
