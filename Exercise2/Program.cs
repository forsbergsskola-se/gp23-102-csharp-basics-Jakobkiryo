// See https://aka.ms/new-console-template for more information

//How to convert mintues in to seconds:
// Exercise2:

Console.WriteLine("Welcome to minutes to seconds converter");

Console.WriteLine("Please enter a value in minutes");

string userInput = Console.ReadLine();

int usernumber = int.Parse(userInput);

int x = usernumber * 60;

Console.WriteLine($"That would be {x} seconds");