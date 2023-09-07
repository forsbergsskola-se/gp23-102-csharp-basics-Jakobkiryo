// See https://aka.ms/new-console-template for more information

//Make an BMI Calculator

Console.WriteLine("Write your Weight and Height");

string userinput = Console.ReadLine();
double weight = double.Parse(userinput);

string userinput2 = Console.ReadLine();
double height = double.Parse(userinput2);

double BMI = weight/height/height;

Console.WriteLine($"Your BMI {BMI}");



