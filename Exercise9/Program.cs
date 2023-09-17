//How to calculate Hypotenuse

Console.WriteLine("type length of side A");
string side1 = Console.ReadLine();
float a = float.Parse(side1);

Console.WriteLine("type length of side B ");
string side2 = Console.ReadLine();
float b = float.Parse(side2);

float calculation = (a*a) + (b*b);

double tot = Math.Sqrt(calculation);

Console.WriteLine($"{tot}");