namespace Rock_Paper_Scissors_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int playerScore = 0;
            int enemyScore = 0;

            Console.WriteLine("Welcome to the Rock-Paper-Scissors Game !");
            

            while (playerScore != 3 && enemyScore != 3) 
            {
                Console.WriteLine($"Players score - {playerScore}    Enemy score - {enemyScore}");
                Console.WriteLine("Press r for rock, p for paper and any other keyboard for scissors.");
                int enemyChoice = random.Next(0, 3);
                string playerChoice = Console.ReadLine();
                
                if (enemyChoice == 0) 
                {
                    Console.WriteLine("Enemy choose rock !");
                    switch(playerChoice) 
                    {
                        case "r":
                            Console.WriteLine("Tie");
                            break;
                        case "p":
                            Console.WriteLine("Player wins !");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Enemy wins !");
                            enemyScore++;
                            break;
                    }
                }
                else if (enemyChoice == 1) 
                {
                    Console.WriteLine("Enemy choose paper !");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy wins !");
                            enemyScore++;
                            break;
                        case "p":
                            Console.WriteLine("Tie !");
                            break;
                        default:
                            Console.WriteLine("Player wins !");
                            playerScore++;
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Enemy choose scissors !");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player wins !");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Enemy wins !");
                            enemyScore++;
                            break;
                        default:
                            Console.WriteLine("Tie !");
                            break;
                    }
                }
            }

            if (playerScore == 3)
            {
                Console.WriteLine("You won the game !!!");
            }
            else
            {
                Console.WriteLine("You lose !!!");
            }
        }
    }
}