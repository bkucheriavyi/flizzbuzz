using System;
using System.Linq;

namespace flizzbuzz
{
    public class WordFromTextChallenge
    {
        public object GetWordFromText(string input, int pos)
        {
            if(pos < 1)
            {
                throw new Exception($"Invalid arg {nameof(pos)}");
            }

            var values = input.Trim().Split(' ').Select(c=> c.Trim()).ToArray();

            if (pos > values.Length)
            {
                throw new Exception("Invalid position");
            }

            return values[pos - 1];
        }
    }
}
