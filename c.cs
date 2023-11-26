using System;

class Program
{
    static void Main()
    {
        // QUESTION ONE
        int n = GetRandomNumber();
        PrintPositiveOrNegative(n);

        // QUESTION TWO
        int m = GetRandomNumber();
        PrintLastDigit(m);

        // QUESTION THREE
        int a = 5, b = 10;
        SwapIntegers(ref a, ref b);
        Console.WriteLine($"After swapping: a = {a}, b = {b}");

        // QUESTION FOUR
        PrintStringWithNewLine("Hello, World!");

        // QUESTION FIVE
        ReverseAndPrintString("OpenAI");

        // QUESTION SIX
        string str = "PrefixSubstring";
        int prefixLength = GetPrefixLength(str, "Prefix");
        Console.WriteLine($"Length of prefix substring: {prefixLength}");
    }

    // Function for QUESTION ONE
    static int GetRandomNumber()
    {
        Random random = new Random();
        return random.Next(-10, 11); // Generate a random number between -10 and 10
    }

    static void PrintPositiveOrNegative(int number)
    {
        if (number > 0)
            Console.WriteLine("The number is positive.");
        else if (number < 0)
            Console.WriteLine("The number is negative.");
        else
            Console.WriteLine("The number is zero.");
    }

    // Function for QUESTION TWO
    static void PrintLastDigit(int number)
    {
        int lastDigit = Math.Abs(number % 10);
        Console.WriteLine($"The last digit of the number is: {lastDigit}");
    }

    // Function for QUESTION THREE
    static void SwapIntegers(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // Function for QUESTION FOUR
    static void PrintStringWithNewLine(string inputString)
    {
        Console.WriteLine(inputString);
    }

    // Function for QUESTION FIVE
    static void ReverseAndPrintString(string inputString)
    {
        char[] charArray = inputString.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(new string(charArray));
    }

    // Function for QUESTION SIX
    static int GetPrefixLength(string str, string prefix)
    {
        int length = 0;
        while (length < str.Length && length < prefix.Length && str[length] == prefix[length])
        {
            length++;
        }
        return length;
    }
}
