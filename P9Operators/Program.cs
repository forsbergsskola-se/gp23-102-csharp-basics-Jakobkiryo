﻿// See https://aka.ms/new-console-template for more information
//P9Operators
// Welcome to mintues to seconds converter
// print the result of converting the value to secon

//How to convert mintues in to seconds:
// P9Operators:

Console.WriteLine("Welcome to minutes to seconds converter");

Console.WriteLine("Please enter a value in minutes");

string userInput = Console.ReadLine();

int usernumber = int.Parse(userInput);

int x = usernumber * 60;

Console.WriteLine($"That would be {x} seconds");