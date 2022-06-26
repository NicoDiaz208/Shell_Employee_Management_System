using System;
using System.Text;

namespace CommonBase
{
    public static class Validators
    {
        public static bool ValidateSocialSecurityNumber(string number)
        {
            if (string.IsNullOrEmpty(number))
                return false;

            var weights = new int[] { 3, 7, 9, 0, 5, 8, 4, 2, 1, 6 };

            int check = 0;
            for (int i = 0; i < number.Length; i++)
                check += (number[i] - '0') * weights[i];

            return check % 11 == (number[3] - '0');
        }

        public static bool ValidateDrugNumber(string number)
        {
            if (string.IsNullOrEmpty(number))
                return false;

            var result = number != null && number.Where((c, i) => i == 9 ? (c == 'X' || c == 'x' || char.IsDigit(c)) : char.IsDigit(c)).Count() == 10;
            var sum = 0;
            for (int i = 0; i < number?.Length - 1 && result; i++)
                sum += (number == null ? 0 : number[i] - '0') * (i + 1);
            sum %= 11;

            return result && number != null && ((sum == 10 && char.ToUpper(number[^1]) == 'X') || (sum == number[^1] - '0'));
        }
    }
}
