using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        //Sarah is trying to access her online banking account to check her balance. However, she can't remember her password.
        //After a few unsuccessful attempts, she recalls the correct password and enters it. Write a program that enables Sarah to have access to her online bank account.
        string correctPassword = "cypherCrescent1234";
        Console.WriteLine("Enter User Password: ");
        string userInputPassword = Console.ReadLine();

        if (userInputPassword == correctPassword)
        {
            Console.WriteLine("Login successful. Welcome to your bank account!");
        }
        else
        {
            Console.WriteLine("Incorrect Password. Access denied");
        }

        //If a number is divisible by both 3 and 5, it is considered a multiple of 15. Write a program that checks whether a given number is a multiple of 15.
        Console.Write("Enter any Number: ");
        int givenNumber = int.Parse(Console.ReadLine());

        if (givenNumber % 3 == 0 && givenNumber % 5 == 0)
        {
            Console.WriteLine("It is a multiple of 15");
        }
        else
        {
            Console.WriteLine("It is not a multiple of 15");
        }
    }
}