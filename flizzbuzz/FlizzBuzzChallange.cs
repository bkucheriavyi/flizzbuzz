using System;
using System.Text;
using System.Linq;

namespace flizzbuzz
{
    public class FizzBuzzChallange
    {
        public const string Fizz = "fizz";
        public const string Buzz = "buzz";
        public const string FizzBuzz = "fizzbuzz";
        public const string Lucky = "lucky";

        public string Magic_3_5_15(int from, int to)
        {
            if(from >= to)
            {
                throw new ArgumentException($"{nameof(from)} can't be >= {nameof(to)}");
            }

            if (from < 1 || to < 1)
            {
                throw new ArgumentException($"{nameof(from)},{nameof(to)} can't be less the 1");
            }
            var sb = new StringBuilder();
            for (int i = 1; i <= to - from; i++)
            {
                if (i.ToString().Contains("3"))
                {
                    sb.Append(Lucky);
                    sb.Append(" ");
                    continue;
                }

                if (i % 15 == 0)
                {
                    sb.Append(FizzBuzz);
                    sb.Append(" ");
                    continue;
                }

                if ( i % 5 == 0)
                {
                    sb.Append(Buzz);
                    sb.Append(" ");
                    continue;
                }

                if(i % 3 == 0)
                {
                    sb.Append(Fizz);
                    sb.Append(" ");
                    continue;
                }

                sb.Append(i);
                sb.Append(" ");

            }
            return sb.ToString();
        }

        public string GetSummary(string result)
        {
            var values = result.Split(' ');
            var groups = values.GroupBy(c => c).Where(g => !int.TryParse(g.FirstOrDefault(), out var r));

            return $"fizz: {groups.FirstOrDefault(g => g.Key == Fizz)?.Count()}\n" +
                $"buzz: {groups.FirstOrDefault(g => g.Key == Buzz)?.Count()}\n" +
                $"fizzbuzz: {groups.FirstOrDefault(g => g.Key == FizzBuzz)?.Count()}\n" +
                $"lucky: {groups.FirstOrDefault(g => g.Key == Lucky)?.Count()}\n" +
                $"integer: {values.Count() - groups.Sum(g => g.Count())}";
        }
    }
}
