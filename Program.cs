// Welcome message for the Rock Paper Scissors game.
Console.WriteLine("Hello, welcome to the rock paper scissors game!");
Thread.Sleep(3000); // Wait for 3 seconds.

// Ask the user to choose Rock, Paper, or Scissors.
Console.WriteLine("Rock ? Paper ? Scissors ?");
string infoOption = Console.ReadLine(); // Read the user's choice.

// Generate a random move for the computer.
string computerMove = new string[] { "Rock", "Paper", "Scissors" }[new Random().Next(3)];
Console.WriteLine("computer : " + computerMove); // Display the computer's move.
Console.WriteLine(" your move : " + infoOption); // Display the user's move.

// Check the result based on the user's and computer's moves.
if (infoOption == computerMove)
{
    Console.WriteLine("The result is a draw!"); // If both moves are the same.
}
else if (
    (infoOption == "Rock" && computerMove == "Scissors") ||
    (infoOption == "rock" && computerMove == "Scissors") ||
    (infoOption == "Paper" && computerMove == "Rock") ||
    (infoOption == "paper" && computerMove == "Rock") ||
    (infoOption == "Scissors" && computerMove == "Paper") ||
    (infoOption == "scissors" && computerMove == "Paper")
)
{
    Console.WriteLine("You Win!"); // User wins based on the rules.
}
else if (
    (computerMove == "Rock" && infoOption == "Scissors") ||
    (computerMove == "Rock" && infoOption == "scissors") ||
    (computerMove == "Paper" && infoOption == "Rock") ||
    (computerMove == "Paper" && infoOption == "rock") ||
    (computerMove == "Scissors" && infoOption == "Paper") ||
    (computerMove == "Scissors" && infoOption == "paper")
)
{
    Console.WriteLine("Computer Win!"); // Computer wins based on the rules.
}
else
{
    Console.WriteLine("There is a typo or this is not an option!"); // Invalid input.
}