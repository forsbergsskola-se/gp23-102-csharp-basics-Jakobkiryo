// random number generator
Console.WriteLine("pass me a seed");

string userInput = Console.ReadLine();
Random random = new Random(int.Parse(userInput));

Console.WriteLine(random.Next(5));
Console.WriteLine(random.Next(5));
Console.WriteLine(random.Next(5));

//Added random numbers between 0.2 and 0.5

Console.WriteLine("Add three numbers between 0.0 and 0.5");

Console.WriteLine(random.NextDouble() * 0.5);
Console.WriteLine(random.NextDouble() * 0.5);
Console.WriteLine(random.NextDouble() * 0.5);

//three numbers between 0.2 and 0.7

Console.WriteLine("Add three numbers between 0.2 and 0.7");
double number2  = random.NextDouble() * 0.7;

Console.WriteLine(random.NextDouble() * .2 + .5);
Console.WriteLine(random.NextDouble() * .2 + .5);
Console.WriteLine(random.NextDouble() * .2 + .5);

//Give me a crit chance between 0,0 (0%) and , 1,0 (100%)

Console.WriteLine("Give me a crit chance between 0,0 (%0) and 1,0 (100%)");

double Critchance = double.Parse(Console.ReadLine());

Console.WriteLine(random.NextDouble() < Critchance ? "Crit" : "No Crit");
Console.WriteLine(random.NextDouble() < Critchance ? "Crit" : "No Crit");
Console.WriteLine(random.NextDouble() < Critchance ? "Crit" : "No Crit");
Console.WriteLine(random.NextDouble() < Critchance ? "Crit" : "No Crit");

if (random.NextDouble() < Critchance)
{
    Console.WriteLine("Crit");
}
else
{
    Console.WriteLine("no Crit");
}