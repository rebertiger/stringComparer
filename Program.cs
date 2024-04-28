string string1;
string string2;

while (true)
{
    while (true)
    {
        Console.WriteLine("Enter first string to compare: ");
        string1 = Console.ReadLine();
        if (!string.IsNullOrEmpty(string1))
        {
            break;
        }
        else
        {
            Console.WriteLine("Wrong input, try again.");
        }
    }

    while (true)
    {
        Console.WriteLine("Enter second string to compare: ");
        string2 = Console.ReadLine();
        if (!string.IsNullOrEmpty(string2))
        {
            break;
        }
        else
        {
            Console.WriteLine("Wrong input, try again.");
        }
    }

    string[] string1words = string1.Split(' ');
    string[] string2words = string2.Split(" ");
    //check if words match by comparing one by one
    for (int i = 0; i < Math.Min(string1words.Length, string2words.Length); i++)
    {
        if (!string.Equals(string1words[i], string2words[i], StringComparison.Ordinal))
        {
            Console.WriteLine($"Difference: \"{string1words[i]}\" (In first string: {i + 1}. word,\n \"{string2words[i]}\"  In second string: {i + 1}. word)");
        }
    }
    //check if one of the input strings have extra word than other
    if (string1words.Length > string2words.Length)
    {
        for (int i = string2words.Length; i < string1words.Length; i++)
        {
            Console.WriteLine($"Extra word in the first string is: \"{string1words[i]}\"");

        }
    }
    else if (string1words.Length < string2words.Length)
    {
        for (int i = string1words.Length; i < string2words.Length; i++)
        {
            Console.WriteLine($"Extra word in second string is: \"{string2words[i]}\"");
        }
    }
}