// See https://aka.ms/new-console-template for more information

//Make an BMI Calculator

Console.WriteLine("Write your Weight and Height");

string userinput = Console.ReadLine();
float weight = float.Parse(userinput);

string userinput2 = Console.ReadLine();
float height = float.Parse(userinput2);

double BMI = weight / (height*height /100f / 100f);

Console.WriteLine($"Your BMI {BMI}");



