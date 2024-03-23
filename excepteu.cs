public static char Method2(char input)
{
    // Example implementation that returns the next character in the alphabet
    if(input >= 'a' && input < 'z')
    {
        return (char)(input + 1);
    }
    else if(input == 'z')
    {
        return 'a'; // Wrap around to the start of the alphabet
    }
    else
    {
        return input; // Return the input if it's not a lowercase letter
    }
}

public static void Main(string[] args)
{
    Console.WriteLine(Method2('c')); // This will output 'd'
}
