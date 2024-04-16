using System;
using System.Text.RegularExpressions;
// Written in C#
// Author: Grayson Burke 

// I used ChatGPT for this regex expression; Allows for any amount of whole number inputs 
string pattern = "^[0-9]+$";

// First user input only allowd for whole number inputs
// Verified using a regex pattern
// If the inptu is valid it continues; if not valid program exits
Console.Write("Input 1: ");
string inputOne = Console.ReadLine();
if (Regex.IsMatch(inputOne, pattern) == false)
{
    Console.WriteLine("Exit Program");
    return;
}

// Second user input only allowd for whole number inputs
// Verified using a regex pattern
// If the inptu is valid it continues; if not valid program exits
Console.Write("Input 2: ");
string inputTwo = Console.ReadLine();
if (Regex.IsMatch(inputTwo, pattern) == false)
{
    Console.WriteLine("Exit Program");
    return;
}

// Takes the 2 user inputs and adds them together 
int sum = Convert.ToInt32(inputOne) + Convert.ToInt32(inputTwo);

Console.WriteLine($"Sum of inputs: {sum}");

Recursion(sum);

// Where the Recursion Method is defined
// Takes sum as a perameter
static void Recursion(int sum)
{
    // Converts sum to a char array so the individual digits can be manipulated
    char[] charSum = sum.ToString().ToCharArray();

    // Stores the last index in the char array 
    int lastInt = Convert.ToInt32(charSum[charSum.Count() - 1].ToString());
   

    // Temp string variable because I need to concatinate the numbers instead of mathematically adding them 
    string strSum = "";

    // Concatinates the numbers from charSum excluding the last index in the array
    for (int i = 0; i < charSum.Length - 1; i++)
    {
        strSum += charSum[i];
    }

    // Converts the temp string variable into an int 
    int intSum = Convert.ToInt32(strSum);

    // Sets sum equal to the new value 
    sum = intSum + lastInt;

    // Checks to see if there is one digit left
    // If > one digit make a recursive call and continue the process
    // If = one digit exit the program and display the final result
    if (sum >= 0 && sum <= 9)
    {
        Console.WriteLine("********************");
        Console.WriteLine($"Program Complete\nFinal sum: {sum}");
        return;
    }
    else
    {
        Console.WriteLine("********************");
        Console.WriteLine($"Program Complete\nFinal sum: {sum}");
        Recursion(sum);
    }
}

