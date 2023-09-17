// See https://aka.ms/new-console-template for more information

Console.WriteLine("Give me a number of seconds");


int totalseconds = int.Parse(Console.ReadLine());

int minutes = totalseconds / 60;

int seconds = totalseconds % 60;

Console.WriteLine($"that will be {minutes} minutes and {seconds} seconds");

