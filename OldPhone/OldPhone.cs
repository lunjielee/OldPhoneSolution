using System.Text;
namespace OldPhoneNS
{
    /// <summary>
    /// The OldPhone class provides functionality to simulate typing on an old mobile phone keypad.
    /// </summary>
    public class OldPhone
    {
        // Mapping of digits to corresponding letters
        private static readonly string[] Keypad = { " ", " ", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };
        private const char EndInput = '#';
        private const char Backspace = '*';

        /// <summary>
        /// Converts a string of keypresses on an old mobile phone keypad into the corresponding text.
        /// </summary>
        /// <param name="input">A string representing the sequence of keypresses.</param>
        /// <returns>A string representing the text typed on the old mobile phone keypad.</returns>
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

        /// <summary>
        /// Handles the backspace operation by removing the last character from the result.
        /// </summary>
        /// <param name="result">The StringBuilder containing the current result.</param>
        private static void HandleBackspace(StringBuilder result)
        {
            if (result.Length > 0)
            {
                result.Length--; // Backspace
            }
        }

        /// <summary>
        /// Handles the digit input by appending the corresponding letter to the result.
        /// </summary>
        /// <param name="input">The input string of keypresses.</param>
        /// <param name="result">The StringBuilder containing the current result.</param>
        /// <param name="i">The current index in the input string.</param>
        /// <param name="currentChar">The current character being processed.</param>
        /// <returns>The updated index after processing consecutive digits.</returns>
        private static int HandleDigit(string input, StringBuilder result, int i, char currentChar)
        {
            int digit = currentChar - '0';
            int count = CountConsecutiveDigits(input, ref i, currentChar);

            // Calculate the index in the corresponding string
            int index = (count - 1) % Keypad[digit].Length;
            result.Append(Keypad[digit][index]);

            return i;
        }

        /// <summary>
        /// Counts the number of consecutive same digits in the input string.
        /// </summary>
        /// <param name="input">The input string of keypresses.</param>
        /// <param name="i">The current index in the input string.</param>
        /// <param name="currentChar">The current character being processed.</param>
        /// <returns>The count of consecutive same digits.</returns>
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

