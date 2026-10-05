Console.WriteLine("Palindrome Number");
Console.WriteLine("-----------------");
Console.WriteLine("DO you want play? (Y/N)");
var ans = Console.ReadLine()!;
while (ans == "Y" || ans == "y")
{
    Console.Write("Enter number: ");
    int rev = 0;
    int num = int.Parse(Console.ReadLine()!);
    while (num < 0)
    {
        Console.WriteLine("Please enter a positive number");
        Console.Write("Enter number: ");
        num = int.Parse(Console.ReadLine()!);
    }
    int originalNum = num;
    while (num != 0)
    {
        rev = rev * 10 + num % 10;
        num = num / 10;
    }
    if (originalNum == rev)
    {
        Console.WriteLine($"Your number: {originalNum}     Palindrome: {rev}     Result: Palindrome!!!!!");
    }
    else
    {
        Console.WriteLine($"Your number: {originalNum}     Palindrome: {rev}     Result: Not Palindrome!!!!!");
    }
    Console.Write("AGAIN? (Y/N): ");
    ans = Console.ReadLine()!;
    if (ans == "N" || ans == "n")
    {
        Console.WriteLine("Thank you for playing");
        break;
    }
}


