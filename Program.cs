using System;

internal class Program
{

    private static string currentWord = "Citadel";

    public static void Main(string[] args)
    {
        Console.WriteLine("Type 'help' for commands");
        Menu();
    }

    public static void Menu()
    {
        var userInput = "";

        while (true)
        {
            userInput = Console.ReadLine().ToLower();
            
            switch (userInput)
            {
                case "exit":
                    Environment.Exit(0);
                    break;

                case "clear":
                    Console.Clear();
                    break;

                case "help":
                    HelpMenu();
                    break;

                case "change":
                    Console.Write("Enter new word: ");
                    currentWord = Console.ReadLine().ToLower();
                    Console.WriteLine($"Current Word: {currentWord}");
                    break;

                case "reverse":
                    ReverseWord();
                    break;

                case "replace":
                    ReplaceChar();
                    break;

                default:
                    Console.WriteLine("Unknown command. Type 'help' for a list of commands.");
                    break;
            }
        }
    }

    static void HelpMenu()
    {
        Console.WriteLine("'exit' - exit console");
        Console.WriteLine("'clear' - clear console");
        Console.WriteLine("'help' - list commands");
        Console.WriteLine("'change' - change the current word");
        Console.WriteLine("'reverse' - reverse currentWord");
        Console.WriteLine("'replace' - replace char in currentWord");
    }



    static void ReverseWord()
    {
        char[] charArray = currentWord.ToCharArray();

        Array.Reverse(charArray);
        string reversedWord = new string(charArray);

        Console.WriteLine($"{currentWord} = '{reversedWord}'");

    }

    static void ReplaceChar()
    {
        Console.Write("Enter character to replace: ");
        char charToReplace = Console.ReadLine()[0];

        Console.Write("Enter replacement character: ");
        char replacementChar = Console.ReadLine()[0];



        currentWord = currentWord.Replace(charToReplace, replacementChar);
        Console.WriteLine($"Updated Word: {currentWord}");
    }

}