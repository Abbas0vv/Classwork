using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write something : ");

            string name = Console.ReadLine()!;

            Console.WriteLine();
            Console.Write("Which one would you like to find? : ");
            Console.WriteLine("Letters or Digits");
            string answer = Console.ReadLine()!;

            //checking
            bool isNotFound = IsContainsLetter(name);
            bool isFound = IsContainsDigit(name);

            //printing the answer
            if (answer == "1" || answer == "Letters")
            {
                if (isFound)
                {
                    Console.WriteLine();
                    Console.WriteLine("There is letter");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("No letters in this");
                }
            }
            else if (answer == "2" || answer == "Digits")
            {
                if (isNotFound)
                {
                    Console.WriteLine();
                    Console.WriteLine("There is digit!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("No digits in this!");
                }

            }
        }
        static bool IsContainsDigit(string name)
        {
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (name[i] == numbers[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static bool IsContainsLetter(string name)
        {
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                                    'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < uppercaseLetters.Length; j++)
                {
                    if (name[i] == uppercaseLetters[j] || name[i] == lowerLetters[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}