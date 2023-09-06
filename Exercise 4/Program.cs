// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to divison");

Console.WriteLine("Please enter a value in number");

string userInput = Console.ReadLine();

int usernumber = int.Parse(userInput);

Console.WriteLine("Please enter a value in number");

string userInput2 = Console.ReadLine();

int usernumber2 = int.Parse(userInput2);

float c = (float)usernumber / usernumber2;

Console.WriteLine($"That would be {c} ");