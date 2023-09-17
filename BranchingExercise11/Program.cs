// See https://aka.ms/new-console-template for more information

//

using System.ComponentModel.Design;
Console.WriteLine("What is your age");
int age = int.Parse(Console.ReadLine());

if (age < 12)
{
    Console.WriteLine("You are a child");
}
else if (age <= 18)
{
    Console.WriteLine("You are a teenager");
}
else
{ 
    Console.WriteLine("You are a adult");
}

//2nd part of the exercise

Console.WriteLine("Give me another integer");
string numberinput = Console.ReadLine();
int number = int.Parse(numberinput);

if (number >= age)
{
    Console.WriteLine($"the higher integer is: {number}");
}
else
{
    Console.WriteLine($"the higher integer is {age}");
}

if (number % 2 == 0)
{
    Console.WriteLine("your number is even");
}

else
{
    Console.WriteLine("your number is odd");
}


