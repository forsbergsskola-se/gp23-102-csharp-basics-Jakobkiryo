//Start of the game

Gamestart:

Console.WriteLine("Welcome to Nim");
Console.WriteLine("|||||||||||||||||||||||| (24)");;

int totalMatches = 24;

    Console.WriteLine("How many matches do you want to draw?");
    int userInput = int.Parse(Console.ReadLine());

matches:
//Maximum matches you can pick is 3.
if (userInput is >3 or < 1)
{
    Console.WriteLine("Trying to cheat ehh, you can only pick between 1 - 3, Pick Again!");
    goto matches;
}

if (userInput >= 0 && totalMatches <= 24);

//players turn.

{
    int userDraw = totalMatches - userInput;
    Console.WriteLine($"Player draws {userInput}");
    totalMatches -= userInput;
    
    
//AI:S turn

    int aiChoice = Random.Shared.Next(1, 4);
    Console.WriteLine($"The AI draws {aiChoice}");
    totalMatches -= aiChoice;
    Console.WriteLine("Matches Reamining:" + totalMatches);
    
    goto matches;
}
