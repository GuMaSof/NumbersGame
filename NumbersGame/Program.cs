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

            int inputInteger; //Converted input from the user.

            //Controls number of attempts that the user is allowed to make before losing.
            int numberOfAttempts = 4; //I've chosen to write 4 because the if doesn't react fast enough when I write 5.

            //We need to create an object of the Random class i order to randomly choose what the right answer is going to be.
            Random randomObject = new Random();

            //Here we decide what the correct answer shall be randomly.
            int theCorrectAnswer = randomObject.Next(1, 21); //In later analysis we shall use theCorrectAnswer.

            //This structure maintains the 'game', keeping it running.
            while (gameIsOn == true)
            {
                //The obligatory message necessary for communicating with the user.
                Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket?");

                /*I choose to tell the user directly to type, because it is always best to have low competence-assumption towards the user.
                 That way you are more likely to design user-friendly software.*/
                Console.WriteLine("Skriv din gissning nu!");

                inputString = Console.ReadLine(); //Here the user puts something into the inputString.

                //We reduce the number of attempts remaining by 1 each time.
                numberOfAttempts = numberOfAttempts - 1;

                //Here we check if there are any attempts remaining.
                if (!(numberOfAttempts <= 0))
                {
                    /*Here a system for converting the inputString is required in order to carry on,
                 * so that we may analyze the input later.
                 * I would be reluctant to use if-statements for complicated selection structures, but for simple ones, like this one, it's convenient.
                 */
                    if (int.TryParse(inputString, out inputInteger))
                    {
                        //Here we check if inputInteger is the correct answer or not.
                        if (inputInteger == theCorrectAnswer)
                        {
                            Console.WriteLine("Wohoo! Du klarade det!");

                            //There is no other purpose behind putting Readline here besides keeping the console open a bit longer.
                            Console.ReadLine();

                            //Turns the while-loop off.
                            gameIsOn = false;
                        }
                        else if (inputInteger < theCorrectAnswer)
                        {
                            Console.WriteLine("Tyvärr, du gissade för lågt!");

                            //There is no other purpose behind putting Readline here besides keeping the console open a bit longer.
                            Console.ReadLine();
                        }
                        else if (inputInteger > theCorrectAnswer)
                        {
                            Console.WriteLine("Tyvärr, du gissade för högt!");

                            //There is no other purpose behind putting Readline here besides keeping the console open a bit longer.
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Error!");

                            //There is no other purpose behind putting Readline here besides keeping the console open a bit longer.
                            Console.ReadLine();
                        }
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
                    //There is no other purpose behind putting Readline here besides keeping the console open a bit longer.
                    Console.ReadLine();
                }
            }
        }
    }
}
