// See https://aka.ms/new-console-template for more information


Console.WriteLine("what is your age?");

string userInput = Console.ReadLine();

int userage = int.Parse(userInput);

bool ischild = userage < 13 - 0 ;
bool isteenager = userage >= 13 && userage <= 19;
bool isgrownup = userage > 19;

Console.WriteLine($"you are a child {ischild}");


Console.WriteLine($"you are a teenager {isteenager}");


Console.WriteLine($"you are a grownup {isgrownup}");


