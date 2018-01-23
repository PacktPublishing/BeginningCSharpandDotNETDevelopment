﻿using System;
using static System.Console;
using System.IO;

namespace Ch03_SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Copy into Exercise_if_1.cs 
            if (args.Length == 0) // Condition check
            {
                WriteLine("There are no arguments."); // When condition is true
            }
            else
            {
                WriteLine("There is at least one argument."); //When condition is false
            }
            //End of Exercise_if_1.cs

            object o = 3;
            int j = 4;

            if (o is int i)
            {
                WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                WriteLine("o is not an int so it cannot multiply!");
            }

        A_label:
            var number = (new Random()).Next(1, 7);
            WriteLine($"My random number is {number}");
            switch (number)
            {
                case 1:
                    WriteLine("One");
                    break; // jumps to end of switch statement
                case 2:
                    WriteLine("Two");
                    goto case 1;
                case 3:
                case 4:
                    WriteLine("Three or four");
                    goto case 1;
                case 5:
                    // go to sleep for half a second
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
                default:
                    WriteLine("Default");
                    break;
            } // end of switch statement

            string path = @"C:\Code\Chapter03"; // Windows

            Stream s = File.Open(
                Path.Combine(path, "file.txt"),
            FileMode.OpenOrCreate);

            switch (s)
            {
                case FileStream writeableFile when s.CanWrite:
                    WriteLine("The stream is to a file that I can write to.");
                    break;
                case FileStream readOnlyFile:
                    WriteLine("The stream is to a read-only file.");
                    break;
                case MemoryStream ms:
                    WriteLine("The stream is to a memory address.");
                    break;
                default: // always evaluated last despite its current position
                    WriteLine("The stream is some other type.");
                    break;
                case null:
                    WriteLine("The stream is null.");
                    break;
            }

        }
    }
}