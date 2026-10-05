using System;
using System.Collections.Generic;
using System.Text;

namespace NumbersGame
{
    internal class Correction
    {
        private int inputInteger;
        private int theCorrectAnswer;
        private bool gameIsOn;

        public Correction (int inputInteger, int theCorrectAnswer, bool gameIsOn)
        {
            this.inputInteger = inputInteger;
            this.theCorrectAnswer = theCorrectAnswer;
            this.gameIsOn = gameIsOn;
        }
        public void CorrectAnswers()
        {
            //Here we check if inputInteger is the correct answer or not.
            if (inputInteger == theCorrectAnswer)
            {
                Console.WriteLine("Wohoo! Du klarade det!");
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
