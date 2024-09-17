using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        
        while (playAgain)
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int guess = -1;
            int guesses = 0;

            while (magicNumber != guess)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
            
                guesses++;
            }
        
            Console.WriteLine($"You guessed the magic number {magicNumber} in {guesses} guesses!");
            
            Console.Write("Do you want to play again? (y/n) ");
            string playAgainInput = Console.ReadLine(); 
            
            playAgain = playAgainInput == "y";
        }
        
        Console.WriteLine("Thanks for playing!");
    }
}