// Created by: Zaida Hammel
// Created on: May 2020
// This file contains the JS functions for index.html

using System;

class Program
{
    public static void Main(string[] args)
    {
    
        int counter1 = 0;
        int counter2 = 0;
        var addedNumber = 0;
        var answer = counter1;

        Console.Write("Input a number: ");
        counter1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a number: ");
        counter2 = Convert.ToInt32(Console.ReadLine());
        
        if (counter1 > 0 && counter2 > 0)
        {
            while (answer >= counter2)
            {
                addedNumber = addedNumber + 1;
                answer = answer - counter2;
            }
        }

        Console.WriteLine("The answer is: " + counter1 + " ÷ " + counter2 + " = " + addedNumber);
    }
}