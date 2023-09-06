// See https://aka.ms/new-console-template for more information
Console.WriteLine("give me a number");

string number = Console.ReadLine();

double dbl = double.Parse(number);
Console.WriteLine(dbl);

int sgl = (int)dbl;
Console.WriteLine(sgl);

int og = Convert.ToInt32(number);
Console.WriteLine(og);