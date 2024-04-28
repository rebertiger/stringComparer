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
    
    bool result = string1.ToLower().Equals(string2.ToLower());
    Console.Write($"'{string1}' and '{string2}' is ");
    if (result)
    {
        Console.WriteLine("same.");
    }
    else
    {
        Console.WriteLine("not same.");
    }
}

