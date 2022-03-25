// Created by: Ava Venturino
// Created on: March 22 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function acc2epts user input
        int Base;
        int Height;

        Console.WriteLine("This program finds the area of a triangle.");
        Console.WriteLine("");
        Console.Write("Enter the base of the triangle (mm): ");
        Base = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height of the triangle (mm): ");
        Height = Convert.ToInt32(Console.ReadLine());

        Double Area = (Base * Height) /2;

        Console.WriteLine("");
        Console.Write("Area of the triangle = " + Area + " mm²");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}