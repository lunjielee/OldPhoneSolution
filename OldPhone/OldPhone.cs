using System.Text;
namespace OldPhoneNS
{
    public class OldPhone
    {
        public static string OldPhonePad(string input)
        {
            // Mapping of digits to corresponding letters
            string[] keypad = { " ", " ", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };
            StringBuilder result = new StringBuilder();
            int i = 0;

            while (i < input.Length)
            {
                char currentChar = input[i];

                if (currentChar == '#')
                {
                    break; // End of input
                }
                else if (currentChar == '*')
                {
                    if (result.Length > 0)
                    {
                        result.Length--; // Backspace
                    }
                }
                else if (char.IsDigit(currentChar))
                {
                    int digit = currentChar - '0';
                    int count = 1;

                    // Count consecutive same digits
                    while (i + 1 < input.Length && input[i + 1] == currentChar)
                    {
                        count++;
                        i++;
                    }

                    // Calculate the index in the corresponding string
                    int index = (count - 1) % keypad[digit].Length;
                    result.Append(keypad[digit][index]);
                }

                i++;
            }

            return result.ToString();
        }
        public static void Main()
        {
            Console.WriteLine(OldPhonePad("33#")); // Expected output: E
            Console.WriteLine(OldPhonePad("227 *#")); // Expected output: B
            Console.WriteLine(OldPhonePad("4433555 555666#")); // Expected output: HELLO
            Console.WriteLine(OldPhonePad("8 88777444666 * 664#")); // Expected output: TURING
        }
    }
}

