﻿namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.Make = "Buick";
            carOne.Model = "Encore";
            carOne.Year = 2019;
            
           Console.WriteLine($"This is a {carOne.Make} {carOne.Model}, made in the year {carOne.Year}.");
        }
    }
}
