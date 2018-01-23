﻿using System;
using static System.Console;

namespace Ch02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88; // storing a double in an object
            object name = "Amir"; // storing a string in an object
            //int length1 = name.Length; // gives compile error!
            int length2 = ((string)name).Length; // cast to access members

            // storing a string in a dynamic object
            dynamic anotherName = "Ahmed";
            // this compiles but might throw an exception at run-time!
            int length = anotherName.Length;

            var population = 66000000;
            var weight = 1.88; // in kilograms
            var price = 4.99M; // in pounds sterling
            var fruit = "Apples"; // strings use double-quotes
            var letter = 'Z'; // chars use single-quotes
            var happy = true; // Booleans have value of true or false

            WriteLine($"{default(int)}"); // 0
            WriteLine($"{default(bool)}"); // False
            WriteLine($"{default(DateTime)}"); // 1/01/0001 00:00:00

            int ICannotBeNull = 4;
            int? ICouldBeNull = null;
            WriteLine(ICouldBeNull.GetValueOrDefault()); // 0
            ICouldBeNull = 4;
            WriteLine(ICouldBeNull.GetValueOrDefault()); // 4 

            // check is myVariable is not null before using it
            if (ICouldBeNull != null)
            {
                // do something with ICouldBeNull
            }

            string authorName = null;
            // if authorName is null, instead of throwing an exception,
            // null is returned
            int? howManyLetters = authorName?.Length;

            // result will be three if howManyLetters is null
            var result = howManyLetters ?? 3;
            WriteLine(result);

            // declaring the size of the array
            string[] names = new string[4];
            // storing items at index positions
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";
            for (int i = 0; i < names.Length; i++)
            {
                WriteLine(names[i]); // read the item at this index
            }

            WriteLine($"The UK population is {population}.");
            Write($"The UK population is {population:N0}. ");
            WriteLine($"{weight}kg of {fruit} costs {price:C}.");

            Write("Type your first name and press ENTER: ");
            string firstName = ReadLine();
            Write("Type the page number you are in and press ENTER: ");
            string pg = ReadLine();
            WriteLine($"Hello {firstName}, your page number is {pg}.");

        }
    }
}