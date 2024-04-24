using System;
using System.Collections.Generic;

namespace GameLogic
{
    public class GameLogic
    {
        public string GenerateUniqueFourDigitNumber()
        {
            Random random = new Random();
            List<int> availableDigits = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string result = "";

            for (int i = 0; i < 4; i++)
            {
                int index = random.Next(0, availableDigits.Count);
                result += availableDigits[index].ToString();
                availableDigits.RemoveAt(index); // Remove the selected digit to ensure uniqueness
            }

            return result;
        }
    }
}
