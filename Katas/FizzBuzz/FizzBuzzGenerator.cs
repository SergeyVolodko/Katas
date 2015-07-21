
namespace Katas.FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public string Generate(int n)
        {
            var result = "";
            for (int i = 1; i < n + 1; i++)
            {
                result += GetNumberString(i) + ' ';
            }


            return result.TrimEnd(' ');
        }

        private string GetNumberString(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}
