//Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

static bool IsPalindrome(string input)
{
        int length = input.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (input[i] != input[length - i - 1])
            {
                return false;
            }
        }
        return true;
}

Console.Write("Введите слово или фразу: ");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("Да, это палиндром.");
        }
        else
        {
            Console.WriteLine("Нет, это не палиндром.");
        }

        Console.ReadLine();