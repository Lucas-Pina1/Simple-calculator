﻿using System.Linq.Expressions;

Console.WriteLine("Hello!");
Console.WriteLine("Input the first number: ");
string userFirstNumberInput = Console.ReadLine();
int firstNumber = int.Parse(userFirstNumberInput);

Console.WriteLine("Input the second number: ");
string userSecondNumberInput = Console.ReadLine();
int secondNumber = int.Parse(userSecondNumberInput);

Console.WriteLine("[A]dd ");
Console.WriteLine("[S]ubtract ");
Console.WriteLine("[M]ultiply");

string userOperationChoice = Console.ReadLine();

int result = 0;

if (userOperationChoice == "A" || userOperationChoice == "a")
{
    result = firstNumber + secondNumber;
    Console.WriteLine(firstNumber + " + " + secondNumber + " = " + result);
} else if (userOperationChoice == "S" || userOperationChoice == "s")
{
    result = firstNumber - secondNumber;
    Console.WriteLine(firstNumber + " - " + secondNumber + " = " + result);
} else if (userOperationChoice == "M" || userOperationChoice == "m")
{
    result = firstNumber * secondNumber;
    Console.WriteLine(firstNumber + " * " + secondNumber + " = " + result);
} else 
{
    Console.WriteLine("Invalid option");
}

Console.WriteLine("Press any key to close");

Console.ReadKey();



