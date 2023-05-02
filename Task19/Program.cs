// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Main();

void Main()
{
    int number = Promt("Введите пятизначное число: ");
    if (CheckFifthSignNum(number) == true)
    {
        CheckPalindromeFifthSignNum(number);     // пустой метод исключительно для 5-значного числа с применением типа string. 
                                                 // Универсальный метод для разворота числа находится в конце основного метода.
    }
    else
    {
        Console.WriteLine("Это не пятизначное число!");
    }
    if (CheckFifthSignNum(number) == false)
    {
        if (ReturnNum(number) == number)        // метод для разворота числа, универсальный
        {
            Console.WriteLine("Но это палиндром");
        }
    }
}

int Promt(string user_message)
{
    Console.Write(user_message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

bool CheckFifthSignNum(int entered_Num)
{
    if (entered_Num >= 10000 && entered_Num < 100000)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void CheckPalindromeFifthSignNum(int checking_num)
{
    string num = Convert.ToString(checking_num);
    string process_num = $"{num[4]}{num[3]}{num[2]}{num[1]}{num[0]}";
    int mirrored_num = Convert.ToInt32(process_num);
    if (checking_num == mirrored_num)
    {
        Console.WriteLine("Это палиндром.");
    }
    else
    {
        Console.WriteLine("Это не палиндром");
    }
}

int ReturnNum(int checkingNum)
{
    int extractor = 0;
    int victimNum = checkingNum;
    int mirroredNum = 0;
    while (victimNum >= 1)
    {
        extractor = victimNum % 10;
        victimNum /= 10;
        mirroredNum += extractor;
        mirroredNum *= 10;
    }
    mirroredNum /= 10;
    return mirroredNum;
}