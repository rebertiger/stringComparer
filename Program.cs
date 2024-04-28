string string1;
string string2;

while (true)
{
    while (true)
    {
        Console.WriteLine("Enter first string to compare: ");
        string1 = Console.ReadLine();
        if (string1 != "" && string1.Length > 1)
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
        if (string2 != "" && string2.Length > 1)
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

