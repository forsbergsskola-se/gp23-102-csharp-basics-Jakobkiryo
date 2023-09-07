// See https://aka.ms/new-console-template for more information

//calculate numbers using multiplication operator

Console.WriteLine("Please enter a Vaule in numbers");

string userInput = Console.ReadLine();

int usernumber1  = int.Parse(userInput);

Console.WriteLine("Please enter a value in number");

string userInput2 = Console.ReadLine();

int usernumber2  = int.Parse(userInput2);

float c = (float)usernumber1 * usernumber2;

Console.WriteLine($"That would be {c} ");