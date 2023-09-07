// See https://aka.ms/new-console-template for more information

//

using System.ComponentModel.Design;
Console.WriteLine("What is your age");
int age = int.Parse(Console.ReadLine());

if (age < 12)
{
    Console.WriteLine("You are a child");
}
else if (age < 18)
{
    Console.WriteLine("You are a teenager");
}
else
{ 
    Console.WriteLine("You are a adult");
}

//2nd part of the exercise

Console.WriteLine("Give me another integer");
int number = int.Parse(Console.ReadLine());

int max = age > number ? age : number;
Console.WriteLine($"the higher integer is: {max}");

if (max % 2 == 0)
{
    Console.WriteLine("your number is even");
}
else
{
    Console.WriteLine("your number is odd");
}


