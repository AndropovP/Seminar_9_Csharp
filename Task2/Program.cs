// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

 int ReadInt(string message)
{
    Console.Write($"{message} ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }
    System.Console.WriteLine("Вы ввели не число!");
    Environment.Exit(0);
    return 0;
}

int M = ReadInt("Введите натуральное число -> ");
int N = ReadInt("Введите натуральное число -> ");

int SummaElements(int M, int N)
{
    if (M > N) return 0;
    return M + SummaElements(M + 1, N);
}

System.Console.WriteLine(SummaElements(M, N));
