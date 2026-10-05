using System;
using System.Collections.Generic;
using System.Text;

namespace NumbersGame
{
    internal class Correction
    {
        public void CorrectAnswers( int inputInteger, int theCorrectAnswer, bool gameIsOn)
        {
            //Here we check if inputInteger is the correct answer or not.
            if (inputInteger == theCorrectAnswer)
            {
                Console.WriteLine("Wohoo! Du klarade det!");

                //Turns the while-loop off.
                gameIsOn = false;
            }
            else if (inputInteger < theCorrectAnswer)
            {
                Console.WriteLine("Tyvärr, du gissade för lågt!");

            }
            else if (inputInteger > theCorrectAnswer)
            {
                Console.WriteLine("Tyvärr, du gissade för högt!");
            }
            else
            {
                Console.WriteLine("Error!");

            }
        }
    }
}
