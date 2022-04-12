using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingApp
{
    public class BowlingGame :IBowlingGame
    {
        private int[] _rolls = new int[21];
        private int _currentRoll = 0;

        /// <summary>
        /// Add the score of a Current Roll
        /// </summary>
        /// <param name="pins"></param>
        public void AddRollScore(int pins)
        {
            _rolls[_currentRoll++] = pins;
        }

        /// <summary>
        /// //Get the Score for valid completed game
        /// </summary>
        /// <returns></returns>
        public int GetScore()
        {
            var score = 0;
            var index = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                //Strike 
                if (CheckStrike(index))
                {
                    score += GetStrikeScore(index);
                    index++;
                }
                //spare
                else if (CheckSpare(index))
                {
                    score += GetSpareScore(index);
                    index += 2;
                }
                //standard
                else
                {
                    score += GetStandardFrameScore(index);
                    index += 2;
                }
            }
            return score;
        }

        private int GetStrikeScore(int index)
        {
            return _rolls[index] + _rolls[index + 1] + _rolls[index + 2];
        }

        private bool CheckStrike(int index)
        {
            return _rolls[index] == 10;
        }

        private int GetStandardFrameScore(int index)
        {
            return _rolls[index] + _rolls[index + 1];
        }

        private int GetSpareScore(int index)
        {
            return _rolls[index] + _rolls[index + 1] + _rolls[index + 2];
        }

        private bool CheckSpare(int index)
        {
            return _rolls[index] + _rolls[index + 1] == 10;
        }

    }
}
