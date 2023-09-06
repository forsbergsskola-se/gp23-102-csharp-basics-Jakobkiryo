
//Exercise 1
//Ask the user for an input in km/h
//Print the result of converting  the value to m/s

Console.WriteLine("Welcome to km/h to m/s converter");

Console.WriteLine("Please enter a value in km/h");

string userInput = Console.ReadLine();

float usernumber = float.Parse(userInput);

float x = usernumber /60 / 60 * 1000;

Console.WriteLine($"That would be {x} m/s");



                