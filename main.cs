// Created by: Ava Venturino
// Created on: March 22 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int Length;
        int Width;

        Console.WriteLine("This program finds the area of a rectangle.");
        Console.WriteLine("");
        Console.Write("Enter the length of the rectangle (mm²):");
        Length = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the width of the rectangle (mm): ");
        Width = Convert.ToInt32(Console.ReadLine());

        Area = Length * Width;
        Perimeter = 2 * (Length + Width);

        Console.Write("Area of the rectangle = " + Area + "mm²" );
        Console.Write("Perimeter of the rectangle = " + Perimeter + "mm" );
    
        Console.WriteLine("\nDone.");
    }
}