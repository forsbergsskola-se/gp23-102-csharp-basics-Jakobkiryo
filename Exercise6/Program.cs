// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.JavaScript;
//unary minus operator
//how to make a negative number become postive and vice versa


Console.WriteLine("Please enter a Vaule in numbers");

string userInput = Console.ReadLine();

int usernumber1  = int.Parse(userInput);

Console.WriteLine("Please enter a value in number");

string userInput2 = Console.ReadLine();

int usernumber2  = int.Parse(userInput2);

int c = usernumber1 - usernumber2;

Console.WriteLine($"That would be {c} ");