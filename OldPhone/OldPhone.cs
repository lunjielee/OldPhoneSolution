using System.Text;
namespace OldPhoneNS
{
    public class OldPhone
    {
        // Mapping of digits to corresponding letters
        private static readonly string[] Keypad = { " ", " ", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };
        private const char EndInput = '#';
        private const char Backspace = '*';

        public static string OldPhonePad(string input)
        {


            StringBuilder result = new StringBuilder();
            int i = 0;

            while (i < input.Length)
            {
                char currentChar = input[i];

                if (currentChar == EndInput)
                {
                    break; // End of input
                }
                else if (currentChar == Backspace)
                {
                    HandleBackspace(result);
                }
                else if (char.IsDigit(currentChar))
                {
                    i = HandleDigit(input, result, i, currentChar);
                }

                i++;
            }

            return result.ToString();
        }

        private static void HandleBackspace(StringBuilder result)
        {
            if (result.Length > 0)
            {
                result.Length--; // Backspace
            }
        }

        private static int HandleDigit(string input, StringBuilder result, int i, char currentChar)
        {
            int digit = currentChar - '0';
            int count = CountConsecutiveDigits(input, ref i, currentChar);

            // Calculate the index in the corresponding string
            int index = (count - 1) % Keypad[digit].Length;
            result.Append(Keypad[digit][index]);

            return i;
        }

        private static int CountConsecutiveDigits(string input, ref int i, char currentChar)
        {
            int count = 1;

            // Count consecutive same digits
            while (i + 1 < input.Length && input[i + 1] == currentChar)
            {
                count++;
                i++;
            }

            return count;
        }
    }
}

