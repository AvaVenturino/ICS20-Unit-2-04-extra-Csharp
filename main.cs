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
        int baseOfTriangle;
        int heightOfTriangle;

        Console.WriteLine("This program finds the area of a triangle.");
        Console.WriteLine("");
        Console.Write("Enter the base of the triangle: ");
        double baseOfTriangle = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height of the triangle: ");
        double heightOfTriangle = Console.ReadLine();

        double Area = ( baseOfTriangle * heightOfTriangle) / 2;


        Console.WriteLine("");
        Console.WriteLine("Your address is: " + streetNumber + " " + streetName + ".");

        Console.WriteLine("\nDone.");
    }
}