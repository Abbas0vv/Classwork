using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1

            //string name = Console.ReadLine()!;

            //for (int i = 0; i < name.Length; i++)
            //{
            //    char letters = name[i];
            //    Console.WriteLine(letters);
            //}

            //task 2

            //char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //string name = Console.ReadLine();
            //bool check = false;

            //for (int i = 0; i < name.Length; i++)
            //{
            //    for (int j = 0; j < name.Length; j++)
            //    {
            //        if (name[i] == numbers[j])
            //        {
            //            check = true;
            //            break;
            //        }
            //    }
            //    if (check)
            //    {
            //        Console.WriteLine("Error");
            //        break;
            //    }
            //}

            //if (!check) 
            //{
            //    for(int i = 0;i < name.Length;i++)
            //    {
            //        Console.WriteLine(name[i]);
            //    }
            //}

            //task 3

            //char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            //                            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            //char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            //                        'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //string name = Console.ReadLine()!;
            //bool check = false;

            //for (int i = 0; i < name.Length; i++)
            //{
            //    for (int j = 0; j < name.Length; j++)
            //    {
            //        if (name[i] == lowerLetters[j] || name[i] == uppercaseLetters[j])
            //        {
            //            check = true;
            //            break;
            //        }
            //    }
            //    if (check)
            //    {
            //        Console.WriteLine("Error");
            //        break;
            //    }
            //}

            //if (!check)
            //{
            //    for (int i = 0; i < name.Length; i++)
            //    {
            //        Console.WriteLine(name[i]);
            //    }
            //}

            //task 4

            //Console.Write("Pls write something : ");
            //string smthng = Console.ReadLine()!;


            //for (int i = smthng.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(smthng[i]);
            //}

            //task 5

            //Console.Write("Pls write something : ");
            //string name = Console.ReadLine()!;
            //string word = "";

            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (name[i] == ' ' || i == name.Length - 1)
            //    {
            //        Console.WriteLine(word);
            //        word = "";
            //    }
            //    else
            //    {
            //        word += name[i];
            //    }
            //}

            //task 6

            //Console.Write("Pls write your number : ");
            //string name = Console.ReadLine()!;

            //for (int i = name.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //task 7

            //Console.Write("Pls write your number : ");
            //string name = Console.ReadLine()!;

            //string x = "";
            //int length = name.Length;

            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (name[i] == name[length - 1 - i])
            //    {
            //        x += name[i];
            //    }
            //}

            //if (name == x)
            //{
            //    Console.WriteLine("Polidrom number : " + x);
            //}
            //else
            //{
            //    Console.WriteLine("This number is not polidrom!");
            //}

            //task 8

            //int x = 0;

            //Console.Write("Pls write something : ");
            //string name = Console.ReadLine()!;

            //Console.WriteLine();

            //Console.Write("Which character do you want : ");
            //char search = char.Parse(Console.ReadLine()!);

            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (search == name[i])
            //    {
            //        x++;
            //    }
            //}

            //Console.Write("Your search count : ");
            //Console.WriteLine(x);

            //task 9

            //Console.Write("Pls write your number : ");
            //string name = Console.ReadLine()!;

            //string word = "";
            //int length = name.Length;

            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (name[i] != ' ')
            //    {
            //        word += name[i];
            //    }
            //}
            //Console.WriteLine(word);

            //task 10

            //Console.Write("Pls write something : ");
            //string name = Console.ReadLine()!;

            //Console.WriteLine();
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(i + "." + name[i]);
            //}
            //Console.WriteLine();
            //Console.Write("Start Point : ");
            //int startIDX = int.Parse(Console.ReadLine()!) - 1;
            //Console.Write("Stop Point : ");
            //int stopIDX = int.Parse(Console.ReadLine()!) - 1;

            //for (int i = startIDX; i < stopIDX; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //task 11

            //char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            //                            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            //Console.Write("Pls write something : ");
            //string name = Console.ReadLine()!;
            //Console.WriteLine();
            //for (int i = 0; i < name.Length; i++)
            //{
            //    for (int k = 0; k < uppercaseLetters.Length; k++)
            //    {

            //        if (i == 0 && name[i] != uppercaseLetters[i])
            //        {
            //            Console.WriteLine("Error");
            //            break;
            //        }
            //        else if (i != 0 && name[i] == uppercaseLetters[i])
            //        {
            //            Console.WriteLine("Error");
            //            break;
            //        }
            //    }
            //}

            //task 12

            //char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            //Console.Write("Pls write your number : ");
            //string name = Console.ReadLine()!;

            //string word = "";

            ////Iterate over name characters
            //for (int i = 0; i < name.Length; i++)
            //{
            //    bool isNumber = false;

            //    //iterate over numbers
            //    for (int j = 0; j < numbers.Length; j++)
            //    {
            //        if (name[i] == numbers[j])
            //        {
            //            isNumber = true;
            //            break;
            //        }
            //    }

            //    if (!isNumber) 
            //    {
            //        word += name[i]; 
            //    }
            //}

            //Console.WriteLine(word);

            //task 13

            //Console.Write("Pls write your number : ");
            //string name = Console.ReadLine()!;

            //if (name.Length > 4 && name[0] == '+' && name[1] == '9' && name[2] == '9' && name[3] == '4')
            //{
            //    Console.WriteLine(name);
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}

            //task 14

            //Console.WriteLine("Write your first word : ");
            //string firstWord = Console.ReadLine()!;

            //Console.WriteLine("Write your second word : ");
            //string secondWord = Console.ReadLine()!;

            //string x = "";

            //for (int i = 0; i < secondWord.Length; i++)
            //{
            //    for (int j = 0; j < firstWord.Length; j++)
            //    {
            //        if (secondWord[i] == firstWord[j])
            //        {
            //            x += secondWord[i];
            //            break;
            //        }
            //    }
            //}

            //if (x == secondWord)
            //{
            //    Console.WriteLine("Okay");
            //}
            //else
            //{
            //    Console.WriteLine("Not Okay");
            //}

            //Task lab.

            //Console.Write("Write your first number : ");
            //decimal firstNumber = decimal.Parse(Console.ReadLine()!);

            //Console.Write("Write your second number : ");
            //decimal secondNumber = decimal.Parse(Console.ReadLine()!); 

            //decimal total = 0;

            //if (firstNumber < 0)
            //{
            //    firstNumber = -firstNumber;
            //    secondNumber = -secondNumber;
            //}

            //for (int i = 0; i < firstNumber; i++)
            //{
            //    total += secondNumber;
            //}

            //Console.Write("This is total : ");
            //Console.WriteLine(total);
        }
    }
}