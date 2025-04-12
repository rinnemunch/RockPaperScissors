Console.Write("Choose Rock, Paper, or Scissors: ");
string userChoice = Console.ReadLine() ?? "";

string[] options = { "Rock", "Paper", "Scissors" };
Random rand = new Random();
string computerChoice = options[rand.Next(options.Length)];

if (userChoice == computerChoice)
{
    Console.Write("It's a tie!");
}
else if (
    (userChoice == "Rock" && computerChoice == "Scissors") ||
    (userChoice == "Paper" && computerChoice == "Rock") ||
    (userChoice == "Scissors" && computerChoice == "Paper")
    )
{
    Console.Write("You win!");
}
else
{
    Console.Write("You lose!");
}