using System.Security.Cryptography.X509Certificates;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Turns the while-loop on and off.
            bool gameIsOn = true; //We'll use this when we turn off the game.

            string inputString; //The unconverted input from the user.

            int inputInteger; //Converted input from the user. Assigned initial value to fend off the error messages. Will assign a different one later.

            //Controls number of attempts that the user is allowed to make before losing.
            int numberOfAttempts = 5;

            //We need to create an object of the Random class i order to randomly choose what the right answer is going to be.
            Random randomObject = new Random();
            
            //Here we decide what the correct answer shall be randomly.
            int theCorrectAnswer = randomObject.Next(1, 20); //In later analysis we shall use theCorrectAnswer.

            while (gameIsOn == true)
            {
                for(int i = 0; i < numberOfAttempts; i++)
                {
                    //The obligatory message necessary for communicating with the user.
                    Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket?");

                    /*I choose to tell the user directly to type, because it is always best to have low competence-assumption towards the user.
                     That way you are more likely to design user-friendly software.*/
                    Console.WriteLine("Skriv din gissning nu!");

                    inputString = Console.ReadLine(); //Here the user puts something into the inputString.

                    if ((i !< numberOfAttempts))
                    {
                        /*Here a system for converting the inputString is required in order to carry on,
                     * so that we may analyze the input later.
                     */
                        if (int.TryParse(inputString, out inputInteger))
                        {
                            Correction correctingGuesses = new Correction(inputInteger, theCorrectAnswer, gameIsOn);
                            correctingGuesses.CorrectAnswers();
                        }
                        else
                        {
                            //Necessary error message to communicate in case the user happens to type in a letter.
                            Console.WriteLine("Error! Du måste skriva en siffra!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");

                        gameIsOn = false; //Here we turn the while-loop off.

                    }
                }
            }
        }
    }
}
