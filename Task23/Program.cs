// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Main();

void Main()
{
    int numN = Promt("Введите число N: ");
    PrintCubeTable(numN);
}

int Promt(string user_message)
{
    Console.Write(user_message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return Math.Abs(result);
}

void PrintCubeTable(int user_num)
{
    int sqr = 1;
    int current_num = 1;
    while (current_num <= user_num)
    {
        sqr = current_num * current_num * current_num;
        Console.Write(sqr + "|");
        current_num++;
    }
}