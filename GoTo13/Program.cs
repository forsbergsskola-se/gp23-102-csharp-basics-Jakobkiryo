Console.WriteLine("I have picked a number between (1-100). It´s your turn to guess");

string userInput = Console.ReadLine();

Random random = new Random(int.Parse(userInput));
