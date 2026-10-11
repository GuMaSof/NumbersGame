using System;
using System.Collections.Generic;
using System.Text;

namespace NumbersGame
{
    internal class Correction
    {
        private int inputInteger;
        private int theCorrectAnswer;

        public Correction (int inputInteger, int theCorrectAnswer)
        {
            this.inputInteger = inputInteger;
            this.theCorrectAnswer = theCorrectAnswer;
        }
        public bool CorrectAnswers(bool gameIsOn)
        {
            //Here we check if inputInteger is the correct answer or not.
            if (inputInteger == theCorrectAnswer)
            {
                Console.WriteLine("Wohoo! Du klarade det!");
                return gameIsOn = false;
            }
            else if (inputInteger < theCorrectAnswer)
            {
                Console.WriteLine("Tyvärr, du gissade för lågt!");
                return gameIsOn = true;

            }
            else if (inputInteger > theCorrectAnswer)
            {
                Console.WriteLine("Tyvärr, du gissade för högt!");
                return gameIsOn = true;
            }
            else
            {
                Console.WriteLine("Error!");
                return gameIsOn = true;

            }
        }
    }
}
