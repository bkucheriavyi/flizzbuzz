using System;
using System.Linq;

namespace flizzbuzz
{
    public class ReverseMethodChallenge
    {
        public string Reverse(string input)
        {
            if (input == null)
            {
                return string.Empty;
            }

            return new string(input.AsEnumerable().Reverse().ToArray());
        }
    }
}
