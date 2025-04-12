Console.Write("Choose Rock, Paper, or Scissors: "); 
string userChoice = Console.ReadLine() ?? "";   

string[] options = { "Rock", "Paper", "Scissors" }; 
Random rand = new Random(); 
string computerChoice = options[rand.Next(options.Length)]; 